   M S B A M L   `   `   `  ���� ?  ;ITMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ITMS.View	ITMS.View      ITMS.View.UpdateEquip   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     U QMaterialDesignThemes.Wpf, Version=3.1.0.981, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  #localclr-namespace:ITMS.View    � 	Resources   �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius �Name ��Name J� SnapsToDevicePixels	 �� Triggers
 �� MergedDictionaries �� Source�� 
 �� $f `pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Button.xaml?�%l  '��       �� " ��.���  � �� �#20A3F5��  � ��$ 1q���  � ��$	 200����  � ��$ 33����  � �� �#0e3e82��  � �� �#999999��  � ��$ 15(���  � ��$ 10 0 0 0q���  � �� �� " ��.R��� #��z��#��z��$ 3��._�� $ PART_InnerGrid��.+��� $ PART_ContentHost��# z $��Center=�	 .���� ���#EEEEEE$��1q�$ 5�����#FFFFFF._�� -   $
 grid�� � RowDefinitions �� $��50 ��� �� $��50 �.+��� ���#e9eaec$�� 0 0 0 1q�$ 5 5 0 0��._�]� .+��� -    ��Name$ header��$��8 0 0 0q�$��Center=�$��修改设备参数��$��16(��� -    ��Name$ msgLabel��$��Center=�$��50 0 0 0q�
���  ���� $��Right=�$��Center=�)  #MaterialDesignThemes.Wpf.DialogHost   CloseDialogCommand#��Z ���#b2b2b2 &  "MaterialDesignToolForegroundButton#��[  .��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ WindowClose=��� $��2�����#e9eaec$�� 0 1 0 0q�._���  �� Orientation$ 
Horizontal=�$��Right=�$
��10 0q�.+��� -    ��Name$ OkButton��$��确 定�� �� 	IsDefault . ���#2983f6���#FFFFFF  Blue#��[ $y�Visible=��� -   $ CancelButton��$��取消�� 
 Cancel#��[ #��Z ���#CDCDCD���#FFFFFF���#FFFFFF$y�Visible=�� -   $ equiment��$��1�� �� �� .+��� ���#EEEEEE$��0 0 0 1q�� $��10q� �� $��30 ���  � ColumnDefinitions �� �� .+��� $��摄像机参数��$��Center=�$��15(��� -    ��Name$ carportDetailModel��$��1��.+��� $ 
Horizontal=�$��0 10 0 0q�.+��� $��	相机IP:��$��Center=�$��14(�$��0 0 10 0q��� -    ��Name$ carportNumber��$��14(����� *
CameraIp+�� $ 
Horizontal=�$��0 10 0 0q�.+��� $��
用户名:��$��Center=�$��14(�$��	 0 0 10 0q��� -	   $ carportUser��$��14(����� *
CameraUser+�� $��1��$��1��.+��� $ 
Horizontal=�$��0 10 0 0q�.+��� $��相机名称:��$��Center=�$��14(�$��0 0 10 0q��� $��14(����� *
CameraName+�� $ 
Horizontal=�$��0 10 0 0q�.+��� $��       密码:��$��Center=�$��14(�$��	 0 0 10 0q��� $��14(����� *CameraPassword+�� ���#EEEEEE$��0 0 0 1q�$��1��._�� $��10q� �� $��30 ���  �� �� .+��� $��红外参数��$��Center=�$��15(��� $��1��.+��� $ 
Horizontal=�$��0 10 0 0q�.+��� $��	红外IP:��$��Center=�$��14(�$��0 0 10 0q��� $��14(����� *RayIp+�� $ 
Horizontal=�$��0 10 0 0q�.+��� $��
用户名:��$��Center=�$��14(�$��	 0 0 10 0q��� $��14(����� *	RayUser+�� $��1��$��1��.+��� $ 
Horizontal=�$��0 10 0 0q�.+��� $��红外名称:��$��Center=�$��14(�$��0 0 10 0q��� $��14(����� *	RayName+�� $ 
Horizontal=�$��0 10 0 0q�.+��� $��       密码:��$��Center=�$��14(�$��	 0 0 10 0q��� $��14(����� *RayPassword+�� ���#EEEEEE$��0 0 0 1q�$��2��$y�	Collapsed=�._�� $��10q� �� $��30 ���  �� �� .+��� $��设备参数��$��Center=�$��15(��� $��1��.+��� $ 
Horizontal=�$��0 10 0 0q�.+��� $��设备名称:   ��$��Center=�$��14(�$��0 0 10 0q��� $��14(����� *
deviceName+�� $ 
Horizontal=�$��0 10 0 0q�.+��� $��安装机构号:��$��Center=�$��14(�$��	 0 0 10 0q��� $��14(����� *	orgCode+�� $��1��$��1��.+��� $ 
Horizontal=�$��0 10 0 0q�.+��� $��设备型号:��$��Center=�$��14(�$��0 0 10 0q��� $��14(����� *
deviceType+�� $ 
Horizontal=�$��0 10 0 0q�.+��� $��设备位置:��$��Center=�$��14(�$��	 0 0 10 0q��� $��14(����� *
location+