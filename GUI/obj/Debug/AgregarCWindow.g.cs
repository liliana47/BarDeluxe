﻿#pragma checksum "..\..\AgregarCWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "07C5EE96257712B1753C509975FC8E09978B049A926999E9D3AF9E1FF4955423"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using GUI;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace GUI {
    
    
    /// <summary>
    /// AgregarCWindow
    /// </summary>
    public partial class AgregarCWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\AgregarCWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridClientes;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\AgregarCWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCedula;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\AgregarCWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ErrorCedula;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\AgregarCWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombre;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\AgregarCWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtApellido;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\AgregarCWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTelefono;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\AgregarCWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ErrorTelefono;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\AgregarCWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDireccion;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\AgregarCWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCorreo;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\AgregarCWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRegistrar;
        
        #line default
        #line hidden
        
        
        #line 205 "..\..\AgregarCWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 232 "..\..\AgregarCWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMinimize;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GUI;component/agregarcwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AgregarCWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.gridClientes = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.txtCedula = ((System.Windows.Controls.TextBox)(target));
            
            #line 45 "..\..\AgregarCWindow.xaml"
            this.txtCedula.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.InputTextBoxCedula_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ErrorCedula = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.txtNombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtApellido = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtTelefono = ((System.Windows.Controls.TextBox)(target));
            
            #line 116 "..\..\AgregarCWindow.xaml"
            this.txtTelefono.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.InputTextBoxTelefono_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ErrorTelefono = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.txtDireccion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.txtCorreo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.btnRegistrar = ((System.Windows.Controls.Button)(target));
            
            #line 166 "..\..\AgregarCWindow.xaml"
            this.btnRegistrar.Click += new System.Windows.RoutedEventHandler(this.RegistrarCliente_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 205 "..\..\AgregarCWindow.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.btnMinimize = ((System.Windows.Controls.Button)(target));
            
            #line 232 "..\..\AgregarCWindow.xaml"
            this.btnMinimize.Click += new System.Windows.RoutedEventHandler(this.btnMinimize_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

