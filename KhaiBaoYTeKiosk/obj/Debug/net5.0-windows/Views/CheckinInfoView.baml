   M S B A M L   `   `   `  ����J  FKhaiBaoYTeKiosk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:KhaiBaoYTeKiosk.ViewsKhaiBaoYTeKiosk.Views  5      Y1clr-namespace:KhaiBaoYTeKiosk.Resources.Converter#KhaiBaoYTeKiosk.Resources.Converter  5      +    %KhaiBaoYTeKiosk.Views.CheckinInfoView   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:KhaiBaoYTeKiosk.Views     5      G	converter1clr-namespace:KhaiBaoYTeKiosk.Resources.Converter     5         
CustomFont#��[  5	        � 	Resources  5
      @  :KhaiBaoYTeKiosk.Resources.Converter.StringToColorConverter  StringToColorConverter��%   &	         5   
   6+   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��1��6   $��60 60q�5       �� Padding$ 0 40 0 0q�5       �� CornerRadius$ 25��5      ��5      �� 5       �� Color$ #0E0885��6"    �� Opacity$	 0.8Q�62   ._�5      �  � ColumnDefinitions 5      �� 5      $	��400 �6'   �� 5      $��* �6'    5      �� 5       $��* �6$   �� 5!      $
��auto �6$   .+�5$      � $��0��6    5%      �� 5&      $��* �6+    5(      �� 5)      $
��auto �6(   �� 5*      $
��auto �6(   �� 5+      $��* �6(   .+�5.      �� $��0��6    $��0��6-   $��2��6=   $��24(�50       
�������$��Center=�52       ��5/       ��  �� Path$ HoTen� �� Mode$ OneTime=�52       �� 53      $��1��6   $��0��6*   
�������$��Center=�55      $	��150��56      $	��150��6(   ._�57      �� ��6    �� $ QRImage�$ OneTime=�	 �� TargetNullValue	 Z� 58      �� 59      $��1��6   $��1��6)   $)��#/Resources/Images/ico_RedShield.png��5:      $��50��5;      $��Right=�5<      $��Bottom=�5=      $��0 0 60 0q�5>      5?      � 5@      $��1��6   $��0��6'   ��5A      �� 5B      .�5C      �� 
 �� Property
 � �� �� Value$ 21(�5D   %   �� 5E      
 � ��
 �����5F   %    �� 	Resources 5G       �� 
TargetType��%�   '��       �� 5H   "   " ��6(   .�5I   &   �� 
 � ��$	 0 5q�5J   -   �� 5K   &   
 � ��$
 Wrap=�5L   -   5M   #   5N      5O       5Q      �� 5R      $
��auto �6+   �� 5S      $��* �6+   $	��650��65    5U      �� 5V      $
��auto �6(   �� 5W      $
��auto �6(   �� 5X      $
��auto �6(   �� 5Y      $
��auto �6(   �� 5Z      $
��auto �6(   �� 5[      $
��auto �6(   �� 5\      $
��auto �6(   �� 5]      $
��auto �6(   �� 5^      $
��auto �6(   �� 5_      $
��auto �6(   �� 5`      $
��auto �6(   �� 5a      $
��auto �6(   .+�5d      �� $��0��6    $��0��6-   $��Ngày khai báo:��6=   �� 5e      $��0��6    $��1��6-   $��20 5 0 5q�6m   ��6=   �� $ NgayKhaiBao�$ OneTime=�6m   �� 5f      $��1��6    $��0��6-   $��Nơi khai báo:��6=   �� 5g      $��1��6    $��1��6-   $��20 5 0 5q�6l   ��6=   �� $ 
NoiKhaiBao�$ OneTime=�6l   �� 5h      $��2��6    $��0��6-   $��Loại khai báo:��6=   �� 5i      $��2��6    $��1��6-   $��20 5 0 5q�6m   ��6=   �� $ LoaiKhaiBao�$ OneTime=�6m   �� 5j      $��3��6    $��0��6-   $��
Năm sinh:��6=   �� 5k      $��3��6    $��1��6-   $��20 5 0 5q�6i   ��6=   �� $ NamSinh�$ OneTime=�6i   �� 5l      $��4��6    $��0��6-   $��Giới tính:��6=   �� 5m      $��4��6    $��1��6-   $��20 5 0 5q�6j   ��6=   �� $ GioiTinh�$ OneTime=�6j   �� 5n      $��5��6    $��0��6-   $��Địa chỉ:��6=   �� 5o      $��5��6    $��1��6-   $��20 5 0 5q�6h   $
��Wrap=�6z   ��6=   �� $ DiaChi�$ OneTime=�6z   �� 5p      $��6��6    $��0��6-   $��Số điện thoại: ��6=   �� 5q      $��6��6    $��1��6-   $��20 5 0 5q�6m   ��6=   �� $ SoDienThoai�$ OneTime=�6m   �� 5r      $��7��6    $��0��6-   $��Dấu hiệu:��6=   �� 5s      -   5        $��DauHieu��5s   =   $��7��6    $��1��6-   $��20 5 0 5q�5u       $
��Wrap=�5w       ��5t       �� $ DanhSachTrieuChung�$ OneTime=���5v       �� $ DanhSachTrieuChung�$ OneTime=� �� 	Converter# [ 5w       �� 5x      $��8��6    $��0��6-   $��Yếu tố dịch tễ:��6=   �� 5y      $��8��6#   $��1��60   $	��160��6@    �� PanningMode$ VerticalOnly=�5z   #   $
��Auto=�5{   #   .��5|      �� $��19(�6$   $��20 5 0 5q�5~       $
��Wrap=�5�       ��5}       �� $ DanhSachDichTe�$ OneTime=���5       �� $ DanhSachDichTe�$ OneTime=�# [ 5�       5�      �� 5�      $��9��6    $��0��6-   $��2��6=   $#��Khai báo y tế thành công��5�       
��� �|�5�       �� 5�      $��10��6    $��0��6.   $��2��6>   $p��jTuyệt đối tuân thủ 5K và các khuyến cáo của bộ y tế về phòng chống dịch Covid 19��5�       
��� ���$��WrapWithOverflow=�5�       �� 5�       �� Orientation$ 
Horizontal=�6!   $��	0 0 0 100q�6:   $��11��5�   !   $��0��6/   $��2��6?   .+�5�      �� $��0 0 5 0q�6!   
���  ��$	��300��5�   !   $��70��6-   $
��Left=�5�   !   $��24(�5�   !   $��DemiBold"�5�   !   $��TIẾP TỤC��5�   !   �� 5�      $	��300��6!   $��70��6-   $
��Left=�5�   !   $��24(�5�   !   $��DemiBold"�5�   !   $��TIẾP TỤC��5�   !   $��QR��5�   !   ��5�   !   �� *updateViewCommand+5�   !   5�      5�      5�      5�      5�      5�      