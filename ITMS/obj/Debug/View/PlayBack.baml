   M S B A M L   `   `   `  ����?  ;ITMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ITMS.Style
ITMS.Style  5      U QVlc.DotNet.Wpf, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84529da31f4eb963G4clr-namespace:Vlc.DotNet.Wpf;assembly=Vlc.DotNet.WpfVlc.DotNet.Wpf 6y       ITMS.View.PlayBack   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +themesclr-namespace:ITMS.Style     5      U QMaterialDesignThemes.Wpf, Version=3.1.0.981, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  60   >vlc4clr-namespace:Vlc.DotNet.Wpf;assembly=Vlc.DotNet.Wpf  6y   -   5          � WindowStyle$
  None=�5       � WindowStartupLocation$ CenterScreen=�6.    � 
ResizeMode$ NoResize=�6S    � AllowsTransparency . 
������  J� OpacityMask
 ����� � Title$ PlayBack��5	   	   $	��600��6   $	��900��6'    � 	Resources 5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $j dpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.DialogHost.xaml?�6%   �� 5      $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.DataGrid.xaml?�6%   %    5      .��5      � 	 � RowDefinitions	 5   
   �� 5      $��72 �6   �� 5      $��* �6   .+�5   
   �� -   5        ._�5      � ��5      �� 5      
 �� ImageSource$-
 '/ITMS;component/Resource/poupheader.png��6!    � ColumnDefinitions 5       �� 5!      $	��400 �6'   �� 5"      $��* �6'   .+�5$      �� $��摄像机回放��6   $��20(�6(   $��Center=�66   $��Center=�6Q   $��2��6n   ���#FFFFFF6�   �� 5'       �� Orientation$ 
Horizontal=�6   $��0q�67   $��Right=�6B   $��1��6^   .+�5(      �� -   5         ��Name$ MinimizeButton��5(   +   $��15(�6   $	����6C      	windowBtn#��[  6W       ITMS.Style.UniversalWindow   TitleBarButtonState$ 	MinimizedX�6z   ���#FFFFFF6�   �� 5)      -   5        $ RestoreButton��5)   ,   $��15(�6   $	����6C   #��[  6W   $ NormalX�6z   ���#FFFFFF6�   �� 5+      -   5        $ CloseButton��5+   ,   $��15(�6   $	����6A     Style.Button.Close#��[ 6U      IsTitleBarCloseButton . ���#FFFFFF6�   5,      5.      5/      )  #MaterialDesignThemes.Wpf.DialogHost  50   
      
Identifier$ 
RootDialog��6$   $��1��6<   .��51      �� ���#FFFFFF �� CornerRadius$ 	0 0 10 10��6+   ._�52      � 	 53      �� 54      $��60 �6(   �� 55      .+�58      ]� $
��Left=�6    $
��20 0q�6;    59       �� 
TargetType �� Property �� Value �� 
TargetType��%�  '��       �� 5:      " ��6$   .�5;   "   ��  � ��$	 100��6:   �� 5<   "    � ��$ 35��6;   �� 5=   "    � �� �#FFFFFF6?   �� 5>   "    � ��$ 15 0 0 0q�6;   �� 5?   "    � �� 5@   &   �� 5A   *   " ��6:   .R�5B   .   �� $��
OverBorder��65   $��1q�6G   #��z��6[   $ 4��6�   #��z��6�   ._�5C   2   �� $��Center=�6C   $��Center=�6`   5D   /   5E   +   5G   #   5H      5I      .+�5K      �� -   5        $ 	startView��5K   F   $��开始回放��6!   ���#007EFF � Cursor$
 Hand��6q   �� 5L      -   5         ��Name$ errorMsg��5L       $��15(�62   
���  ��6@   5M      � 5O      $��1��6    5P      �� 5Q      $	��300 �6/   �� 5R      .+�5U      �� $
��Auto=�6'   $��10q�6L   .��5V      R� -   5         R�Name$ 	vedioData��5V   P     DefaultTreeView#��[ 6'   ��5Z   "   �� 5[   &    �� ItemsSource 6?   �� *
Children+.R�5\   *   �� $ 
Horizontal=�65   .+�5]   .   �� $��	 0 0 10 0q�6P   ��64   �� *
imageBtn+6P   �� 5^   .   $��Center=�68   $��14(�6S   $��2,0,0,0q�6{   ��6a   �� *
itemName+
 � Tag 6�   �� *	fileDir+6�   5_   +   5`   '   5b      5c        Vlc.DotNet.Wpf.VlcControl  5e      -	   5          Name$ 	myControl��5e   *   ���#C5C5C5$��20q�6S   $��1��6`   $��1��6m   5g      5h      5i      5j      5k      5l      