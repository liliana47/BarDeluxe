   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5   	       GUI.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:GUI     5   	     � Title$  
MainWindow��5   	   $	��760��6   $
��1400��6)    � WindowState$ 	Maximized=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	   ���#f8f6c6.��5      �� ._�5   
   � .+�5      ��  �� CornerRadius$ 8��6    �� Padding$ 5q�5      $��60��5      $��
10,10,10,0q�5      $	��Top=�5      ���#cba8cd._�5      � -   5         �Name$ gridMenu��5      .+�5      �� $��0��6!    �� Orientation$ 
Horizontal=�6.   .+�5      �� $��
Deluxe Bar��6    
���� ��$
��Bold"�6I   $��25(�6[   $��40��6i   $	��Top=�6u   $��	10,0,30,0q�6�   	� 5      -   5        	 	�Name$	 rdEstadisticas��5   &   $��Estadisticas��6>    %  !MenuRadioButtonStyleREstadisticas#���   6U   
 � Cursor$

 Hand��6�   $��36��6�   	� 5      -   5        $	 rdProductos��5   &   $��	Productos��6;    " MenuRadioButtonStyleRProductos#���  6O   $

 Hand��6�   $��36��6�   	� 5      -   5        $	 rdMovimientos��5   &   $��Movimientos��6=    $  MenuRadioButtonStyleRMovimientos#���  6S   $

 Hand��6�   $��36��6�   	� 5      -   5        $	 rdVentas��5   &   $��Facturar��68     MenuRadioButtonStyleRVentas#���  6K   $

 Hand��6�   $��36��6�   	� 5       -   5        $	 
rdClientes��5    &   $��Clientes��6:    ! MenuRadioButtonStyleRClientes#���  6M   $

 Hand��6�   $��36��6�   5"      �� 5$      $��1��6!   $��Center=�6.   5%      5&      � 5(      $��1��6    � RowDefinitions 5)      �� 5*      $��35 �6$   �� 5+      .+�5.      �� $��0��6   $��4��6*   $��Right=�6:   $	��Top=�6V   $��0,5,10,0q�6n   $��30��6�   $ 
Horizontal=�6�   $��RightToLeft=�6�   �� 50      $��1��6   $ 0 0 5 0��6&   
������ $��10,53,10,10q�6V   ._�51       � -   5          �Name$ frameContent��51        � NavigationUIVisibility$ Hidden=�62   $��20q�6R   $��Center=�6^   $��Center=�6y   52      �� 53      -   5         ��Name$ btnMinimize��53      $��-��6.   $

 Hand��6T   $��15(�6b   $��SemiBold"�6p   $��1278,10,2,720q�6�   $��2��6�   ��54      �� 55       �� 
TargetType" ��6    .�56      ��  �� Property � ��  PrimaryColor �� Value# �  6;   �� 57       � ��  PrimaryBlueText# �  6;    �� Triggers 58      P� 59   "    P� Property �@J�IsMouseOver P� Value . . �5:   &   ��  � ��  PrimaryBackgroundColor# �  6C   �� 5;   &    � ��# �  6C   �� 5<   &    � ��$
 Bold"�6C   5=   #   5?      ��5B      �� 5C       �� 
TargetType" ��6*   .R�5D      �� $��20��6%   $��20��60   $ 5��5E   !   #��z��5F   !   ._�5G   "   �� $��Center=�63   $��Center=�5H   /   5I      5J      5L      �� 5M      -	   5        $ btnClose��5M      $��X��6+   $

 Hand��6N   $��SemiBold"�6\   $��1301,10,-21,720q�6r   $��2��6�   ��5N      �� 5O      " ��6    .�5P      ��  � ��# �  6;   �� 5Q       � ��# �  6;    5R      P� 5S   "    �@J�IsMouseOver . . �5T   &   ��  � ��  PrimaryRedColor# �  6C   �� 5U   &    � ��# �  6C   �� 5V   &    � ��$
 Bold"�6C   5W   #   5Y      ��5\      �� 5]      " ��6*   .R�5^      �� $��20��6%   $��20��60   $ 5��5_   !   #��z��5`   !   ._�5a   "   �� $��Center=�63   $��Center=�5b   /   5c      5d      5f      � 5h      .+�5i       � -
   5        $ 	MainFrame��5i      5j      5l      5m      5n      5o      