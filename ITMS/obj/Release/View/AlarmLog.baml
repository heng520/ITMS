   M S B A M L   `   `   `  ���� ?  ;ITMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ITMS.Style
ITMS.Style      ITMS.View.AlarmLog   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +themesclr-namespace:ITMS.Style     U QMaterialDesignThemes.Wpf, Version=3.1.0.981, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -     � WindowStyle$
  None=� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=� � AllowsTransparency . 
������  J� OpacityMask
 ����� � Title$ AlarmLog��$	��600��$	��900�� � 	Resources  �� MergedDictionaries �� Source��  �� $j dpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.DialogHost.xaml?��� $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.DataGrid.xaml?�%    .��� 	 � RowDefinitions	 �� $��72 ��� $��* �.+��� -   ._�� ���� 
 �� ImageSource$-
 '/ITMS;component/Resource/poupheader.png�� � ColumnDefinitions �� $	��400 ��� $��* �.+��� $��报警日志��$��20(�$��Center=�$��Center=�$��2�����#FFFFFF��  �� Orientation$ 
Horizontal=�$��0q�$��Right=�$��1��.+��� -    ��Name$ MinimizeButton��$��15(�$	����   	windowBtn#��[      ITMS.Style.UniversalWindow   TitleBarButtonState$ 	MinimizedX����#FFFFFF�� -   $ RestoreButton��$��15(�$	����#��[  $ NormalX����#FFFFFF�� -   $ CloseButton��$��15(�$	����  Style.Button.Close#��[    IsTitleBarCloseButton . ���#FFFFFF)  #MaterialDesignThemes.Wpf.DialogHost     
Identifier$ 	logDialog��$��1��.���� ���#FFFFFF �� CornerRadius$ 	0 0 10 10��._�� 	 �� $��60 ��� .+�]� $
��Left=�$
��20 0q�  �� 
TargetType �� Property �� Value �� 
TargetType��%�   '��       �� " ��.���  � ��$	 100����  � ��$ 35����  � �� �#FFFFFF��  � ��$ 15 0 0 0q���  � �� �� " ��.R��� $��
OverBorder��$��1q�#��z��$ 4��#��z��._��� $��Center=�$��Center=�.+��� -   $ viewLog��$��日志查看�����#007EFF� $��1�� �� $	��300 ��� .+��� $
��Auto=�$��10q�.��R� -    R�Name$ 	vedioData��  DefaultTreeView#��[ ����  �� ItemsSource �� *
Children+.R��� $ 
Horizontal=�.+��� $��	 0 0 10 0q����� *
imageBtn+�� $��Center=�$��14(�$��2,0,0,0q����� *
itemName+
 � Tag �� *	fileDir+&   System.Windows.Controls.DataGrid  -     Name$ 	senseView��   CanUserSortColumns .    CanUserAddRows .     HorizontalGridLinesBrush �#EEEEEE   GridLinesVisibility$ 
Horizontal=�"   VerticalScrollBarVisibility$
 Auto=�$   HorizontalScrollBarVisibility$
 Auto=�    RowHeaderWidth$  0Q�!   SelectionMode$! Extended=�  MoonGateThemesDataGrid#��[   MoonGateThemesDataGridRow"   RowStyle#" [ $��1��#   AutoGenerateColumns# .  $   Columns$ 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn%   Header$% 体温��&   Width5  /System.Windows.Controls.DataGridLengthConverter$& 70 1  +System.Windows.Controls.DataGridBoundColumn'   Binding' �� *temp+  $% 是否带口罩��$	& 100 ' �� *mask+  $% 时间��$	& 100 ' �� *time+4  .System.Windows.Controls.DataGridTemplateColumn  $% 图片��$	& 100 (   CellTemplate( �� .R��� ���� *imgdir+  $% 操作��$	&  80 ( �� .R��� -	   $��查看大图�����#999999$��15(�