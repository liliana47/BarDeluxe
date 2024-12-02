using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using System.Security.Cryptography.Xml;

namespace BLL
{
    public class FacturaBLL
    {
        private FacturaDAL facturaDAL = new FacturaDAL();

        public void GuardarFactura(Factura factura)
        {
            if (factura == null)
                throw new ArgumentNullException(nameof(factura), "La factura no puede ser nula.");

            if (factura.Cliente == null || string.IsNullOrWhiteSpace(factura.Cliente.Cedula))
                throw new ArgumentException("La factura debe incluir un cliente válido con cédula.");

            if (factura.Productos == null || factura.Productos.Count == 0)
                throw new ArgumentException("La factura debe incluir al menos un producto.");

            if (factura.Total <= 0)
                throw new ArgumentException("El total de la factura debe ser mayor que cero.");

            try
            {
                facturaDAL.GuardarFactura(factura);
                if (factura.Id <= 0)
                {
                    throw new Exception("No se pudo obtener un número de factura válido después de guardar.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en la capa de negocio al guardar la factura: {ex.Message}", ex);
            }
        }

        public List<Factura> ObtenerFacturas()
        {
            return facturaDAL.ObtenerFacturas();
        }

        public Factura ObtenerDetallesFactura(int numeroFactura)
        {
            Factura factura = facturaDAL.ObtenerDetallesFactura(numeroFactura);
            if (factura != null)
            {
                if (factura.Cliente == null || factura.Productos == null)
                {
                    throw new Exception("Datos incompletos para la factura.");
                }
            }
            return factura;
        }

        public double ObtenerTotalFacturas()
        {
            return facturaDAL.ObtenerTotalFacturas();
        }

        public Dictionary<string, int> ObtenerFacturasPorPeriodo(string periodo)
        {
            return facturaDAL.ObtenerFacturasPorPeriodo(periodo);
        }

        public void ProcesarFactura(int numeroFactura)
        {
            if (!ExistePdf(numeroFactura))
            {
                throw new FileNotFoundException($"No se encontró el PDF para la factura {numeroFactura}.");
            }

            if (!ExisteCertificado())
            {
                throw new FileNotFoundException("No se encontró el certificado digital.");
            }

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string folderPath = Path.Combine(desktopPath, "ArchivosFirmados");

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string pdfPath = ObtenerRutaPdf(numeroFactura);
            string xmlPath = Path.Combine(folderPath, $"Factura_{numeroFactura}.xml");
            string signedXmlPath = Path.Combine(folderPath, $"Factura_{numeroFactura}_Firmado.xml");
            GenerarXmlDesdePdf(pdfPath, xmlPath);

            if (!File.Exists(xmlPath))
            {
                throw new FileNotFoundException($"El archivo XML no se generó correctamente: {xmlPath}");
            }

            FirmarXml(xmlPath, signedXmlPath);

            if (!File.Exists(signedXmlPath))
            {
                throw new FileNotFoundException($"El archivo XML firmado no se generó correctamente: {signedXmlPath}");
            }
        }


        private void GenerarXmlDesdePdf(string pdfPath, string xmlPath)
        {
            using (PdfReader pdfReader = new PdfReader(pdfPath))
            {
                PdfDocument pdfDocument = new PdfDocument(pdfReader);
                System.Text.StringBuilder contenido = new System.Text.StringBuilder();

                for (int i = 1; i <= pdfDocument.GetNumberOfPages(); i++)
                {
                    string texto = PdfTextExtractor.GetTextFromPage(pdfDocument.GetPage(i));
                    contenido.Append(texto);
                }

                pdfDocument.Close();

                XDocument xmlDoc = new XDocument(
                    new XElement("FacturaElectronica",
                        new XElement("Encabezado",
                            new XElement("NumeroFactura", Path.GetFileNameWithoutExtension(pdfPath).Split('_')[1]),
                            new XElement("FechaFactura", DateTime.Now.ToString("yyyy-MM-dd"))
                        ),
                        new XElement("Detalles",
                            new XElement("ContenidoExtraido", contenido.ToString())
                        )
                    )
                );

                xmlDoc.Save(xmlPath);
            }
        }

        private void FirmarXml(string xmlPath, string signedXmlPath)
        {
            string certificatePath = ObtenerRutaCertificado();
            string certificatePassword = "12345"; 

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlPath);

            X509Certificate2 certificado = new X509Certificate2(certificatePath, certificatePassword);

            if (!certificado.HasPrivateKey)
            {
                throw new InvalidOperationException("El certificado no contiene una clave privada.");
            }

            SignedXml signedXml = new SignedXml(xmlDoc)
            {
                SigningKey = certificado.GetRSAPrivateKey()
            };

            signedXml.SignedInfo.SignatureMethod = SignedXml.XmlDsigRSASHA256Url;

            Reference referencia = new Reference
            {
                Uri = "" 
            };
            referencia.AddTransform(new XmlDsigEnvelopedSignatureTransform());
            signedXml.AddReference(referencia);

            KeyInfo keyInfo = new KeyInfo();
            keyInfo.AddClause(new KeyInfoX509Data(certificado));
            signedXml.KeyInfo = keyInfo;

            signedXml.ComputeSignature();

            XmlElement xmlDigitalSignature = signedXml.GetXml();
            xmlDoc.DocumentElement.AppendChild(xmlDoc.ImportNode(xmlDigitalSignature, true));

            xmlDoc.Save(signedXmlPath);
        }

        public string ObtenerRutaPdf(int numeroFactura)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string pdfName = $"Factura_{numeroFactura}.pdf";
            return Path.Combine(desktopPath, pdfName);
        }

        public bool ExistePdf(int numeroFactura)
        {
            string ruta = ObtenerRutaPdf(numeroFactura);
            return File.Exists(ruta);
        }

        public string ObtenerRutaCertificado()
        {
            return Path.Combine(@"C:\Users\kevin\OneDrive\Desktop\Certificados", "CertificadoPruebas.pfx");
        }

        public bool ExisteCertificado()
        {
            string ruta = ObtenerRutaCertificado();
            return File.Exists(ruta);
        }
    }
}
