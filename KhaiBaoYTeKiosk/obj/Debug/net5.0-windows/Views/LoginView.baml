   M S B A M L   `   `   `  ����J  FKhaiBaoYTeKiosk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:KhaiBaoYTeKiosk.ViewsKhaiBaoYTeKiosk.Views  5      a5clr-namespace:KhaiBaoYTeKiosk.Resources.CustomElement'KhaiBaoYTeKiosk.Resources.CustomElement  5      %    KhaiBaoYTeKiosk.Views.LoginView   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:KhaiBaoYTeKiosk.Views     5      Hcustom5clr-namespace:KhaiBaoYTeKiosk.Resources.CustomElement     5         
CustomFont#��[  5	      .��5
      �   � ColumnDefinitions  5   
   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   � $��1��6   $��1��6   $��2��6,   $
��0 20q�6A    5      �� 5      $��50 �6    �� 5      $
��auto �6    .+�5      ��  �� CornerRadius$ 25��6   $��1��6(   ��5      �� 5       �� Color$ #2b1e94��6&    �� Opacity$	 0.8Q�66    J� Effect 5!      3  -System.Windows.Media.Effects.DropShadowEffect  5"         ShadowDepth$ 1Q�6'   ._�5%      �� $
��90 0q�6   .+�5&      �� $��SemiBold"�6    $��26(�66   
�������$��	0 110 0 5q�6W    � Cursor$ AppStarting��6j   $��Center=�6   ��5'      �� 5(       j� Stretch$
 None=�6)    SỞ Y TẾ TP. HỒ CHÍ MINH5+      �� 5,      $��26(�6!   
�������$��	0 10 0 25q�6B   $��Center=�6U   42KHAI BÁO Y TẾ ĐIỆN TỬ TẠI BỆNH VIỆN"5.      �� 5/      $��0 0 0 20q�6   	 �� Padding$
	 0 10q�6/   $ 15��6>   
�������._�50      ]� .+�51      �� $��30��6$   $
��15 5q�6/   $%��/Resources/Images/logo_user.png��6=   $��Uniform=�6f   
 �� StretchDirection$

 Both=�6x   @   :KhaiBaoYTeKiosk.Resources.CustomElement.PlaceholderTextBox  52         PlaceholderText$ Nhập tài khoản��53   8   $��Center=�54   8      Text 52   8   ��  �� Path$ Username� �� Mode$ TwoWay=�54   8   55      56      �� 57      $��0 0 0 50q�6   $
	 0 10q�60   $ 15��6?   
�������._�58      ]� .+�59      �� $��30��6$   $
��Left=�6/   $
��15 5q�6E   $)��#/Resources/Images/logo_password.png��6S   D   >KhaiBaoYTeKiosk.Resources.CustomElement.PlaceholderPasswordBox  5:      $��Center=�5;   <      PlaceholderText$ Nhập mật khẩu��5<   <      Password 5:   <   �� $ Password�$ TwoWay=�5<   <   5=      5>      �� 5?      -   5        $��SignInButton��5?      $��60 20q�61   $��0 0 0 40q�6A   ���#ff3d43$��26(�5@   2   
�������$
��Bold"�6S   $��ĐĂNG NHẬP��5A      ��61   �� $ LoginCommand�$ OneWay=�5B      5C      �� 5D      $)��#/Resources/images/Logo_SoYTeHCM.png��6   $��0��6A   $��2��6N   $	��150��6`   $	��Top=�6m   $��0,0,0,0q�6�   5E      �� 5G   
   -   5         ��Name$ ErrorMessageModal��5G      $��0��5H      $��3��6   $��0��5I      $��4��6!   y�5G   ,   �� $ 
ErrorModal�$ TwoWay=�._�5K      �   5L      �� 5M      $��* �6'   �� 5N      $	��700 �6'   �� 5O      $��* �6'    5Q      �� 5R      $��* �6$   �� 5S      $
��auto �6$   �� 5T      $��* �6$   .+�5W      �� $��1��6   $��1��6&   
�������$ 25��5X   ,   $��Stretch=�5Y      ._�5Z      �� $��Center=�6!   $��50 50q�5[   !   .+�5\      �� $	��150��5]       ��5\       �� $ 
ErrorImage�$ OneWay=�5]       �� 5^      $��46(�6$   
��� E��$��DemiBold"�5_   $    �� TextAlignment$ Center=�5`   $   $��0 10 0 0q�6;   ��5_   :   �� $ 
ErrorTitle�$ OneWay=�5`   ;   �� 5a      $��28(�6$   ���#6E6E6E$��DemiBold"�6G   $ Center=�5b   $   $	��0 5q�5c   $   ��61   �� $ ErrorNessage�$ OneWay=��� 5d      -   5        $��ErrorAgree_Btn��5d   L   $��
Đồng Ý��6!   $��21(�62   $��60 20q�5e   !   $
��0 10q�61   $��Center=�5f   !   5g      5h      5i      5j      5k      5l      