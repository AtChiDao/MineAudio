   M S B A M L   `   `   `  ����H  DExecutiveMidi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:ExecutiveMidi.HumbergerExecutiveMidi.Humberger  5      H DMahApps.Metro, Version=1.6.0.0, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5	      )    #ExecutiveMidi.Humberger.MidiSetting   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:ExecutiveMidi.Humberger     5      PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5	      -   5        $	��250��5
      $	��620��6   $	��250��6-   $	��620��6=   .��5      � $
��Left=�6   $	��250��6&   $��6,2,0,0q�63   $	��Top=�6D   $	��600��6\   .+�5   
   �� $
��Auto=�6   $��10,0,385,10q�6:   .��5      R� -   5          R�Name$  
TracksView��5   T   $	��228��6h   $	��202��6u    � DataContext 6   �� ��60   �� *Instruments+��5      �� 5       �� DataType)   #ExecutiveMidi.Humberger.MidiSetting"  6/   .R�5      ��  �� Orientation$ 
Horizontal=�6%   .+�5      �� ��6(   �� *Name+5      5      5      5      � 5   
   $��
220,0,0,10q�6   .+�5      �� $��1q�6   
�������6)   � 5      -   5         �Name$
 Plat��5      .+�5      �� -   5         ��Name$ SelectedName��5      $
��12px(�62   $��0,10,83,211q�6B   $��Center=�6W   �� 5      -   5        $
��Left=�5      $��	347,1,0,0q�64   $	��Top=�6G   $��32��6_   $��32��6k   .��5      �� -   5         ��Name$ SwitcherViewType��5      $��/img/track_view.png��66   $
��Fill=�6T   $��32��6c   $��32��6o    J� RenderTransformOrigin$ 0.5,0.5&�6z   $��0,0,-10,-10q�6�   z�5       V� 5!      .~�5"   "   �� �� 5#   "   �� 5$   "   T� 5%   "    T� X$ -6Q�65   	 T� Y$	 -7Q�6<   5&      
 � ToolTip
 5(      _� 5)      .��5*   "   �� &$切换为音轨列表 / 乐器列表5,   #   5-      5/      50      �� 51      -   5         ��Name$
 Done��51      $
��Left=�6'   $��	319,6,0,0q�6B   $	��Top=�6U   $��24��6m   $��24��6y   .��52      �� $��/img/done.png��6   $
��Fill=�64   $��24��6C   $��24��6O   $ 0.5,0.5&�6Z   $��0,0,-10,-14q�6z   z�53      V� 54      .~�55   "   �� �� 56   "   �� 57   "   T� 58   "   $ -6Q�65   $
	 -6.5Q�6<   59      
 5;      _� 5<      .��5=   "   �� 确认修改5?   #   5@      5B      5C      � 5D      -   5        $ Setting��5D      .+�5E      �� -	   5         ��Name$ C1��5E      $!��是否在键起始刻执行��6(   $��255,32,5,180q�6<   
 5F      _� 5G      .��5H   "   �� MK是否在键起始时执行命令（否则将在键结束时执行命令）5J   #   5K      5M      �� 5N      -
   5         ��Name$ ExecuteLocation��5N       d� 	IsChecked$
 TrueY�68   $��238,27,109,180q�6I   6a   �� 5O      -   5        $ C2��5O      $��命令��6(   $��7,32,253,180q�65   
 5P      _� 5Q      .��5R   "   �� 20可引用参数与数学表达式，详见官网5T   #   5U      5W      �� 5X      -   5         ��Name$ Command��5X      $��10,57,10,10q�6/    �� TextWrapping$
 Wrap=�6D    �� AcceptsReturn . " �� VerticalScrollBarVisibility$
 Auto=�6m   6�   5Y      5Z      5[      5\      5]      