   M S B A M L   `   `   `  ���� ?  ;ITMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ITMS.View	ITMS.View  'clr-namespace:ITMS.Style
ITMS.Style  U QVlc.DotNet.Wpf, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84529da31f4eb963G4clr-namespace:Vlc.DotNet.Wpf;assembly=Vlc.DotNet.WpfVlc.DotNet.Wpf     ITMS.View.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:ITMS.View     +themesclr-namespace:ITMS.Style     Dvlc4clr-namespace:Vlc.DotNet.Wpf;assembly=Vlc.DotNet.Wpf     -     � WindowStyle$
  None=� � WindowStartupLocation$ CenterScreen=� � WindowState$ 	Maximized=� � Title$ 
MainWindow��$
��1080��$
��1920������  �� ImageSource$% /ITMS;component/Resource/bg.png�� j� Stretch$
 Fill=� � 	Resources  �� 
TargetType �� Property	 �� Value
 �� 
TargetType �� CornerRadius�� %�   '��       �� " ��.���  � ��$	 57����  � ��$	 131.6����  � ��$	 18(���  �@�Cursor$
	 Hand����  � ��	 �#FFFFFF��  � ��	 �� "
 ��.R��� $ 10��#��z��#��z��#��z��._��� $��Center=�$��Center=�.���  � RowDefinitions �� $	��101 ��� .+��� $)��#/ITMS;component/Resource/header.png��$
��Fill=�$
��90 0q�� .+��� -    ��Name$ MinimizeButton��$	����   	windowBtn#��[      ITMS.Style.UniversalWindow   TitleBarButtonState$ 	MinimizedX����#FFFFFF�� -   $ RestoreButton��$	����#��[  $ NormalX����#FFFFFF�� -   $ CloseButton��$	����  Style.Button.Close#��[    IsTitleBarCloseButton . ���#FFFFFF� $��1�� � ColumnDefinitions �� $	��336 ��� �� $	��336 �.+�� $��1��.+�  Vlc.DotNet.Wpf.VlcControl  -     Name$ 	myControl��$	��400��$	��320��