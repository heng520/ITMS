   M S B A M L   `   `   `  ���� ?  ;ITMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ITMS.View.PageITMS.View.Page  'clr-namespace:ITMS.Style
ITMS.Style      ITMS.View.EquipManager   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:ITMS.View.Page     +themesclr-namespace:ITMS.Style     U QMaterialDesignThemes.Wpf, Version=3.1.0.981, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � WindowStyle$
  None=� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=� � AllowsTransparency . 
������  J� OpacityMask
 ����� � Title$ EquipManager��$	��650��$	��850�� � 	Resources  �� MergedDictionaries �� Source��  �� $j dpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.DialogHost.xaml?��� $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.DataGrid.xaml?�%    .��� 	 � RowDefinitions	 �� $��72 ��� $��* �.+��� -   ._�� ���� 
 �� ImageSource$-
 '/ITMS;component/Resource/poupheader.png�� � ColumnDefinitions �� $	��400 ��� $��* �.+��� $��设备管理��$��20(�$��Center=�$��Center=�$��2�����#FFFFFF��  �� Orientation$ 
Horizontal=�$��0q�$��Right=�$��1��.+��� -    ��Name$ MinimizeButton��$��15(�$	����   	windowBtn#��[      ITMS.Style.UniversalWindow   TitleBarButtonState$ 	MinimizedX����#FFFFFF�� -   $ RestoreButton��$��15(�$	����#��[  $ NormalX����#FFFFFF�� -   $ CloseButton��$��15(�$	����  Style.Button.Close#��[    IsTitleBarCloseButton . ���#FFFFFF)  #MaterialDesignThemes.Wpf.DialogHost     
Identifier$ equipDialog��$��1��.���� ���#FFFFFF �� CornerRadius$ 	0 0 10 10��._�� 	 �� $��60 ��� �� $��60 �.+��� -    ��Name$ errorMsg��$��Center=�$��Center=�
���  ��$��12(�$y�	Collapsed=�]� $
��Left=�$
��20 0q�  �� 
TargetType �� Property �� Value �� 
TargetType��%�   '��       �� " ��.���  � ��$	 100����  � ��$ 35����  � �� �#FFFFFF��  � ��$ 15 0 0 0q���  � �� �� " ��.R��� $��
OverBorder��$��1q�#��z��$ 4��#��z��._��� $��Center=�$��Center=�.+��� -   $ addEquipment��$��设备添加�����#007EFF�� -   $ updateEquipment��$��修改�����#007EFF�� $��IP修改�����#007EFF$y�	Collapsed=��� -   $ deleteEquipment��$��删除�����#B13333$y�Visible=��� $��红外设置�����#007EFF$y�	Collapsed=�&   System.Windows.Controls.DataGrid  -	     Name$ 	equipList��$��1��$
��10 5q�   CanUserSortColumns .    CanUserAddRows .     AutoGenerateColumns .     HorizontalGridLinesBrush �#EEEEEE   GridLinesVisibility$ 
Horizontal=�"   VerticalScrollBarVisibility$
 Auto=�$   HorizontalScrollBarVisibility$
 Auto=�   RowHeaderWidth$ 0Q�    SelectionMode$  Extended=�  MoonGateThemesDataGrid#��[   MoonGateThemesDataGridRow!   RowStyle#! [ "   Columns" 4  .System.Windows.Controls.DataGridCheckBoxColumn    MoonGateThemesDataGridCell,  &System.Windows.Controls.DataGridColumn#   	CellStyle## [ $   CanUserReorder$ .  %   
Visibility$% 	Collapsed=�&   Width5  /System.Windows.Controls.DataGridLengthConverter$& 35 1  +System.Windows.Controls.DataGridBoundColumn'   Binding' �� *
IsSelected+( �� UpdateSourceTrigger$( PropertyChanged=�) �� Mode$) TwoWay=�*   Header* �� 
������ + �� Padding$	+ 3 0q�._��� $��Center=�, � DataContext, �� - �� RelativeSource- �� . �� AncestorType".  / �� Path$/ DataContext�0 d� 	IsChecked0 �� *AllSelectedCmd+0  *System.Windows.Controls.DataGridTextColumn  $* id��## [ $	& 100 ' �� *
DeviceId+  $* 设备名称��## [ ' �� *
deviceName+  $* 设备IP��$	& 150 ## [ 1   
IsReadOnly1 . ' �� *
CameraIp+  $* 红外IP��## [ ' �� *RayIp+4	  .System.Windows.Controls.DataGridTemplateColumn	  $* 操作��## [ $	& 100 2 	  CellTemplate2 �� .R��� $ 
Horizontal=�.+��� -
   $��红外线区域设置��$��10 0 0 0q�  TransparentButton#��[ , �� - �� ".  $/ DataContext�� $��2��$��Center=� �� $	��100 ��� �� $	��200 �.+��� $��默认视频Ip���� -   3 ��Name$3 stack��$ 
Horizontal=�$��1���� -     Blue#��[ $��保存��$��2��