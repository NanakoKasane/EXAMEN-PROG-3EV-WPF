   M S B A M L   `   `   `  ����  ESPINOSA_MARINA    ESPINOSA_MARINA.Propinas   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Calculador de propinas��5   	   $	��300��6(   $��433.569��65   $	��400��6E   $	��600��6U   $	��300��5   	   $��433.569��6    � 	Resources 5       �� 
TargetType �� Property �� Value��%T   '	�       �� 5   
   " 	�6   .�5	      ��  � ��
 ��  �6+   5
      5      .��5      � .+�5   
   �� .+�5      �� $��20q�6   $��17(�6$   $
��Bold"�62   $��Por si viajas...��6D   ��5      �� 5       �� EndPoint$ 0.5,1&�6*    �� 
StartPoint$ 0.5,0&�6;   .��5      �  � Color$ 	#FF132DA2��6'    � Offset$ 0Q�69   � 5      $ 	#FF83EEF3��6'   $ 1Q�69   5      5   *   �� 5      	 �� Orientation$	 
Horizontal=�6   .+�5      �� $	��130��6   $��Importe de la factura: ��6(   $
��Left=�6G   $��20,0,0,0q�6b   6v   �� 5      -   5        $��tbx_ImporteFactura��5   `   $��0��6   
 � ToolTip$8
 2Importe de la factura. Usa coma para los decimales��6#    �� TextAlignment$ Right=�6z   $	��100��6�   6�   �� 5      $��2q�6   €6*   5      � 5      .+�5      �� ���	#FFCB1010$��63,30,71,30q�6-   $��80��6B    �� RadiusX$ 15��6N    �� RadiusY$ 15��6[   �� 5!      $��15(�6   $"��Satisfacción del servicio: ��6*   $��76,34,91,84q�6M   6d   	� 5"      -   5        $��	rbt_bueno��5"   N    d� 	IsChecked$
 TrueY�6=   $��76,56,236,68q�6_   .��6u   Bueno (10%)6�   	� 5#      -   5        $��rbt_muybueno��5#      $��76,72,236,52q�62   $��Muy Bueno (15%)��6H   6b   	� 5$      -   5        $��rbtExcelente��5$   =   $��76,88,236,36q�6Q   $��Excelente (20%)��6g   5%      �� 5(      $	 
Horizontal=�6   .+�5)      �� $	��130��6   $
��Bold"�6)   $��Italic$�6;   $
��Left=�6N   $��20,0,0,0q�6i   $��Importe de la propina:��6{   6�   �� 5*      -   5        $��tbl_ImportePropina��5*       �� TextAlignment$ Right=�66   $��60��6M   6Z   �� 5+      €6   5,      �� 5.      $	 
Horizontal=�6   .+�5/      �� $��13(�6   $
��Bold"�6*   $��Italic$�6<   $	��142��6O   $
��Left=�6[   $��20,0,0,0q�6v   $��Importe Total a pagar:��6�   6�   �� 50      -   5        $��tbl_ImporteTotal��50   2   $ Right=�6   $��47��6J   6W   �� 51      €6   52      54      56      57      