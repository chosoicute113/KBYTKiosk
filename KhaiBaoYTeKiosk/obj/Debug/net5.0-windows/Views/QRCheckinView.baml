   M S B A M L   `   `   `  ����J  FKhaiBaoYTeKiosk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:KhaiBaoYTeKiosk.ViewsKhaiBaoYTeKiosk.Views  5      a5clr-namespace:KhaiBaoYTeKiosk.Resources.CustomElement'KhaiBaoYTeKiosk.Resources.CustomElement  5      )    #KhaiBaoYTeKiosk.Views.QRCheckinView   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:KhaiBaoYTeKiosk.Views     5      Hcustom5clr-namespace:KhaiBaoYTeKiosk.Resources.CustomElement     5      -   5          >�Name$  keyboard��5         
CustomFont#��[  5	      .��5
      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   � $��1��6   $��1��6   $
��1080��6,    J� OpacityMask 5      !� 5       !� Visual 6   ��  �� ElementName$ Border1��.+�5      �� -   5         ��Name$ Border1��5       �� CornerRadius$ 15��6&   
�������68   �� 5      .+�5      � ���#2e3192 5      �� 5      $��* �6+   �� 5      $
��auto �6+   .+�5"      �� $��0��6    $��2��60   $��Center=�6D   $��Center=�6a   $��26(�5#   !   $
��Bold"�6/   
�������	CHECKIN5%      �� 5&      $��1��6   $��20 20q�6.   
������ ��5'      �� 5(       �� 
TargetType" ��6$   .�5)   "   �� 	 �� Property	 � ��
 �� Value
 5*   &   �� 5+   *   .R�5,   .   �� .��5-   2   � .+�5.   6   A�  A�Name$ CloseButton��6>   $��34��6S   $��34��6^   ���#007dd16j   �� 5/   6   $��15��6<   $��15��6G    J� Opacity$	 0.4Q�6S   $'��!/Resources/Images/ico_letterX.png��6a   $��Right=�6�   $��
0,10,10,10q�6�   50   3   51   /    �� Triggers 52   .   P� 53   2    P� Property �@J�IsMouseOver P� Value$
 True��6Q   . �54   6   ��  �� 
TargetName$ CloseButton��6=   	 � ��

 �  ��6f   55   3   57   +   59   #   5:      5<      5=      �� 5>      
�������.+�5?      �� $
��0 10q�6   $	��240��6*   $$��/Resources/Images/img_scan.png��67   �� 5@      $
��0 10q�6    $��Center=�6.   $��24(�5A       ���#007dd197Vui lòng quét QR Code vào máy đọc để check in5C      �� 5D      $	��600��6   $��	0 30 0 10q�6)   
�������$	 0.6Q�5E   0   $��1q�6>   $ 5��6R   ._�5F      G   AKhaiBaoYTeKiosk.Resources.CustomElement.PlaceholderScannerTextBox  -   5          Name$ 
ScannerBox��5J   5      PlaceholderText$" QUÉT QR CODE ĐÃ KHAI BÁO��5F   <   $	��5 8q�5G   5   $��Center=�6B   $	��560��5H   5   $��Center=�6A      Text 5I   5   ��  �� Path$ ScannedCode� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5J   5   5K      �� 5L      $	��0 5q�6!    �� Orientation$ 
Horizontal=�6.   $��Center=�6G   $y�	Collapsed=�6d   .+�5M      �� $��24(�6$   ���#007dd1$��Center=�6H   64Cài đặt địa điểm check in thì nhấn vào5O      �� 5P      ���#ff3d43$
��10 0q�66   $	��5 5q�6D   $��
Vào đây��5Q   !   
�������$��20(�6F    � 	Resources 5R      ��%^   '��       �� 5S   "   " ��6(   .�5T   &   �� 	 �@��CornerRadius$
 5��6E   5U   #   5V      5W      5X      �� 5Y      $��Center=�6    $y�	Collapsed=�6=   $��14(�5Z       $��DemiBold"�6.   ���	#FF7FBC21[Địa điểm]5\      �� 5]      $��Center=�5^       
���  ��$��16(�5`       $��0 0 0 60q�5a       ��5]       �� $ ErrorMessage�$ OneWay=�5a       5c      5e      5f      5g      5h      