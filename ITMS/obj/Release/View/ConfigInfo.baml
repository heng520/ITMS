   M S B A M L   `   `   `  ���� ?  ;ITMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ITMS.View	ITMS.View  'clr-namespace:ITMS.Style
ITMS.Style      ITMS.View.ConfigInfo   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:ITMS.View     +themesclr-namespace:ITMS.Style     U QMaterialDesignThemes.Wpf, Version=3.1.0.981, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -     � WindowStyle$
  None=� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=� � AllowsTransparency . 
������  J� OpacityMask
 ����� � Title$ 
ConfigInfo��$	��500��$	��950�� � 	Resources  �� MergedDictionaries �� Source��  �� $j dpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.DialogHost.xaml?��� $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.DataGrid.xaml?�%    .��� 	 � RowDefinitions	 �� $��72 ��� $��* �.+��� -   ._�� ���� 
 �� ImageSource$-
 '/ITMS;component/Resource/poupheader.png�� � ColumnDefinitions �� $	��400 ��� $��* �.+��� $��数据配置��$��20(�$��Center=�$��Center=�$��2�����#FFFFFF��  �� Orientation$ 
Horizontal=�$��0q�$��Right=�$��1��.+��� -    ��Name$ MinimizeButton��$��15(�$	����   	windowBtn#��[      ITMS.Style.UniversalWindow   TitleBarButtonState$ 	MinimizedX����#FFFFFF�� -   $ RestoreButton��$��15(�$	����#��[  $ NormalX����#FFFFFF�� -   $ CloseButton��$��15(�$	����  Style.Button.Close#��[    IsTitleBarCloseButton . ���#FFFFFF)  #MaterialDesignThemes.Wpf.DialogHost     
Identifier$ configDialog��$��1��.���� ���#FFFFFF �� CornerRadius$ 	0 0 10 10��._�� 	 �� �� $��60 �.+�� $��20q� �� �� �� 	 �� �� �� ��   �� 
TargetType �� Property �� Value��%�   '��       '�� f     �� " ��.���  � ��$	 200����  � ��$ 30����  � ��$ 15(���  � ��$ 30���� " ��.���  � ��$ 15(���  � ��$ 30��.+��� $ 
Horizontal=�$��Center=�.+��� $��算力盒子ip���� -    ��Name$ faceIP���� $ 
Horizontal=�$��Center=�$��1��.+��� $��数据上传ip���� -   $ ApiIP���� $ 
Horizontal=�$��Center=�$��2��.+��� $��机构代码���� -   $ orgCode���� $ 
Horizontal=�$��Center=�$��1��$��0��.+��� $��环境温度   ���� -	   $ 	envirTemp���� $ 
Horizontal=�$��Center=�$��1��$��1��.+��� $��正常体温    ���� -
   $ normarlTemp���� $ 
Horizontal=�$��Center=�$��1��$��2��.+��� $��报警体温���� -   $ 	alarmTemp���� $ 
Horizontal=�$��Center=�$��2��$��0��.+��� $��VLC地址    ���� -   $ vlcDir���� $ 
Horizontal=�$��Center=�$��2��$��1��.+��� $��温度传感串口���� -   $ 
serialPort���� $ 
Horizontal=�$��Center=�$��2��$��2��.+��� $��文件保留时间���� -   $ fileTime���� $ 
Horizontal=�$��Center=�$��3��$��0��.+��� $��口罩报警��	� -    	�Name$ m1��$	��是��$��Center=�	� -   $ m2��$	��否��$��Center=��� $ 
Horizontal=�$��Center=�$��3��$��1��.+��� $��温度检测��	� -   $ temp1��$	��是��$��Center=�	� -   $ temp2��$	��否��$��Center=��� $ 
Horizontal=�$��Center=�$��3��$��2��.+��� $��图片上传��	� -   $	 up1��$	��是��$��Center=�	� -   $	 up2��$	��否��$��Center=��� $��2�����#e9eaec$�� 0 1 0 0q�._��� $ 
Horizontal=�$��Right=�$
��10 0q�.+��� -   $ OkButton��$��保存修改�� �� 	IsDefault . ���#2983f6���#FFFFFF  Blue#��[ $y�Visible=��� -   $ CancelButton��$��关闭�� 
 Cancel#��[ ���#CDCDCD���#FFFFFF���#FFFFFF$y�Visible=�