   M S B A M L   `   `   `  ���� ?  ;ITMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ITMS.View	ITMS.View  'clr-namespace:ITMS.Style
ITMS.Style      ITMS.View.ModifyPassword   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:ITMS.View     +themesclr-namespace:ITMS.Style     U QMaterialDesignThemes.Wpf, Version=3.1.0.981, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � WindowStyle$
  None=� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=� � AllowsTransparency . 
������  J� OpacityMask
 ����� � Title$ ModifyPassword��$	��300��$	��400�� � 	Resources  �� MergedDictionaries �� Source��  �� $j dpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.DialogHost.xaml?��� $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.DataGrid.xaml?�%    .��� 	 � RowDefinitions	 �� $��50 ��� $��* �.+��� -   ._�� ���� 
 �� ImageSource$-
 '/ITMS;component/Resource/poupheader.png�� � ColumnDefinitions �� $��* ��� $��* �.+��� $��密码修改��$��20(�$��Center=�$��Center=�$��2�����#FFFFFF��  �� Orientation$ 
Horizontal=�$��0q�$��Right=�$��1��.+��� -    ��Name$ MinimizeButton��$��15(�$	����   	windowBtn#��[      ITMS.Style.UniversalWindow   TitleBarButtonState$ 	MinimizedX����#FFFFFF�� -   $ RestoreButton��$y�	Collapsed=�$��15(�$	����#��[  $ NormalX����#FFFFFF�� -   $ CloseButton��$��15(�$	����  Style.Button.Close#��[    IsTitleBarCloseButton . ���#FFFFFF)  #MaterialDesignThemes.Wpf.DialogHost     
Identifier$ 
RootDialog��$��1��.���� ���#FFFFFF �� CornerRadius$ 	0 0 10 10��._�� 	 �� �� $��60 �.+�]� $��Right=�$
��20 0q�$��1��  �� 
TargetType �� Property �� Value �� 
TargetType��%�   '��       �� " ��.���  � ��$	 100����  � ��$ 40����  � �� �#FFFFFF��  � ��$ 15 0 0 0q���  � �� �� " ��.R��� $��
OverBorder��$��1q�#��z��$ 4��#��z��._��� $��Center=�$��Center=�.+��� -   $ Confirm��$��确认�����#007EFF�� -   $ Cancel��$��取消�����#EEEEEE���#007EFF�� $��Center=�$��Center=�$��0 10 0 0q� ��%�   '��       '�� #     '�� F     �� " ��.���  � ��$ 10q��� " ��.���  � ��$ 15(��� " ��.���  � ��$ 10 0 0 0q���  � ��$ 30��.+��� $ 
Horizontal=�.+��� $��       原密码��G� -    G�Name$ oldPwd��$	��200���� $ 
Horizontal=�.+��� $��       新密码��G� -   $ newPwd��$	��200���� $ 
Horizontal=�.+��� $��确认新密码��G� -	   $ 	newNewPwd��$	��200���� -
    ��Name$	 msg��
���  ��$y�Hidden=�