   M S B A M L   `   `   `  ����O  KWpfLeagueOfLegendsUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:WpfLeagueOfLegendsUIWpfLeagueOfLegendsUI  5   	   %    WpfLeagueOfLegendsUI.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:WpfLeagueOfLegendsUI     5   	     � Title$  
MainWindow��5   	   $	��830��6   $
��1500��6)   $��Poppins)�66    � WindowStartupLocation$ CenterScreen=�6K    � 
ResizeMode$ NoResize=�6p   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��2* �6   �� 5      $��5* �6   .+�5   
   � $��0��6   
������� � RowDefinitions 5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    .+�5      �� $��0��6   $��/Resources/RiotLogo.png��6!   $	��100��6B   $��0,90,0,0q�6N   � 5      $��1��6    5      �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   .+�5      �� $��0��6   $��
Giriş yap��6%   $��SemiBold"�69   $
��25px(�6O   $��Center=�6_   $��0,70,0,0q�6|   �� 5      $��1��6   $��KULLANICI ADI��6)   $
��12px(�6>   $��Light"�6N   $��Stretch=�6a   $��50��6   $��
90,30,90,0q�6�    �� Padding$ 	10,15,0,0q�6�   
�������
�������6�   �� 5       $��2��6   $��ŞİFRE��6)   $
��12px(�66   $��Light"�6F   $��Stretch=�6Y   $��50��6w   $��
90,10,90,0q�6�   $ 	10,15,0,0q�6�   
�������
�������6�   � 5!      $��3��6   $��Stretch=�6$   $��
60,20,60,0q�6B    5"      �� 5#      $
��auto �6+   �� 5$      $
��auto �6+   �� 5%      $
��auto �6+   �� 5&      $
��auto �6+   .+�5(      �� $��0��6   $��0,0,0,0q�6,   $��/Resources/Facebook.png��6=   �� 5)      $��1��6   $��10,0,0,0q�6,   $��/Resources/Google.png��6>   �� 5*      $��2��6   $��10,0,0,0q�6,   $��/Resources/İos.png��6>   �� 5+      $��3��6   $��10,0,0,0q�6,   $��/Resources/Xbox.png��6>   5,      � 5-      $��4��6   $��Center=�6$   $��
0,15,180,0q�6A    5.      �� 5/      $
��auto �6+   �� 50      $
��auto �6+   .+�52      �� $��0��6   $��Center=�6/   $��Center=�6L   �� 53      $��1��6   $��Oturumu açık tut��6,   54      55      �� 56      $��2��6   $��	0,100,0,0q�6&   $��Center=�69   .+�57      �� 
�������$��80��61   $��80��6<    �� CornerRadius$ 30��6H   ._�58      �� $��>��6   $
��41px(�6(   
�������$��Center=�6J   $��Center=�6g   59      �� 5:      $��Center=�6   $��0,45,0,0q�65   $��GİRİŞ YAPAMIYOR MUSUN?��6G   $
��11px(�6h   ���	#FF5656566x   �� 5;      $��Center=�6   $��HESAP OLUŞTUR��65   $
��11px(�6M   ���	#FF5656566]   �� 5<      $��Center=�6   $��	40,0,40,0q�65   $
��10px(�6H   
�������.��5=      �� $k��eBU UYGULAMA HCAPTCHA İLE KORUNUR VE ONUN GİZLİLİK POLİTİKASI VE HİZMET ŞARTLARI GEÇERLİDİR��6    $
��Wrap=�5>      $��Center=�6)   $��Center=�6F    �� TextAlignment$ Center=�6a   5?      5@      5A      �� 5B   
   $��1��6   $��/Resources/Login.png��6    $��Stretch=�6>   $��UniformToFill=�6\   5C      5D      