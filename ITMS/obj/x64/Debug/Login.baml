   M S B A M L   `   `   `  ����?  ;ITMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ITMSITMS  5   	   'clr-namespace:ITMS.Style
ITMS.Style  5          
ITMS.Login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:ITMS     5   	   +themesclr-namespace:ITMS.Style     5      -   5          � WindowStyle$
  None=�5       � WindowStartupLocation$ CenterScreen=�6-    � 
ResizeMode$ NoResize=�6R    � AllowsTransparency .  J� OpacityMask
 ����� � Title$ Login��5	   	   $	��492��6   $	��538��6$   ��5
      �� 5   
    �� ImageSource$* $/ITMS;component/Resource/loginbg.png��6   .��5      ��  �� CornerRadius$ 10��6   $��0q�6   ._�5   
   �  � RowDefinitions 5      �� 5      $��50 �6    �� 5      �� 5      $��50 �6    .+�5      �� -   5        	 ��Name$	 CloseButton��5   1   $��Right=�6   $	����6F      Style.Button.Close#��[  6Z       ITMS.Style.UniversalWindow
   IsTitleBarCloseButton
 . ���#FFFFFF6�   � 5      $��1��6    5      �� 5      $��2* �6$   �� 5      $��1* �6$   �� 5      $
��2.5* �6$   �� 5      .+�5      �� $-��'/ITMS;component/Resource/loginframe.png��6   $��4��6I   $��0 0 0 10q�6Z   �� 5      $��测温客户端��6   $��30(�6(   ���#EFFAFF$��Center=�6K   $��Bottom=�6h   $��HYXiaoBoZheZhiTiJ)�6�   �� 5      -   5        $��4��5      $	��260��6&   $��50��62   $��Bottom=�6>   $��登录��6Y   ��5!      �� 5"       �� 
TargetType" ��6    .�5#      ��  �� Property � �� �� Value$ 20(�69   �� 5$       � �� �#FFFFFF6;   �� 5%       �@�Cursor$
 Hand��67   �� 5&       � �� 5'   "   �� 5(   &    �� 
TargetType" ��66   .R�5)   *   �� $ 4��61   ��5*   .   �� 5+   2    �� 
StartPoint$	 0,0&�6F    �� EndPoint$	 0 1&�6W   .��5,   6   �  � Color$ #006CFF��6C    � Offset$	 0.5Q�6S   � 5-   6   $ #70BAFF��6C   $ 0Q�6S   5.   3   ._�50   .   �� $��Center=�6?   $��Center=�6Z   51   +   52   '   54      55      57      � 58      $��2��6    59      �� 5:      �� 5;      .+�5>      �� -   5         ��Name$ 帐户��5>   6   $	��260��6   $��50��6*   ��6B   �� *
userName+�� 5?      -   5        $ 密码��5?   D   $��1��6   $	��260��6+   $��50��67   ��6P   �� *
password+5@      5A      5D      5E      5F      