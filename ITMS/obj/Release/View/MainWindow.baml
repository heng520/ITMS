   M S B A M L   `   `   `  ���� ?  ;ITMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ITMS.View	ITMS.View  'clr-namespace:ITMS.Style
ITMS.Style  5clr-namespace:ITMS.Style.ThemesITMS.Style.Themes  [ WSystem.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Y@clr-namespace:System.Windows.Forms;assembly=System.Windows.FormsSystem.Windows.Forms U QVlc.DotNet.Wpf, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84529da31f4eb963G4clr-namespace:Vlc.DotNet.Wpf;assembly=Vlc.DotNet.WpfVlc.DotNet.Wpf M ISystem, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089/$clr-namespace:System;assembly=SystemSystem     ITMS.View.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:ITMS.View     +themesclr-namespace:ITMS.Style     1vidioclr-namespace:ITMS.Style.Themes     Iwfi9http://schemas.microsoft.com/netfx/2007/xaml/presentation     Owf@clr-namespace:System.Windows.Forms;assembly=System.Windows.Forms     Dvlc4clr-namespace:Vlc.DotNet.Wpf;assembly=Vlc.DotNet.Wpf     4sys$clr-namespace:System;assembly=System     -     � WindowStyle$
  None=� � WindowStartupLocation$ CenterScreen=� � WindowState$ 	Maximized=� � Title$ 
MainWindow��$
��1080��$
��1920������  �� ImageSource$% /ITMS;component/Resource/bg.png�� j� Stretch$
 Fill=�'  !System.Windows.Shell.WindowChrome   WindowChrome      GlassFrameThickness$ 0 31 0 0q�   CornerRadius$ 0��	   UseAeroCaptionButtons	 . 
 � 	Resources
  �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius�� %�   '��       �� " ��.���  � ��$ 57����  � ��$ 131.6����  � ��$ 18(���  �@�Cursor$
 Hand����  � �� �#FFFFFF��  � �� �� " ��.R��� $ 10��#��z��#��z��#��z��._��� $��Center=�$��Center=�.��(� .��� $
��1080��$
��1920�� � RowDefinitions �� $	��101 ��� .+��� $)��#/ITMS;component/Resource/header.png��$
��Fill=�$
��90 0q��� $��红外测温客户端��$��48(����#FFFFFF$��Center=�$��Center=�$��FZZDHJW--GB1-0)��  � ColumnDefinitions �� �� $	��400 �.+���  �� Orientation$ 
Horizontal=�$��1��$��Right=�$	��Top=�
 ��%#  '��       �� " ��.���  � ��$ 46����  � ��$ 46����  � ��$ 20(���  � ��$ 0q���  � �� �#2D7DFF��  � ��
 ���� ��  � �� �� " ��.R��� $��
OverBorder��$��0q�._��� $*��$/ITMS;component/Resource/manager.png��$��20��$��20��.+��� �� -    ��Name$ MinimizeButton��$	����   	windowBtn#��[      ITMS.Style.UniversalWindow   TitleBarButtonState$ 	MinimizedX����#FFFFFF�� -   $ RestoreButton��$	����#��[  $ NormalX����#FFFFFF$y�	Collapsed=��� -   $ CloseButton��$	����  Style.Button.Close#��[    IsTitleBarCloseButton . ���#FFFFFF� $��1�� �� $	��336 ��� �� $	��450 �.+��  �� $	��200 ��� �� $	��210 � �� $��52 ��� .+��� $+��%/ITMS;component/Resource/leftLine.png��$��2��$
��Fill=�� $��1��$��Bottom=�$	��148��$	��260��$
��Left=����� $' !/ITMS;component/Resource/user.png�� �� $	��105 ��� .+��� $��	26 10 0 0q�$
��Left=�$ 
Horizontal=�$��Center=�.+��� $,��&/ITMS;component/Resource/headerimg.png��$��45��$��45���� $��admin��$��24(����#FFFFFF$��Center=�$��15 0 0 0q��� $ 
Horizontal=�$��1��$��20 0 0 0q�$	��Top=�.+��� -   $ modifyPassword��   ITMS.Style.ImageButton   BackImg$- '/ITMS;component/Resource/passwodimg.png��  
LeftImgBtn#��[ $��修改密码���� -   $ 
closeLogin��$' !/ITMS;component/Resource/exit.png��#��[ $��退出登录��$��20 0 0 0q��� $��1��$	��Top=�$��1��
   HomeBtn �� BasedOn��%�   '��       7  �� " ��8   .���  �@ BackImg$* $/ITMS;component/Resource/leftbtn.png����  �@ BackImgClick$/ )/ITMS;component/Resource/leftbtnClick.png����  � ��$
 Left=���  � ��$
 0 16q�.+��� -   $ equipManager��$��设备管理��$��	0 30 0 16q��� -   $ HandTrigger��$��手动触发��$y�	Collapsed=��� -	   $ 	configMan��$��数据配置���� -
   $ backplay��$��回放���� -   $ RayModul��$��红外线调整���� -   $ alarmL��$��报警日志��� $��1��$��2��$	��Top=�$	��180��$	��260��$
��Left=����� $' !/ITMS;component/Resource/user.png�� �� �� .+��� $ 
Horizontal=�$��Center=�$��	 0 20 0 0q�.+��� $'��!/ITMS;component/Resource/img1.png��$��58��$��49��$��22 0 0 0q��� $'��!/ITMS;component/Resource/img4.png��$��58��$��49��$��22 0 0 0q��� $'��!/ITMS;component/Resource/img6.png��$��58��$��49��$��22 0 0 0q��� $ 
Horizontal=�$��Center=�$��1��.+��� $'��!/ITMS;component/Resource/img8.png��$��58��$��49��$��22 0 0 0q��� $'��!/ITMS;component/Resource/img9.png��$��58��$��49��$��22 0 0 0q��� $*��$/ITMS;component/Resource/imgmore.png��$��58��$��49��$��22 0 0 0q��� ���#EEEEEE$��0 0 0 0q�$y�	Collapsed=�._�7  1System.Windows.Forms.Integration.WindowsFormsHost     
Background �#C5C5C5$��1��$��1�� K� ZIndex$ 0��   Child. %  System.Windows.Forms.PictureBox  -   pictureBox1��� $��1�� �� $��40 ��� �� $	��150 �.+��� -    ��Name$ nowTime��$��30(�$��Center=����#FFFFFF� $��1������ $( "/ITMS;component/Resource/vedio.png��$
 Fill=� �� $��1* ��� $	��32* ��� $��1* � �� �� $	��18* ��� .+�  Vlc.DotNet.Wpf.VlcControl  -     Name$ 	myControl�����#C5C5C5$	��700��$
��1077��$��1��$��1���� -    ��Name$ canvansVedio��$��1��$��1��$	��700��$
��1077���� $ 
Horizontal=�$��2��$��Center=�
 ��%�   '��       7  �� 8   " ��.���  � ��$	 107����  � ��$ 97����  � ��$ 27 0 0 0q���  �@�Cursor$
 Hand��.+��� -   $ startdVidio��$y�	Collapsed=� � ToolTip$ 开始预览��$- '/ITMS;component/Resource/startClick.png��   BackImgClick$( "/ITMS;component/Resource/start.png���� -   $ break��$y�	Collapsed=�$ 断开视频��$( "/ITMS;component/Resource/break.png��$- '/ITMS;component/Resource/breakCLick.png���� -   $ RecordVidio��$ 录像��$+ %/ITMS;component/Resource/vedioBtn.png��$0 */ITMS;component/Resource/vedioBtnCLick.png���� -   $ photo��$ 抓拍��$( "/ITMS;component/Resource/photo.png��$- '/ITMS;component/Resource/photoCLick.png��� $��2��$��10 50 34 28q� �� $	�� 50 ��� $
�� 100 ��� .+��� $0��*/ITMS;component/Resource/equipmentlist.png��$
��Fill=�$��3���� $/��)人数统计：(程序启动开始统计)��$��18(����#FFFFFF$��Bottom=��� ���#FFFFFF$��0 0 0 1q�$
��10 0q�$��1���� $ 
Horizontal=�$��Center=�$��Center=�$��1��
 ��%K   '��       �� " ��.���  � �� �	#FFFFFFFF��  � ��$ 16(�.+��� .+��� $��检测人数���� -   $
 pNum��$��0��$��Center=��� .+��� $��体温异常���� -   $ highNum��$��0��
���  ��$��Center=��� .+��� $��未带口罩���� -   $ maskNum��$��0��
���  ��$��Center=��� $��2��$��10 10q�.��&   System.Windows.Controls.DataGrid  -      Name$  	senseView��$��	5 10 4 10q�!   CanUserSortColumns! . "   CanUserAddRows" .  ���#031d62���#FFFFFF#   HorizontalGridLinesBrush# �#EEEEEE$   GridLinesVisibility$$ 
Horizontal=�"%   VerticalScrollBarVisibility$
% Auto=�$&   HorizontalScrollBarVisibility$
& Auto=�'   SelectionMode$' Extended=�  MoonGateThemesDataGrid#��[   MoonGateThemesDataGridRow(   RowStyle#( [ $��1��)   AutoGenerateColumns) .  *   ColumnHeaderStyle* �� =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  .���  � ��$ Center=���  � �� �#031d62��  � �� �#FFFFFF��  � ��$ 1q���  � �� �#EEEEEE��  � ��$ 30��
 + �� Triggers, P� Property- P� Value��%L  '��       �� " ��.���  � ��
 ���� ��  � �� �#FFFFFF��  �@�Cursor$
 Hand����  � �� �� " ��.R��� ���#FFFFFF$��0q�#��z��._��� #��z��$��	Underline{�+ P� , �@J�IsMouseOver- . . ���  � �� �#007EFFP� , �@J�IsMouseOver- . . ���  � �� �#007EFF.   Columns. 0	  *System.Windows.Controls.DataGridTextColumn	  ,
  &System.Windows.Controls.DataGridColumn/ 
  Header$/ 体温��0 
  Width5  /System.Windows.Controls.DataGridLengthConverter$0 60 1  +System.Windows.Controls.DataGridBoundColumn1   Binding1 �� *temp+	  $/ 口罩��$0 65 1 �� *mask+	  $/ 姓名��$0 80 1 �� *	MatchName+4  .System.Windows.Controls.DataGridTemplateColumn  $/ 图片��$	0 100 2   CellTemplate2 �� .R��� ���� *imgDir+  $/ 操作��$	0  50 2 �� .R��� $ BigImage��-   $��查看�����#999999$��15(�