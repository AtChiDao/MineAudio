   M S B A M L   `   `   `  ����L  HAudio2MinecraftUI, Version=1.1.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Audio2MinecraftUI.HumbergerAudio2MinecraftUI.Humberger  5      H DMahApps.Metro, Version=1.6.1.4, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5	      ,    &Audio2MinecraftUI.Humberger.LrcSetting   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:Audio2MinecraftUI.Humberger     5      PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5	      $	��250��5
      $	��620��6   $	��250��6-   $	��620��6=     � 	Resources  5      )  #System.Windows.Controls.DataGridRow �� 
TargetType �� Property �� Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%�   '        '  J     �� 5   
   "  6   .�5      ��  � ��
 �����6+   5      �� 5   
   "  6   .�5      ��  � ��$ Center=�6;   �� 5       � ��
 �   �6+   5      5      .��5      � .+�5   
   �� -   5         ��Name$ 使用Tellraw输出��5      $��9,14,473,210q�6(    d� 	IsChecked$ FalseY�6>   {�.  .��5      �� -   5         ��Name$ C1��5      $��使用Tellraw输出��6$   $
��12px(�67    � ToolTip 5      _� 5      .��5      �� #!以/title命令在标题栏输出5      5      5      5       �� 5!   
   -   5        $ 使用SubTitle输出��5!      $��145,14,337,210q�6)   $ FalseY�6A   {�.  .��5"      �� -   5        $ C2��5"      $��使用SubTitle输出��6$   $
��12px(�68    5#      _� 5$      .��5%      �� &$以/title命令在副标题栏输出5'      5(      5*      5+      �� 5,   
   -   5        $ 使用ActionBar输出��5,      $��282,14,200,210q�6*   $ FalseY�6B   {�.  .��5-      �� -   5        $ C3��5-      $��使用ActionBar输出��6$   $
��12px(�69    5.      _� 5/      .��50      �� )'以/title命令在物品栏上方输出52      53      55      56      �� 57   
   -   5        $ 使用Title输出��57      $��428,14,54,210q�6&   $ FalseY�6=   {�.  .��58      �� -   5        $ C4��58      $��使用Title输出��6$   $
��12px(�65    59      _� 5:      .��5;      �� %#以/tellraw命令在聊天栏输出5=      5>      5?   '   5@      �� 5A   
   -	   5         ��Name$
 Done��5A      $
��Left=�6   $��
585,10,0,0q�6:   $	��Top=�6N   $��24��6f   $��24��6r   {�.  .��5B      �� $��/img/done.png��6   $
��Fill=�6,   $��24��6;   $��24��6G   	 J� RenderTransformOrigin$	 0.5,0.5&�6R   $��0,0,-10,-14q�6r   z�5C      V� 5D      .~�5E      �� �� 5F      �� 5G      T� 5H      
 T� X$
 -5Q�6-    T� Y$ -7Q�64   5I      5K      5L      �� 5M   
   $
��Auto=�6   $��10,50,10,10q�6:   .��5N      &   System.Windows.Controls.DataGrid  -
   5          Name$ 歌词列表��5N         
IsReadOnly .    CanUserResizeColumns .     CanUserResizeRows .     SelectionMode$ Single=�6n      CanUserReorderColumns .   �� AlternationCount$ 2��6�      RowHeaderWidth$ 0Q�6�      CanUserAddRows .     CanUserSortColumns .     AutoGenerateColumns .     Columns 5O      0  *System.Windows.Controls.DataGridTextColumn  5P      ,  &System.Windows.Controls.DataGridColumn   Header$ 时间��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� *Time+  5Q      $ 内容��6)   $
 150* 65    6B   �� *	Content+5S      5T      5U      5V      