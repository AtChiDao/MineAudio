   M S B A M L   `   `   `  ���� L  HAudio2MinecraftUI, Version=1.1.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Audio2MinecraftUI.HumbergerAudio2MinecraftUI.Humberger  H DMahApps.Metro, Version=1.6.1.4, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls ,    &Audio2MinecraftUI.Humberger.LrcSetting   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ;local)clr-namespace:Audio2MinecraftUI.Humberger     PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     $	��250��$	��620��$	��250��$	��620��  � 	Resources  )  #System.Windows.Controls.DataGridRow �� 
TargetType �� Property �� Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%x   '        '  %     �� "  .���  � ��
 ������� "  .���  � ��$ Center=���  � ��
 �   �.��� .+��� -    ��Name$ 使用Tellraw输出��$��9,14,473,210q� d� 	IsChecked$ FalseY�{�.  .���� -    ��Name$ C1��$��使用Tellraw输出��$
��12px(��� -   $ 使用SubTitle输出��$��145,14,337,210q�$ FalseY�{�.  .���� -   $ C2��$��使用SubTitle输出��$
��12px(��� -   $ 使用ActionBar输出��$��282,14,200,210q�$ FalseY�{�.  .���� -   $ C3��$��使用ActionBar输出��$
��12px(��� -   $ 使用Title输出��$��428,14,54,210q�$ FalseY�{�.  .���� -   $ C4��$��使用Title输出��$
��12px(��� -	    ��Name$
 Done��$
��Left=�$��
585,10,0,0q�$	��Top=�$��24��$��24��{�.  .���� $��/img/done.png��$
��Fill=�$��24��$��24�� J� RenderTransformOrigin$ 0.5,0.5&�$��0,0,-10,-14q�z�V� .~��� �� �� T� 	 T� X$	 -5Q�
 T� Y$
 -7Q��� $
��Auto=�$��10,50,10,10q�.��&   System.Windows.Controls.DataGrid  -
     Name$ 歌词列表��   
IsReadOnly .    CanUserResizeColumns .     CanUserResizeRows .     SelectionMode$ Single=�   CanUserReorderColumns .   �� AlternationCount$ 2��   RowHeaderWidth$ 0Q�   CanUserAddRows .     CanUserSortColumns .     AutoGenerateColumns .     Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ 时间��   Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Time+  $ 内容��$
 150*  �� *	Content+