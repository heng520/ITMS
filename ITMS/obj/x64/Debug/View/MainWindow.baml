   M S B A M L   `   `   `  ����?  ;ITMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ITMS.View	ITMS.View  5   	   'clr-namespace:ITMS.Style
ITMS.Style  5   	   5clr-namespace:ITMS.Style.ThemesITMS.Style.Themes  62   U QVlc.DotNet.Wpf, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84529da31f4eb963G4clr-namespace:Vlc.DotNet.Wpf;assembly=Vlc.DotNet.WpfVlc.DotNet.Wpf 5   	       ITMS.View.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ITMS.View     5   	   +themesclr-namespace:ITMS.Style     5   	   1vidioclr-namespace:ITMS.Style.Themes     62   Dvlc4clr-namespace:Vlc.DotNet.Wpf;assembly=Vlc.DotNet.Wpf     5   	   -   5          � WindowStyle$
  None=�5	       � WindowStartupLocation$ CenterScreen=�6-    � WindowState$ 	Maximized=�6i    � Title$ 
MainWindow��5
   	   $
��1080��6   $
��1920��6*   ��5      �� 5   
    �� ImageSource$% /ITMS;component/Resource/bg.png��6    j� Stretch$
 Fill=�6C    � 	Resources 5       �� 
TargetType �� Property	 �� Value
 �� 
TargetType �� CornerRadius�� 5   
   %�  '��       �� 5      " ��6   .�5      ��  � ��$	 57��6+   �� 5       � ��$	 131.6��6*   �� 5       � ��$	 18(�6-   �� 5       �@�Cursor$
	 Hand��6+   �� 5       � ��	 �#FFFFFF60   �� 5       � ��	 5      �� 5      "
 ��6*   .R�5      �� $ 10��6%   #��z��67   #��z��6a   #��z��6�   ._�5   "   �� $��Center=�63   $��Center=�6P   5      5      5      5       5"      .��5%      �  � RowDefinitions 5&   
   �� 5'      $	��101 �6   �� 5(      .+�5*   
   �� $)��#/ITMS;component/Resource/header.png��6   $
��Fill=�6=   $
��90 0q�6L   �� 5+   
   $��红外测温客户端��6   $��48(�6"   ���#FFFFFF$��Center=�6E   $��Center=�6b   $��FZZDHJW--GB1-0)�6}   � 5,   
    � ColumnDefinitions 5-      �� 5.      �� 5/      $	��400 �6$   .+�51      ��  �� Orientation$ 
Horizontal=�6   $��1��62   $��Right=�6B   $	��Top=�6^    52      ��%�  '��       �� 53      " ��6   .�54      ��  � ��$	 46��62   �� 55       � ��$	 46��63   �� 56       � ��$	 20(�65   �� 57       � ��$	 0q�6<   �� 58       � ��	 �#2D7DFF67   �� 59       � ��
	 ���� 67   �� 5:       � ��	 5;      �� 5<   "   "
 ��62   .R�5=   &   �� $��
OverBorder��6-   $��0q�6?   ._�5?   *   �� $*��$/ITMS;component/Resource/manager.png��60   $��20��6^   $��20��6j   5A   '   5B   #   5D      5E      5F      .+�5H      �� �� 5I      -   5         ��Name$ MinimizeButton��5I      $	����61      	windowBtn#��[  6E       ITMS.Style.UniversalWindow   TitleBarButtonState$ 	MinimizedX�6h   ���#FFFFFF6�   �� 5J      -   5        $ RestoreButton��5J      $	����60   #��[  6D   $ NormalX�6g   ���#FFFFFF6�   �� 5L      -   5        $ CloseButton��5L      $	����6.     Style.Button.Close#��[ 6B      IsTitleBarCloseButton . ���#FFFFFF6�   5M      5P      � 5Q   
   $��1��6    5R      �� 5S      $	��336 �6#   �� 5T      �� 5U      $	��336 �6#   .+�5W      �  5X      �� 5Y      $	��200 �6$   �� 5Z      �� 5[      $	��210 �6$    5]      �� 5^      $��52 �6'   �� 5_      .+�5a      �� $+��%/ITMS;component/Resource/leftLine.png��6   $��2��6G   $
��Fill=�6X   � 5b      $��1��6   $��Bottom=�6(   $	��148��6C   $	��260��6P   $
��Left=�6\   ��5c      �� 5d      $' !/ITMS;component/Resource/user.png��6%    5f      �� 5g      $	��105 �6(   �� 5h      .+�5j      �� $��	26 10 0 0q�6!   $
��Left=�64   $ 
Horizontal=�6O   $��Center=�6h   .+�5k      �� $,��&/ITMS;component/Resource/headerimg.png��6    $��45��6P   $��45��6[   �� 5l      $��admin��6    $��24(�60   ���#FFFFFF$��Center=�6S   $��15 0 0 0q�6n   5m      �� 5n      $ 
Horizontal=�6!   $��1��6:   $��20 0 0 0q�6G   $	��Top=�6Y   .+�5o      ��    ITMS.Style.ImageButton   BackImg$- '/ITMS;component/Resource/passwodimg.png��6!     
LeftImgBtn#��[ 6f   $��修改密码��6�   �� 5p      $' !/ITMS;component/Resource/exit.png��6!   #��[ 6`   $��修改密码��6�   $��20 0 0 0q�6�   5q      5t      �� 5w      $��1��6   $	��Top=�6+   $��1��6C    5x        HomeBtn �� BasedOn��%)  '��       7  �� 5y      " ��6    8   .�5z      ��  �@ BackImg$*	 $/ITMS;component/Resource/leftbtn.png��6K   �� 5{       �@ BackImgClick$/	 )/ITMS;component/Resource/leftbtnClick.png��6P   �� 5|       � ��$
	 Left=�6D   �� 5}       � ��$
	 0 16q�67   5~      5      .+�5�      �� $��预览��6   $��	0 30 0 16q�6+   �� 5�      -   5        $ equipManager��5�   -   $��设备管理��6   6C   �� 5�      $��预览��6   �� 5�      $��预览��6   5�      � 5�      $��1��6   $��2��6'   $	��Top=�65   $	��180��6M   $	��260��6Z   $
��Left=�6f   ��5�      �� 5�      $' !/ITMS;component/Resource/user.png��6%    5�      �� 5�      �� 5�      .+�5�      �� $ 
Horizontal=�6"   $��Center=�6;   $��	 0 20 0 0q�6V   .+�5�      �� $'��!/ITMS;component/Resource/img1.png��6    $��58��6K   $��49��6V   $��22 0 0 0q�6b   �� 5�      $'��!/ITMS;component/Resource/img4.png��6    $��58��6K   $��49��6V   $��22 0 0 0q�6c   �� 5�      $'��!/ITMS;component/Resource/img6.png��6    $��58��6K   $��49��6V   $��22 0 0 0q�6b   5�      �� 5�      $ 
Horizontal=�6"   $��Center=�6;   $��1��6V   .+�5�      �� $'��!/ITMS;component/Resource/img8.png��6    $��58��6K   $��49��6V   $��22 0 0 0q�6b   �� 5�      $'��!/ITMS;component/Resource/img9.png��6    $��58��6K   $��49��6V   $��22 0 0 0q�6c   �� 5�      $*��$/ITMS;component/Resource/imgmore.png��6    $��58��6N   $��49��6Y   $��22 0 0 0q�6e   5�      5�      5�      � 5�      $��1��6    5�      �� 5�      $��40 �6$   �� 5�      �� 5�      $	��150 �6$   .+�5�      �� $��
2020-03-24��6   $��30(�6-   $��Center=�6;   ���#FFFFFF6X   $   ITMS.Style.Themes.VideoControl  5�      -   5          Name$ 	myControl��5�   2   $��1��6%   62   5�      � 5�      $��2��6   $��10 50 34 28q�6#   .+�5�      �� $0��*/ITMS;component/Resource/equipmentlist.png��6   $
��Fill=�6L   5�      5�      5�      5�      