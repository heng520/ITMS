   M S B A M L   `   `   `  ����?  ;ITMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ITMS.View	ITMS.View  5   	   U QVlc.DotNet.Wpf, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84529da31f4eb963G4clr-namespace:Vlc.DotNet.Wpf;assembly=Vlc.DotNet.WpfVlc.DotNet.Wpf 5   
   'clr-namespace:ITMS.Style
ITMS.Style  5   	       ITMS.View.RayModulation   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ITMS.View     5   	   Dvlc4clr-namespace:Vlc.DotNet.Wpf;assembly=Vlc.DotNet.Wpf     5   
   +themesclr-namespace:ITMS.Style     5   	   U QMaterialDesignThemes.Wpf, Version=3.1.0.981, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  61   -   5          � WindowStyle$
  None=�5	       � WindowStartupLocation$ CenterScreen=�6.    � 
ResizeMode$ NoResize=�6S    � AllowsTransparency . 
������  J� OpacityMask
 ����� � Title$ RayModulation��5
   	   $	��800��6    $
��1300��6-    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $j dpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.DialogHost.xaml?�6%   �� 5      $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.DataGrid.xaml?�6%   %    5      .��5      � 	 � RowDefinitions	 5   
   �� 5      $��72 �6   �� 5      $��* �6   .+�5   
   �� -   5        ._�5      � ��5      �� 5      
 �� ImageSource$-
 '/ITMS;component/Resource/poupheader.png��6!    � ColumnDefinitions 5!      �� 5"      $	��400 �6'   �� 5#      $��* �6'   .+�5%      �� $��红外头像位置调整��6   $��20(�6+   $��Center=�69   $��Center=�6T   $��2��6q   ���#FFFFFF6�   �� 5(       �� Orientation$ 
Horizontal=�6   $��0q�67   $��Right=�6B   $��1��6^   .+�5)      �� -   5         ��Name$ MinimizeButton��5)   +   $��15(�6   $	����6C      	windowBtn#��[  6W       ITMS.Style.UniversalWindow   TitleBarButtonState$ 	MinimizedX�6z   ���#FFFFFF6�   �� 5*      -   5        $ RestoreButton��5*   B   $y�	Collapsed=�6   $��15(�64   $	����6Y   #��[  6m   $ NormalX�6�   ���#FFFFFF6�   �� 5,      -   5        $ CloseButton��5,   ,   $��15(�6   $	����6A     Style.Button.Close#��[ 6U      IsTitleBarCloseButton . ���#FFFFFF6�   5-      5/      50      )  #MaterialDesignThemes.Wpf.DialogHost  51   
      
Identifier$ 
RootDialog��6$   $��1��6<   .��52      �� ���#FFFFFF �� CornerRadius$ 	0 0 10 10��6+   ._�53      � 	 54      �� 55      $��80 �6(   �� 56      �� 57      $	��250 �6)   .+�5:      �� ���#EEEEEE$��0 0 0 1q�63   � 5;       5<      �� 5=      �� 5>      .+�5@      ]� $
��Left=�6$   $
��20 0q�6?    5A       �� 
TargetType �� Property �� Value �� 
TargetType��%�  '��       �� 5B   "   " ��6(   .�5C   &   ��  � ��$	 100��6>   �� 5D   &    � ��$ 40��6?   �� 5E   &    � �� �#FFFFFF6C   �� 5F   &    � ��$ 15 0 0 0q�6?   �� 5G   &    �@�Cursor$
 Hand��6?   �� 5H   &    � �� 5I   *   �� 5J   .   " ��6>   .R�5K   2   �� $��
OverBorder��69   $��1q�6K   #��z��6_   $ 4��6�   #��z��6�   ._�5L   6   �� $��Center=�6G   $��Center=�6d   5M   3   5N   /   5P   '   5Q   #   5R      .+�5T      �� -   5        $ 	StartView��5T   J   $��开始预览��6%   ���#007EFF$y�	Collapsed=�6^   �� 5U      -   5        $��抓图��5U   %   ���#007EFF6G   �� 5V      -   5        $��算力盒子��5V   %   ���#007EFF6J   �� 5W      -	   5        $��温度计算��5W   %   ���#007EFF$y�	Collapsed=�6l   �� 5X      -
   5        $
 save��5X   ]   $��保存偏移量��6%   ���#007EFF6]   5Y      �� 5Z      $��1��6%   $��Center=�65   $ 
Horizontal=�6P   .+�5\      �� $��右移��6$   �� 5]      -   5         ��Name$ 	rightMove��5]   T   $	��120��6&   ��6g   Z� �� 5^      $��下移��6$   �� 5_      -   5        $ downMove��5_   T   $	��120��6&   ��6f   Z� �� 5`      $��	宽比例��6$   �� 5a      -   5        $ widthPro��5a   T   $	��120��6&   ��6f   Z� �� 5b      $��	高比例��6$   �� 5c      -   5        $ 	heightPro��5c   T   $	��120��6&   ��6g   Z� 5d      5f      � 5g      $��1��6   $��10q�6(    5h      �� 5i      �� 5j      �� 5k      .+�5n      �� .+�5v        Vlc.DotNet.Wpf.VlcControl  -   5          Name$ 	myControl��5v   .   $	��400��6B   $	��320��6N   ���#EEEEEE6[   �� 5w      -   5         ��Name$ r3��5w   (   
���  ��64   5x      �� 5y      $��1��6!   .+�5z      �� -   5         ��Name$	 img��5z   5   $��1��6$   $	��320��6B   $	��400��6P   $
��Fill=�6\   �� 5|      -   5        $ r1��5|   (   
���  ��64   5}      �� 5      $��2��6!   .+�5�      �� -   5        $
 img2��5�   &   $
��Fill=�65   $	��256��6E   $	��336��6S   �� 5�      -   5        $ r2��5�   (   
���   �64   5�      5�      � 5�      $��2��6   $��10q�6(   .+�5�      �� $��1��6'   $��Visible=�64   $��Disabled=�6Z   .��5�      �� -   5        $	 msg��5�   &   
����  ���6F   Z� 5�      5�      5�      5�      5�      5�      5�      