   M S B A M L   `   `   `  ���� ?  ;ITMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ITMS.View	ITMS.View  U QVlc.DotNet.Wpf, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84529da31f4eb963G4clr-namespace:Vlc.DotNet.Wpf;assembly=Vlc.DotNet.WpfVlc.DotNet.Wpf 'clr-namespace:ITMS.Style
ITMS.Style      ITMS.View.RayModulation   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:ITMS.View     Dvlc4clr-namespace:Vlc.DotNet.Wpf;assembly=Vlc.DotNet.Wpf     +themesclr-namespace:ITMS.Style     U QMaterialDesignThemes.Wpf, Version=3.1.0.981, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -     � WindowStyle$
  None=� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=� � AllowsTransparency . 
������  J� OpacityMask
 ����� � Title$ RayModulation��$	��800��$
��1300�� � 	Resources  �� MergedDictionaries �� Source��  �� $j dpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.DialogHost.xaml?��� $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.DataGrid.xaml?�%    .��� 	 � RowDefinitions	 �� $��72 ��� $��* �.+��� -   ._�� ���� 
 �� ImageSource$-
 '/ITMS;component/Resource/poupheader.png�� � ColumnDefinitions �� $	��400 ��� $��* �.+��� $��红外头像位置调整��$��20(�$��Center=�$��Center=�$��2�����#FFFFFF��  �� Orientation$ 
Horizontal=�$��0q�$��Right=�$��1��.+��� -    ��Name$ MinimizeButton��$��15(�$	����   	windowBtn#��[      ITMS.Style.UniversalWindow   TitleBarButtonState$ 	MinimizedX����#FFFFFF�� -   $ RestoreButton��$y�	Collapsed=�$��15(�$	����#��[  $ NormalX����#FFFFFF�� -   $ CloseButton��$��15(�$	����  Style.Button.Close#��[    IsTitleBarCloseButton . ���#FFFFFF)  #MaterialDesignThemes.Wpf.DialogHost     
Identifier$ 
RootDialog��$��1��.���� ���#FFFFFF �� CornerRadius$ 	0 0 10 10��._�� 	 �� $��80 ��� �� $	��250 �.+��� ���#EEEEEE$��0 0 0 1q��  �� �� .+�]� $
��Left=�$
��20 0q�  �� 
TargetType �� Property �� Value �� 
TargetType��%  '��       �� " ��.���  � ��$	 100����  � ��$ 40����  � �� �#FFFFFF��  � ��$ 15 0 0 0q���  �@�Cursor$
 Hand����  � �� �� " ��.R��� $��
OverBorder��$��1q�#��z��$ 4��#��z��._��� $��Center=�$��Center=�.+��� -   $ 	StartView��$��开始预览�����#007EFF$y�	Collapsed=��� -   $��抓图�����#007EFF�� -   $��算力盒子�����#007EFF�� -	   $��温度计算�����#007EFF$y�	Collapsed=��� -
   $
 save��$��保存偏移量�����#007EFF�� $��1��$��Center=�$ 
Horizontal=�.+��� $��右移���� -    ��Name$ 	rightMove��$	��120����Z� �� $��下移���� -   $ downMove��$	��120����Z� �� $��	宽比例���� -   $ widthPro��$	��120����Z� �� $��	高比例���� -   $ 	heightPro��$	��120����Z� � $��1��$��10q� �� �� �� .+��� .+�  Vlc.DotNet.Wpf.VlcControl  -     Name$ 	myControl��$	��400��$	��320�����#EEEEEE�� -    ��Name$ r3��
���  ���� $��1��.+��� -    ��Name$	 img��$��1��$	��320��$	��400��$
��Fill=��� -   $ r1��
���  ���� $��2��.+��� -   $
 img2��$
��Fill=�$	��256��$	��336���� -   $ r2��
���   �� $��2��$��10q�.+��� $��1��$��Visible=�$��Disabled=�.���� -   $	 msg��
����  ���Z� 