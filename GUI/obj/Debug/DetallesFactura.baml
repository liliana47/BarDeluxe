   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5   	       GUI.DetallesFactura   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:GUI     5   	     � Title$  DetallesFactura��5   	   $	��650��6!   $	��800��6.    � WindowStartupLocation$ CenterScreen=�6:   .��5	      � $��20q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��Detalle de Factura��6   $��20(�6.   $
��Bold"�6<   $��0,0,0,20q�6N   �� 5   
   $��0��6    �� Orientation$ Vertical=�6"   $��	0,40,0,10q�69   .+�5      �� $��N° Factura:��6   $
��Bold"�6+   �� 5      $��0,0,0,10q�6,   ��6   �� *Id+6,   �� 5      $��Cliente:��6   $
��Bold"�6(   �� 5      $��0,0,0,10q�68   
���   ���6   �� *Cliente.Nombre+6J   �� 5      $��Cédula Cliente:��6   $
��Bold"�6/   �� 5      $��0,0,0,10q�68   ��6   �� *Cliente.Cedula+68   �� 5      $��Total:��6   $
��Bold"�6&   �� 5      $��0,0,0,10q�6?   ��6   �� *Total+ �� StringFormat$ C��6?   5      &   System.Windows.Controls.DataGrid  5   
   $��1��6      AutoGenerateColumns .     CanUserAddRows .     HeadersVisibility$ Column=�6u   $��0,20,0,0q�6�   ��6    �� *	Productos+   Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Código Producto��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 120 6U   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� *Id+6U     5"      $	 Nombre Producto��6%   $	
 200 6Y    6>   �� *Nombre+6Y     5#      $	 Cantidad��6%   $
 80 6T    67   �� *
Cantidad+6T     5$      $	 Precio Unitario��6%   $	
 100 6q    6>   �� *PrecioUnitario+$ C��6q     5%      $	 Total��6%   $	
 100 6^    64   �� *Total+$ C��6^   5'      5(      5)      