   M S B A M L   `   `   `  ����?  ;ITMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ITMS.View.PageITMS.View.Page  5   	   'clr-namespace:ITMS.Style
ITMS.Style  65   U QVlc.DotNet.Wpf, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84529da31f4eb963G4clr-namespace:Vlc.DotNet.Wpf;assembly=Vlc.DotNet.WpfVlc.DotNet.Wpf 5   R       ITMS.View.InfraredRay   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:ITMS.View.Page     5   	   +themesclr-namespace:ITMS.Style     65   U QMaterialDesignThemes.Wpf, Version=3.1.0.981, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   >vlc4clr-namespace:Vlc.DotNet.Wpf;assembly=Vlc.DotNet.Wpf  6R   -   5          � WindowStyle$
  None=�5       � WindowStartupLocation$ CenterScreen=�6.    � 
ResizeMode$ NoResize=�6S    � AllowsTransparency . 
������  J� OpacityMask
 ����� � Title$ InfraredRay��5	   	   $	��645��6   $	��800��6*    � 	Resources 5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $j dpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.DialogHost.xaml?�6%   �� 5      $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.DataGrid.xaml?�6%   %    5      .��5      � 	 � RowDefinitions	 5   
   �� 5      $��72 �6   �� 5      $��* �6   .+�5   
   �� -   5        ._�5      � ��5      �� 5      
 �� ImageSource$-
 '/ITMS;component/Resource/poupheader.png��6!    � ColumnDefinitions 5       �� 5!      $	��400 �6'   �� 5"      $��* �6'   .+�5$      �� $��红外测温区域设置��6   $��20(�6+   $��Center=�69   $��Center=�6T   $��2��6q   ���#FFFFFF6�   �� 5'       �� Orientation$ 
Horizontal=�6   $��0q�67   $��Right=�6B   $��1��6^   .+�5(      �� -   5         ��Name$ MinimizeButton��5(   +   $��15(�6   $	����6C      	windowBtn#��[  6W       ITMS.Style.UniversalWindow   TitleBarButtonState$ 	MinimizedX�6z   ���#FFFFFF6�   �� 5)      -   5        $ RestoreButton��5)   ,   $��15(�6   $	����6C   #��[  6W   $ NormalX�6z   ���#FFFFFF$y�	Collapsed=�6�   �� 5+      -   5        $ CloseButton��5+   ,   $��15(�6   $	����6A     Style.Button.Close#��[ 6U      IsTitleBarCloseButton . ���#FFFFFF6�   5,      5-      5.      )  #MaterialDesignThemes.Wpf.DialogHost  5/   
      
Identifier$ 
RootDialog��6$   $��1��6<   .��50      �� ���#FFFFFF �� CornerRadius$ 	0 0 10 10��6+   ._�51      � 	 52      �� 53      $��60 �6(   �� 54      .+�56      �� ���#EEEEEE$��0 0 0 1q�63   ]� 57      $
��Left=�6    $
��20 0q�6;    58       �� 
TargetType �� Property �� Value �� 
TargetType��%�  '��       �� 59      " ��6$   .�5:   "   ��  � ��$	 100��6:   �� 5;   "    � ��$ 35��6;   �� 5<   "    � �� �#FFFFFF6?   �� 5=   "    � ��$ 15 0 0 0q�6;   �� 5>   "    � �� 5?   &   �� 5@   *   " ��6:   .R�5A   .   �� $��
OverBorder��65   $��1q�6G   #��z��6[   $ 4��6�   #��z��6�   ._�5B   2   �� $��Center=�6C   $��Center=�6`   5C   /   5D   +   5F   #   5G      5H      .+�5I      �� -   5        $ AddArea��5I   G   $��增加测温区域��6!   ���#007EFF6X   �� 5J      -   5        $ 
selectArea��5J   G   $��选中测温区域��6!   ���#007EFF6[   �� 5L      -   5        $ 
deleteArea��5L   G   $��删除测温区域��6!   ���#007EFF6[   �� 5M      -	   5        $ savaArea��5M   C   $��保存��6!   ���#007EFF6U   5N      � 5O      $��1��6   $	��720��6(   ��5P      �� 5Q      $(
 "/ITMS;component/Resource/vedio.png��6)    j� Stretch$
 Fill=�6Z   .+�5T        Vlc.DotNet.Wpf.VlcControl  -
   5          Name$ 	myControl��5T   *   ���#C5C5C5$��1��6S   $��1��6`   $	��672��6q   $	��452��6}   �� 5U      -   5         ��Name$ 	inkCanvas��5U   V    �� 
Background
 ���� $	��672��6=   $	��452��6I   6�   5V      5X      5Y      5Z      5[      5\      