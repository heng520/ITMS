   M S B A M L   `   `   `  ���� ?  ;ITMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ITMS.Style
ITMS.Style  U QVlc.DotNet.Wpf, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84529da31f4eb963G4clr-namespace:Vlc.DotNet.Wpf;assembly=Vlc.DotNet.WpfVlc.DotNet.Wpf     ITMS.View.PlayBack   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +themesclr-namespace:ITMS.Style     U QMaterialDesignThemes.Wpf, Version=3.1.0.981, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  >vlc4clr-namespace:Vlc.DotNet.Wpf;assembly=Vlc.DotNet.Wpf  -     � WindowStyle$
  None=� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=� � AllowsTransparency . 
������  J� OpacityMask
 ����� � Title$ PlayBack��$	��600��$	��900�� � 	Resources  �� MergedDictionaries �� Source��  �� $j dpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.DialogHost.xaml?��� $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.DataGrid.xaml?�%    .��� 	 � RowDefinitions	 �� $��72 ��� $��* �.+��� -   ._�� ���� 
 �� ImageSource$-
 '/ITMS;component/Resource/poupheader.png�� � ColumnDefinitions �� $	��400 ��� $��* �.+��� $��摄像机回放��$��20(�$��Center=�$��Center=�$��2�����#FFFFFF��  �� Orientation$ 
Horizontal=�$��0q�$��Right=�$��1��.+��� -    ��Name$ MinimizeButton��$��15(�$	����   	windowBtn#��[      ITMS.Style.UniversalWindow   TitleBarButtonState$ 	MinimizedX����#FFFFFF�� -   $ RestoreButton��$��15(�$	����#��[  $ NormalX����#FFFFFF�� -   $ CloseButton��$��15(�$	����  Style.Button.Close#��[    IsTitleBarCloseButton . ���#FFFFFF)  #MaterialDesignThemes.Wpf.DialogHost     
Identifier$ 
RootDialog��$��1��.���� ���#FFFFFF �� CornerRadius$ 	0 0 10 10��._�� 	 �� $��60 ��� .+�]� $
��Left=�$
��20 0q�  �� 
TargetType �� Property �� Value �� 
TargetType��%�   '��       �� " ��.���  � ��$	 100����  � ��$ 35����  � �� �#FFFFFF��  � ��$ 15 0 0 0q���  � �� �� " ��.R��� $��
OverBorder��$��1q�#��z��$ 4��#��z��._��� $��Center=�$��Center=�.+��� -   $ 	startView��$��开始回放�����#007EFF � Cursor$
 Hand���� -    ��Name$ errorMsg��$��15(�
���  ��� $��1�� �� $	��300 ��� .+��� $
��Auto=�$��10q�.��R� -    R�Name$ 	vedioData��  DefaultTreeView#��[ ����  �� ItemsSource �� *
Children+.R��� $ 
Horizontal=�.+��� $��	 0 0 10 0q����� *
imageBtn+�� $��Center=�$��14(�$��2,0,0,0q����� *
itemName+
 � Tag �� *	fileDir+  Vlc.DotNet.Wpf.VlcControl  -	     Name$ 	myControl�����#C5C5C5$��20q�$��1��$��1��