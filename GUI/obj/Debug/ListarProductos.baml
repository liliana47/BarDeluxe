   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5   	       GUI.ListarProductos   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:GUI     5   	     � Title$  ListarProductos��5   	   $	��450��6!   $	��800��6.    � WindowStartupLocation$ CenterScreen=�6:   .��5	      � ���#f8f6c6.+�5
   
   �� $��Lista de productos��6   $��20(�6-   $
��Bold"�6;   $
��Left=�6M   $��5,20,0,0q�6h      PrimaryPurpleText#���   6z   ���#f8f6c66�   �� 5   
   -   5         ��Name$ txtBuscarProducto��5      $	��Top=�6M   $��	0,25,40,0q�6e   $��Right=�6x   $��16(�5      $��Normal"�5      $��
Montserrat)�5        
BlackColor#���  5       �� 
CaretBrush �#f8f6c6���#f8f6c6#���   5      $��0,0,0,2q�5      $��25��5      $	��150��5      .��6   5      �� 5   
   $��ID��6   $��15(�6   $
��Bold"�6+   $��	5 60 0 12q�6=   #���  6P   �� 5   
   $��Nombre��6   $��15(�6!   $
��Bold"�6/   $��110 60 0 12q�6A   #���  6V   �� 5   
   $��Descripcion��6   $��15(�6&   $
��Bold"�64   $��225 60 0 12q�6F   #���  6[   �� 5   
   $��Cantidad��6   $��15(�6#   $
��Bold"�61   $��565 60 0 12q�6C   #���  6X   �� 5   
   $��Precio Unitario��6   $��15(�6*   $
��Bold"�68   $��655 60 0 12q�6J   #���  6_   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ ProductosDataGrid��5         
IsReadOnly . $��0q�6v      AutoGenerateColumns .     CanUserReorderColumns .     CanUserAddRows .  ���#f8f6c6	   RowBackground	 �#f8f6c6
   GridLinesVisibility$

 None=�6     SelectionMode$ Single=�6#     HeadersVisibility$
 None=�6:  $��	5,104,0,0q�6S   � 	Resources 5      *  $System.Windows.Controls.DataGridCell �� 
TargetType �� Property �� Value  TertiaryBackgroundColor �� 
TargetType �� Padding �� CornerRadius �� Triggers P� Property P� Value:  4System.Windows.Controls.Primitives.DataGridRowHeader=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%�  '        '      '  �    �� 5       "  6   .�5!      ��  � ��$ 0q�68   �� 5"       � ��$ 10q�60   �� 5#       � ��$ 0 8 0 0q�6/   �� 5$       � ��# �  63   �� 5%       � �� 5&      �� 5'      "  6.   .R�5(   "   �� #��z��6)   # z��5)      $��0q�5*      $ 10��5+      $��	0 0 -20 0q�5,      ._�5-   &   �� 5.   #    5/   "   P� 50   &    �@ 
IsSelected . . �51   *   �� # �  6G    � ���� 52   *   # � ��6G    � ��53   '   55      57      58      �� 5:      "  6   .�5;      ��  � ��# �  63   �� 5<       � �� 5=      �� 5>      "  6.   .R�5?   "   �� #��z��6)   $ 3q�6S   ._�5@   &   �� $��Center=�67   5A   #   5B      5D      5E      �� 5G      "  6   .�5H      ��  � ��# �  63   �� 5I       � ��# �   63   �� 5J       � ��$ 0q�68   �� 5K       � ��$
 Bold"�63   �� 5L       � ��$ 5q�60   5M      5N         Columns 5P      0  *System.Windows.Controls.DataGridTextColumn  5Q      ,  &System.Windows.Controls.DataGridColumn   Header$ Cedula��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *Id+   ElementStyle 5R      �� 5S      " ��6    .�5T      ��  � ��# �  6;   �� 5U       � ��# �   6;   �� 5V       � ��$ SemiBold"�6;   �� 5W       � ��$ Center=�6B   5X      5Z        5[      $ Nombre��6%   $	 115 6P    65   �� *Nombre+ 5\      �� 5]      " ��6    .�5^      ��  � ��# �  6;   �� 5_       � ��# �   6;   �� 5`       � ��$ SemiBold"�6;   �� 5a       � ��$ Center=�6B   5b      5d        5e      $ THabitacion��6%   $	 340 6Z    6:   �� *Descripcion+ 5f      �� 5g      " ��6    .�5h      ��  � ��# �  6;   �� 5i       � ��$ SemiBold"�6;   �� 5j       � ��# �   6;   �� 5k       � ��$ Center=�6B   5l      5n        5o      $ Apellido��6%   $	 120 6T    67   �� *
Cantidad+ 5p      �� 5q      " ��6    .�5r      ��  � ��# �  6;   �� 5s       � ��$ SemiBold"�6;   �� 5t       � ��# �   6;   �� 5u       � ��$ Center=�6B   5v      5x        5y      $ Noches��6%   $ 80 6h    65   �� *PrecioUnitario+ �� StringFormat$ C�� 5z      �� 5{      " ��6    .�5|      ��  � ��# �  6;   �� 5}       � ��$ SemiBold"�6;   �� 5~       � ��# �   6;   �� 5       � ��$ Center=�6B   5�      5�      5�      5�      5�      