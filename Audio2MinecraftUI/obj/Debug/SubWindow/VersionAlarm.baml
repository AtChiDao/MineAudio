   M S B A M L   `   `   `  ����L  HAudio2MinecraftUI, Version=1.1.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Audio2MinecraftUI.SubWindowAudio2MinecraftUI.SubWindow  5   	   H DMahApps.Metro, Version=1.6.1.4, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5	   	   .    (Audio2MinecraftUI.SubWindow.VersionAlarm   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:Audio2MinecraftUI.SubWindow     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5	   	   $	��200��5
   	   $	��300��6   $	��200��6(   $	��300��68     � Title$  检测到版本更新��5   	   $��2q�5   	      AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �   5   	    � 
ResizeMode$ CanMinimize=�5   	    � WindowStartupLocation$ CenterOwner=�5   	    � Icon$ /img/audio2minecraft.ico��5   	   .��5      � .+�5   
   �� -   5         ��Name$ new_version��5      $
��Left=�6)   $��	10,10,0,0q�6D   $
��Wrap=�6W   $��检测到最新版本��6k   $	��Top=�6z   �� 5   
   -   5        $ new_log��5      $
��Left=�6%   $��	10,29,0,0q�6@   $
��Wrap=�6S   $��更新记录��6g   $	��Top=�6s   �� 5   
   -   5         ��Name$ download��5      $
��Left=�6#   $��
253,10,0,0q�6>   $	��Top=�6R   $��24��6j   $��24��6v   .��5      �� $��/img/download.png��6   $
��Fill=�60   $��24��6?   $��24��6K    J� RenderTransformOrigin$ 0.5,0.5&�6V   $��0,0,-10,-14q�6v   z�5      V� 5      .~�5      �� �� 5      �� 5      T� 5       T� X$ -6Q�6-   	 T� Y$
	 -6.5Q�64   5      5       5!      �� 5"   
   -   5        
 ��Name$	
 log��5"      $
��Left=�6   $	��106��6:   $��	10,49,0,0q�6G    �� TextWrapping$
 Wrap=�6Z   $��TextBox��6n   $	��Top=�6}   $	��268��6�    �� 
IsReadOnly . 
�������$ �� HorizontalScrollBarVisibility$
 Auto=�6�   " �� VerticalScrollBarVisibility$ Visible=�6�   5#      5$      