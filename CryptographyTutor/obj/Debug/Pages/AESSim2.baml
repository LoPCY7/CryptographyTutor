   M S B A M L   `   `   `  ����  CryptographyTutor%    CryptographyTutor.Pages.AESSim2   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Z VFirstFloor.ModernUI, Version=1.0.8.0, Culture=neutral, PublicKeyToken=bc9b0c37bf06c6a90mui&http://firstfloorsoftware.com/ModernUI  5      X TXceed.Wpf.Toolkit, Version=2.6.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5      .��5
      �    ContentRoot#��[  6   .+�5   
   �� $
��Auto=�6   .��5      �� $
��Left=�6   .+�5      �� $��AES Simulator��6     Heading1#��[ 61   $��0,0,0,8q�6S   �� 5      $	��200��6   .+�5      � $
��Left=�6   $	��300��66   $��0,0,0,8q�6B   .+�5      �� $��Select Function:��6$   $
��Left=�6<   � 5      $��Right=�6   $	��180��6;   .+�5      	� -   5          	�Name$  rbtnEncryption��5   *   $
��Left=�6B   $��
Encryption��6]   6r   	� 5      -   5        $  rbtnDecryption��5   *   $��Right=�6B   $��
Decryption��6^   6s   5      5      �� 5      -   5         ��Name$ txtProcessed��5      $��Encrypted Text...��64   $	��100��6M   $��0,0,0,8q�6Z   
������ $��2q�6�    �� 
IsReadOnly .  �� TextWrapping$
 Wrap=�6�   � 5      $
��Left=�6   $��0,0,0,8q�66   $	��350��6G   .+�5      �� $��
Input Key:��6$   $
��Left=�66   %  Xceed.Wpf.Toolkit.MaskedTextBox  5      -   5          Name$ txtKey��5   .    �� 
CaretIndex$ 0��6>   $��Right=�6M   $
 Wrap=�6i   $	��280��6}   5      (  "Xceed.Wpf.Toolkit.WatermarkTextBox  5      -   5          Name$ txtIV��5   ,      	Watermark$ Input IV��6;   $��0,0,0,8q�6P   {�.  $	��280��6s     5      -   5        $ txtInput��5   ,   $ 
Input Text��6>   $��0,0,0,8q�6U   $	��100��6f   $	��280��6s   � 5      $��Center=�6   $	��250��68   .+�5      �� $��0,0,0,8q�6%   $
��Left=�66   .+�5      �� $��Select mode:��6(   	� 5       -   5        $  rbtnECB��5    *   $	��ECB��6;    d� 	IsChecked$
 TrueY�6I   $��Right=�6Z   6v   	� 5!      -   5        $  rbtnCBC��5!   *   $	��CBC��6;   $��Right=�6I   6e   5"      �� 5#      $��0,0,0,8q�6%   $��Right=�66   .+�5$      �� $!��Select the size of the key:��6(   	� 5%      -	   5        $  rbtn128��5%   *   $	��128��6;   $
 TrueY�6I   $��Right=�6Z   6v   	� 5&      -
   5        $  rbtn192��5&   *   $	��192��6;   $��Right=�6I   6e   	� 5'      -   5        $  rbtn256��5'   *   $	��256��6;   $��Right=�6I   6e   5(      5)      � 5*      $
��Left=�6   $	��130��66   $��0,0,0,8q�6B   .+�5+      �� $��Explanation Mode��6$   $
��Left=�6<   �� 5,      -   5        	 ��Name$	 
chbExpMode��5,   #   $��Right=�67   5-      � 5/      $
��Left=�6   $	��130��66   $��0,0,0,16q�6B   .+�50      �� $��Export��6$   $
��Left=�62   �� 51      -   5        $	 	chbExport��51   #   $��Right=�66   52      �� 53      $��0,0,0,8q�6!   $��Center=�62   $��50��6O   $	��150��6[   .+�54      �� -   5        
 ��Name$
 
btnProcess��54   !   $��Encrypt��65   6G   55      56      57      58      59      5:      