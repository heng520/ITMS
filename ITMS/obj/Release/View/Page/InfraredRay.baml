   M S B A M L   `   `   `  ���� ?  ;ITMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ITMS.View.PageITMS.View.Page  'clr-namespace:ITMS.Style
ITMS.Style  U QVlc.DotNet.Wpf, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84529da31f4eb963G4clr-namespace:Vlc.DotNet.Wpf;assembly=Vlc.DotNet.WpfVlc.DotNet.Wpf     ITMS.View.InfraredRay   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:ITMS.View.Page     +themesclr-namespace:ITMS.Style     U QMaterialDesignThemes.Wpf, Version=3.1.0.981, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  >vlc4clr-namespace:Vlc.DotNet.Wpf;assembly=Vlc.DotNet.Wpf  -     � WindowStyle$
  None=� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=� � AllowsTransparency . 
������  J� OpacityMask
 ����� � Title$ InfraredRay��$	��645��$	��800�� � 	Resources  �� MergedDictionaries �� Source��  �� $j dpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.DialogHost.xaml?��� $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.DataGrid.xaml?�%    .��� 	 � RowDefinitions	 �� $��72 ��� $��* �.+��� -   ._�� ���� 
 �� ImageSource$-
 '/ITMS;component/Resource/poupheader.png�� � ColumnDefinitions �� $	��400 ��� $��* �.+��� $��红外测温区域设置��$��20(�$��Center=�$��Center=�$��2�����#FFFFFF��  �� Orientation$ 
Horizontal=�$��0q�$��Right=�$��1��.+��� -    ��Name$ MinimizeButton��$��15(�$	����   	windowBtn#��[      ITMS.Style.UniversalWindow   TitleBarButtonState$ 	MinimizedX����#FFFFFF�� -   $ RestoreButton��$��15(�$	����#��[  $ NormalX����#FFFFFF$y�	Collapsed=��� -   $ CloseButton��$��15(�$	����  Style.Button.Close#��[    IsTitleBarCloseButton . ���#FFFFFF)  #MaterialDesignThemes.Wpf.DialogHost     
Identifier$ 
RootDialog��$��1��.���� ���#FFFFFF �� CornerRadius$ 	0 0 10 10��._�� 	 �� $��60 ��� .+��� ���#EEEEEE$��0 0 0 1q�]� $
��Left=�$
��20 0q�  �� 
TargetType �� Property �� Value �� 
TargetType��%�   '��       �� " ��.���  � ��$	 100����  � ��$ 35����  � �� �#FFFFFF��  � ��$ 15 0 0 0q���  � �� �� " ��.R��� $��
OverBorder��$��1q�#��z��$ 4��#��z��._��� $��Center=�$��Center=�.+��� -   $ AddArea��$��增加测温区域�����#007EFF�� -   $ 
selectArea��$��选中测温区域�����#007EFF�� -   $ 
deleteArea��$��删除测温区域�����#007EFF�� -	   $ savaArea��$��保存�����#007EFF� $��1��$	��720������ $(
 "/ITMS;component/Resource/vedio.png�� j� Stretch$
 Fill=�.+�  Vlc.DotNet.Wpf.VlcControl  -
     Name$ 	myControl�����#C5C5C5$��1��$��1��$	��672��$	��452���� -    ��Name$ 	inkCanvas�� �� 
Background
 ���� $	��672��$	��452��