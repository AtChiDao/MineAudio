   M S B A M L   `   `   `  ����L  HAudio2MinecraftUI, Version=1.1.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Audio2MinecraftUI.SubWindowAudio2MinecraftUI.SubWindow  5   	   H DMahApps.Metro, Version=1.6.1.4, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	   1    +Audio2MinecraftUI.SubWindow.ExtensionOption   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:Audio2MinecraftUI.SubWindow     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	     � Title$  扩展内容��5	   	    � Icon$ /img/audio2minecraft.ico��6   $	��100��66   $	��410��6C   $	��100��5
   	   $	��100��6   $	��405��6)   $	��410��68   $��2q�5   	    � 
ResizeMode$ CanMinimize=�5   	    � WindowStartupLocation$ CenterOwner=�5   	   .��5      � .+�5   
   �� -   5         ��Name$
 icon��5      $
��Left=�6   $��32��6:   $��	13,16,0,0q�6F   $	��Top=�6Y   $��32��6q   .��5      �� $��/img/extension.png��6   $
��Fill=�60   $��32��6?   $��32��6K    J� RenderTransformOrigin$ 0.5,0.5&�6V   $��0,0,-10,-10q�6v   z�5      V� 5      .~�5      �� �� 5      �� 5      T� 5       T� X$ -6Q�6-    T� Y$ -6Q�64   5       � ToolTip 5      _� 5      .��5      �� (&导入扩展内容(.amextension)文件5      5      5       5!      �� 5"   
   -   5        	 ��Name$
	 Path��5"      *  $MahApps.Metro.Controls.TextBoxHelper
   	Watermark$
 请选择Midi文件��6    $
��Left=�6M   $��24��6h   $��	50,20,0,0q�6t   $	��Top=�6�   $	��272��6�   $�� ��6�   6�   �� 5#   
   -   5        $ cancel��5#      $
��Left=�6!   $��24��6<   $��
327,21,0,0q�6H   $	��Top=�6\   $��24��6t   .��5$      �� $��/img/cancel.png��6   $
��Fill=�6-   $��24��6<   $��24��6H   $ 0.5,0.5&�6S   $��0,0,-10,-10q�6s   z�5%      V� 5&      .~�5'      �� �� 5(      �� 5)      T� 5*      $ -6Q�6-   $ -6Q�64   5+       5-      _� 5.      .��5/      �� 取消文件关联51      52      54      55      �� 56   
   -   5        $
 done��56      $
��Left=�6   $��
356,21,0,0q�6:   $	��Top=�6N   $��24��6f   $��24��6r   .��57      �� $��/img/done.png��6   $
��Fill=�6,   $��24��6;   $��24��6G   $ 0.5,0.5&�6R   $��0,0,-10,-14q�6r   z�58      V� 59      .~�5:      �� �� 5;      �� 5<      T� 5=      $ -5Q�6-   $ -7Q�64   5>       5@      _� 5A      .��5B      �� 确认导入5D      5E      5G      5H      5I      5J      