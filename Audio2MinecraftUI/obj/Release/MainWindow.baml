   M S B A M L   `   `   `  ���� L  HAudio2MinecraftUI, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Audio2MinecraftUIAudio2MinecraftUI  I)clr-namespace:Audio2MinecraftUI.HumbergerAudio2MinecraftUI.Humberger  H DMahApps.Metro, Version=1.6.1.4, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls "    Audio2MinecraftUI.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:Audio2MinecraftUI     9ham)clr-namespace:Audio2MinecraftUI.Humberger     PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     -     � Title$  Audio 2 Minecraft��$	��480��$	��640��$	��480��$	��640��$��2q�   AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �    � 
ResizeMode$ CanMinimize=� � WindowStartupLocation$ CenterScreen=� � Icon$ /img/audio2minecraft.ico��.��� $��0,1,0,-1q�.+��� -    ��Name$ icon0��$
��Left=�$��32��$��64,8,0,0q�$	��Top=�$��32��.���� $��/img/midi.png��$
��Fill=�$��32��$��32�� J� RenderTransformOrigin$ 0.5,0.5&�$��0,0,-10,-10q�z�V� .~��� �� �� T�  T� X$ -6Q� T� Y$ -6Q��� -   	 ��Name$	 MidiPath��*  $MahApps.Metro.Controls.TextBoxHelper
   	Watermark$
 请选择Midi文件��$
��Left=�$��24��$��
128,12,0,0q�$	��Top=�$	��450��$�� ���� -   $ cancel0��$
��Left=�$��24��$��
584,13,0,0q�$	��Top=�$��24��.���� $��img/cancel.png��$
��Fill=�$��24��$��24��$ 0.5,0.5&�$��0,0,-10,-10q�z�V� .~��� �� �� T� $ -6Q�$ -6Q��� -   $ icon1��$
��Left=�$��32��$��	64,40,0,0q�$	��Top=�$��32��.���� $��/img/wave.png��$
��Fill=�$��32��$��32��$ 0.5,0.5&�$��0,0,-10,-10q�z�V� .~��� �� �� T� $ -6Q�$ -6Q��� -   $	 WavePath��$
 请选择Wav文件��$
��Left=�$��24��$��
128,44,0,0q�$	��Top=�$	��450��$�� ���� -   $ cancel1��$
��Left=�$��24��$��
584,44,0,0q�$	��Top=�$��24��.���� $��img/cancel.png��$
��Fill=�$��24��$��24��$ 0.5,0.5&�$��0,0,-10,-10q�z�V� .~��� �� �� T� $ -6Q�$ -6Q��� -   $ icon2��$
��Left=�$��32��$��	64,72,0,0q�$	��Top=�$��32��.���� $��img/lrc.png��$
��Fill=�$��32��$��32��$ 0.5,0.5&�$��0,0,-10,-10q�z�V� .~��� �� �� T� $ -6Q�$ -6Q��� -	   $	 LrcPath��$
 请选择歌词文件��$
��Left=�$��24��$��
128,76,0,0q�$	��Top=�$	��450��$�� ���� -
   $ cancel2��$
��Left=�$��24��$��
584,76,0,0q�$	��Top=�$��24��.���� $��img/cancel.png��$
��Fill=�$��24��$��24��$ 0.5,0.5&�$��0,0,-10,-10q�z�V� .~��� �� �� T� $ -6Q�$ -6Q��� -   $ A2MLoad��$
��Left=�$��24��$��	8,110,0,0q�$	��Top=�$��24��.���� $��img/load.png��$
��Fill=�$��24��$��24��$ 0.5,0.5&�$��0,0,-10,-10q�z�V� .~��� �� �� T� $ -6Q�$ -6Q��� -   $ A2MSave��$
��Left=�$��24��$��
34,110,0,0q�$	��Top=�$��24��.���� $��img/save.png��$
��Fill=�$��24��$��24��$ 0.5,0.5&�$��0,0,-10,-10q�z�V� .~��� �� �� T� $ -6Q�$ -6Q��� -   $
 load��$
��Left=�$��24��$��
60,110,0,0q�$	��Top=�$��24��.���� $��img/done.png��$
��Fill=�$��24��$��24��$ 0.5,0.5&�$��0,0,-10,-10q�z�V� .~��� �� �� T� $ -6Q�$ -6Q��� -   $ setting��$
��Left=�$��24��$��603,110,0,0q�$	��Top=�$��24��.���� $��img/setting.png��$
��Fill=�$��24��$��24��$ 0.5,0.5&�$��0,0,-10,-10q�z�V� .~��� �� �� T� $ -6Q�$ -6Q��� -    ��Name$ FileShow��$
��Left=�$��30��$��
89,110,0,0q�$	��Top=�$	��510��$�� ��� $
��Left=�$	��300��$��7.5,140,0,0q�$	��Top=�$	��620��.+��� $��1q�
��������� -   $ 
Midi设置��$��
Midi设置��$
��Left=�$��39,5,0,0q�$	��Top=�$��94��$��27���� -   $ 
Wave设置��$��
Wave设置��$
��Left=�$��	148,5,0,0q�$	��Top=�$��94��$��27���� -   $ 全局设置��$��全局设置��$
��Left=�$��	257,5,0,0q�$	��Top=�$��94��$��27���� -   $ 歌词设置��$��歌词设置��$
��Left=�$��	367,5,0,0q�$	��Top=�$��94��$��27���� -   $ 导出设置��$��导出设置��$
��Left=�$��	477,5,0,0q�$	��Top=�$��94��$��27��� $��0,37,0,0q�.+��� $��1q�
�������-   'Audio2MinecraftUI.Humberger.MidiSetting  -     Name$ MidiSetting��$
��0,10q�,   &Audio2MinecraftUI.Humberger.WavSetting  -     Name$ 
WavSetting��$
��0 10q�/   )Audio2MinecraftUI.Humberger.PublicSetting  -     Name$ PublicSetting��$
��0 10q�,   &Audio2MinecraftUI.Humberger.LrcSetting  -     Name$ 
LrcSetting��$
��0,10q�(   "Audio2MinecraftUI.Humberger.Export  -     Name$ Export��$
��0,10q�