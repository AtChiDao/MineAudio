   M S B A M L   `   `   `  ���� L  HAudio2MinecraftUI, Version=1.1.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Audio2MinecraftUI.HumbergerAudio2MinecraftUI.Humberger  H DMahApps.Metro, Version=1.6.1.4, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls -    'Audio2MinecraftUI.Humberger.MidiSetting   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ;local)clr-namespace:Audio2MinecraftUI.Humberger     PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     -   $	��250��$	��620��$	��250��$	��620��  � 	Resources  /   )Audio2MinecraftUI.Humberger.SlidConverter   SlidConverter��%   &	          .��� $
��Left=�$	��250��$��6,2,0,0q�$	��Top=�$	��600��.+��� $
��Auto=�$��10,0,385,10q�.��R� -    R�Name$ 
TracksView��$	��228��$	��202�� � DataContext �� ���� *Instruments+����  �� DataType-   'Audio2MinecraftUI.Humberger.MidiSetting"   �� ItemsSource �� *Instruments+.R���  �� Orientation$ 
Horizontal=�.+��� -    d� 	IsChecked �� *Enable+.���� ���� *Name+� $��
220,0,0,10q�.+��� -    ��Name$ SelectedName��$
��12px(�$��0,10,83,211q�$��Center=��� -   $
��Left=�$��	347,1,0,0q�$	��Top=�$��32��$��32��.���� -    ��Name$ SwitcherViewType��$��/img/track_view.png��$
��Fill=�$��32��$��32��	 J� RenderTransformOrigin$	 0.5,0.5&�$��0,0,-10,-10q�z�V� .~��� �� �� T� 
 T� X$
 -5Q� T� Y$ -7Q��� -    ��Name$
 Done��$
��Left=�$��	319,6,0,0q�$	��Top=�$��24��$��24��.���� $��/img/done.png��$
��Fill=�$��24��$��24��$	 0.5,0.5&�$��0,0,-10,-14q�z�V� .~��� �� �� T� $
 -5Q�$ -7Q�� -    �Name$
 Plat��$��0,33,0,0q�.+��� -	    ��Name$ 计分板输出��
 J� Uid$ EnableScore��$��8,6,271,183q� Z� .���� $��计分板输出��$
��12px(�$��Black"�
�������� -
   $ KeyScore��$��	0,1,0,109q�.+��� -   $ 键起始时间��$ DeltaTickStart��$��20,27,271,51q� Z� .���� $��键起始时间��$
��12px(��� -   $ 小节索引��$ BarIndex��$��140,27,152,51q� Z� .���� $��小节索引��$
��12px(��� -   $ 键持续时间��$ DeltaTickDuration��$��260,27,35,51q� Z� .���� $��键持续时间��$
��12px(��� -   $ 键起始刻数��$ MinecraftTickStart��$��20,47,271,31q� Z� .���� $��键起始刻数��$
��12px(��� -   $ 小节长度��$ BeatDuration��$��140,47,152,31q� Z� .���� $��小节长度��$
��12px(��� -   $ 键持续刻数��$ MinecraftTickDuration��$��260,47,35,31q� Z� .���� $��键持续刻数��$
��12px(��� -   $ 频道��$ Channel��$��20,67,271,11q� Z� .���� $��频道��$
��12px(��� -   $ 音高��$ Pitch��$��140,67,152,11q� Z� .���� $��音高��$
��12px(��� -   $ 力度��$ Velocity��$��260,67,35,11q� Z� .���� $��力度��$
��12px(��� $��1q�
��������� -   $ Playsound输出��$ EnablePlaysound��$��8,103,256,86q� Z� .���� $��Playsound输出��$
��12px(�$��Black"�
�������� -   $ 	PlaySound��$��	0,105,0,0q�.+��� -   $ 	Stopsound��$ 	StopSound��$��206,-4,86,82q� Z� .���� $��	Stopsound��$
��12px(��� -   $ 音高播放��$ PitchPlayable��$��298,-4,-6,82q� Z� .���� $��音高播放��$
��12px(��� -   $ C1��$��	音色名��$
��12px(�$��24,24,310,58q��� -    ��Name$ 音色名称��*  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$  ��$ 	SoundName��$��65,17,215,57q�$��24�� �� 
IsEditable . ���� *OptionalInstrument+�� $��1q�
�������$��0,-9,0,0q��� -   $ C2��$��播放相对坐标��$
��12px(�$��179,24,124,58q��� -    ��Name$ 播放相对坐标X��$  ��$ ExecuteCood1��$��257,17,86,57q�$��24���� -   $ 播放相对坐标Y��$  ��$ ExecuteCood2��$��295,17,48,57q�$��24���� -   $ 播放相对坐标Z��$  ��$ ExecuteCood3��$��333,17,10,57q�$��24���� -   $ C3��$��相对玩家��$
��12px(�$��12,51,308,31q��� -   $ 相对玩家��$  ��$ ExecuteTarget��$��65,44,245,32q�$��24���� -    $ C4��$��播放对象��$
��12px(�$��150,51,153,31q��� -!   $ 播放对象��$  ��$ 
PlayTarget��$��204,44,106,32q�$��24���� -"   $ C5��$	��源��$
��12px(�$��288,51,15,31q��� -#   $	 源��$  ��$ 
PlaySource��$��305,44,10,32q�$��24���� -$   $ C6��$��子表达式��$
��12px(�$��12,76,308,6q��� -%   $ 子表达式��$  ��$ InheritExpression��$��65,69,245,5q�$��24���� -&   $ C7��$��额外延时��$
��12px(�$��150,76,153,6q��� -'   $ 额外延时��$  ��$ 
ExtraDelay��$��204,69,139,5q�$��24���� -(   $ C8��$��Ticks��$
��12px(�$��244,77,59,5q��� -)   $ C9��$��音量��$
��12px(�$��278,76,25,6q��� -*    ��Name$ 音量增益��$��
306,75,5,7q�$ 
PercVolume�� � Value$ 50Q��� -+   $ 音量大小��$	��7px(�$��266,89,66,-7q�$��Center=�����  �� ElementName$ 音量增益�� �� Path$ Value� �� 	Converter# [  �� $��1q�
�������$��0,-9,0,0q��� $��1q�
�������