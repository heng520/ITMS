   M S B A M L   `   `   `  ����?  ;ITMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ITMS.Style.ThemesITMS.Style.Themes  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� MergedDictionaries �� Source   
UnCheckBox �� 
TargetType �� Property  FocusVisual �� Value  PrimaryHueMidBrush �� RelativeSource �� AncestorType �� Path ) %MaterialDesignValidationErrorTemplate �� 
TargetType	 � 	Resources  Key
 �� TargetProperty �� 
TargetName9   3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value �Name J� SnapsToDevicePixels � ColumnDefinitions F�Name  MaterialDesignCheckBoxOff A�Name
 �� Top �� Left J� Opacity J� RenderTransformOrigin J� IsHitTestVisible ��Name �� Triggers :� RoutedEvent 	 Click P� Property P� Value  OptionMarkFocusVisual �� 
TargetName " MaterialDesignCheckBoxDisabled 	 ValidationErrorBrush -
 )MoonGateThemesDataGridCheckBoxColumnStyle �� BasedOn 4 0MoonGateThemesDataGridCheckBoxColumnEditingStyle  MaterialDesignCheckBox  MoonGateThemesDataGridCell*  $System.Windows.Controls.DataGridCell �� Triggers  MaterialDesignTextBoxBorder  ]� 
Conditions! �� Property" �� Value  MaterialDesignSelection & "MoonGateThemesDataGridColumnHeader=  7System.Windows.Controls.Primitives.DataGridColumnHeader  MaterialDesignColumnHeader# �� Padding$ n�Name ) %MaterialDesignGridColumnHeaderGripper  MaterialDesignBody # MoonGateThemesDataGridRowHeader:  4System.Windows.Controls.Primitives.DataGridRowHeader% �� Orientation)  #System.Windows.Controls.DataGridRow  MoonGateThemesDataGridRow& ��Name?  9System.Windows.Controls.Primitives.SelectiveScrollingGrid' � RowDefinitions?  9System.Windows.Controls.Primitives.DataGridCellsPresenter(  Name)   
ItemsPanelA  ;System.Windows.Controls.Primitives.DataGridDetailsPresenter*   DetailsVisibility$+   SelectiveScrollingOrientation;  5System.Windows.Controls.SelectiveScrollingOrientation,   Vertical- �� ConverterParameter&	   System.Windows.Controls.DataGrid#. 	  RowDetailsScrollingConverter/ �� 	Converter7
  1System.Windows.Controls.DataGridHeadersVisibility
0 
  Row!1 	  HeadersVisibilityConverter  MoonGateThemesDataGrid2 ��Name3 	  SelectAllCommand4 �� 
ResourceId5 �� TypeInTargetAssembly
6 
  All  MaterialDesignDivider7 
  ColumnG  ASystem.Windows.Controls.Primitives.DataGridColumnHeadersPresenter8  Name9 ��Name: �� CanContentScroll; ��Name< �� ScrollableHeight= � Maximum> �� Orientation*? �� #ComputedVerticalScrollBarVisibility@ �� ViewportHeightA �� ViewportSizeB � ValueC �� ModeD �� ScrollableWidth,E �� %ComputedHorizontalScrollBarVisibilityF �� ViewportWidth�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     5      )localclr-namespace:ITMS.Style.Themes  5        5      �� 5   
   $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/materialdesigntheme.checkbox.xaml?�6   %�*  &	        7  7  7  7  &	
 �    7   &	     7  &	 b    &	 �    &	 �    &	 u    &	 �!    �� 5	      " ��6   .�5
   
   ��  �@�FocusVisualStyle8   6-   �� 5   
    � ��$ 1q�6,   �� 5   
    � ��$ Center=�65   �� 5   
    � ��# �  6'   �� 5   
    � ��# �  6(   �� 5   
    � �� 6'   ��  �� " �$ (TextElement.Foreground)��� 5   
    �@=�ErrorTemplate8  65   �� 5   
    � �� 5      �� 5      " ��6"   	 5      ���� 5      	Click .��5      U� $
 (FrameworkElement.Width)�6<   $ InteractionEllipse��6q   .\�5   "      $ 0��67   $ 0Q�6C      5   "   $ 0:0:0.3��67   $ 48Q�6I   5      U� 5      $
 (FrameworkElement.Height)�6<   $ InteractionEllipse��6r   .\�5   "      $ 0��67   $ 0Q�6C      5   "   $ 0:0:0.3��67   $ 48Q�6I   5      U� 5      $U
 O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6<   $ InteractionEllipse��6�   .\�5   "      $ 0��67   $ 0Q�6C      5    "   $ 0:0:0.3��67   $	 -24Q�6I   5!      U� 5"      $U
 O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6<   $ InteractionEllipse��6�   .\�5#   "      $ 0��67   $ 0Q�6C      5$   "   $ 0:0:0.3��67   $	 -24Q�6I   5%      U� 5&      $
 (UIElement.Opacity)�6<   $ InteractionEllipse��6l   .\�5'   "      $ 0��67   $	 0.3Q�6C      5(   "   $ 0:0:0.3��67   $ 0Q�6I   5)      5*      5+      .R�5,      � $ templateRoot��6   
������  .  5-      �� 5.      $
��Auto �6/   �� 5/      $��* �6/   .+�51      (� $��18��6"   $��18��6-   #��z��6:   $��LeftToRight=�52   "   .��53      �� $��24��6%   $��24��60   .+�54   "   F� $ Graphic��6'   �������!��- �@KL ��- �P[; ��- ��- P[; ��- @KL ���- ��!�@KL @o@ �� �� ���!@o@�@o@��! �� �� �@o@@KL �@o@P[; ��2��- ��!��- ���!@KL ���!��!�@KL ��!�@KL @KL ���!@KL 	#���  56   '   A� 57   "   $ InteractionEllipse��6*   #��z��6F   $��0��6j   $��0��6t   $ 12��6   $ 12��6�   $ 0Q�6�   $ 0.5,0.5&�6�    .  z�59   &   V� 5:   *   .~�5;   .   �� �� 5<   .   �� 5=   .   T� 5>   .   5?   +   5A   #   5B      5C      �� 5D      $ contentPresenter��6+   $��1��6E   |�.  #��z��6g   #��z��6�   ��. # z 6�   #��z��6$  5E       5F      :� 5G      $ ButtonBase.Click��6'   .[�5H      �� 8�� 6.   5I      P� 5J       � �� . . �5K      �� 8   �@�FocusVisualStyle6A   �� 5L       � ��$ 4,2,0,0q�68   5M      P� 5N       � �� . 67   P� 5O       �@d�	IsChecked$
 trueY�67   . �5P      �� $ Graphic��65    � ��� �Ѐ�� @f�@KL  � ��a  p� р�� �7� ��f gd ���! z ���!��- �@KL ��- �P[; ��- ��- P[; ��- @KL ���- ��!�@KL @o@ �� �� ���!@o@�@o@��! �� �� �@o@@KL �@o@P[; ��2��- ��!��- 	6J   �� 5Q      $ Graphic��65    6J   ��  �� *TemplatedParent+$ 
Background� � ��5R      P� 5S       � {� .  . �5T      �� $ Graphic��65   # �  6J    � ���� 5U       �@J�Opacity$
 0.56Q�68   5V      P� 5W       67   Z�  �@d�	IsChecked. �5X      �� $ Graphic��65    � ��� �Ѐ�[ @]� р�[ �ا р��ا р�@]� ���!��- �@KL ��- �P[; ��- ��- P[; ��- @KL ���- ��!�@KL @o@ �� �� ���!@o@�@o@��! �� �� �@o@@KL �@o@P[; ��2��- ��!��- 	6J   �� 5Y      $ Graphic��65    6J   ��  �� *TemplatedParent+$ 
Background� � ��5Z      P� 5[       �@=�HasError . . �5\      �� $ Graphic��65   # � 	 6J    � ���� 5]      $ contentPresenter��6C   # � 	 6a    � ��5^      5`      5b      5c      �� 5d      " ��6>   8   .�5e   
   ��  � ��$ Center=�60   5j      �� 5l      " ��6E   8   .�5m   
   ��  � ��$ Center=�60   5n      �� 5o      "  6/   .�5p   
   ��  � ��$ 16(�6/   �� 5r   
    � ��
 ���� 6'   �� 5s   
    � ��
 ���� 6(   �� 5t   
    � ��$ 0q�6,   �� 5u   
    �@ 	IsEditing . 6&   �� 5v   
    � ��$ Center=�60   �� 5w   
    � ��$ Bottom=�6.   �� 5x   
    � �� 5y      �� 5z      "  6"   .R�5{      �� #��z��6   #��z��6I   #��z��6}    . ._�5|      �� # z 6+   #��z��5}   +   5~      5      5�       5�   
   P� 5�       �@J�IsKeyboardFocusWithin . . �5�      ��  � ��# �  60   5�      ]� 5�        5�      �� 5�      ! �@ 
IsSelected" . 66   �� 5�      ! �@��IsSelectionActive" .  6F   ./�5�      ��  � ��# �  6/   5�      ]� 5�        5�      �� 5�      ! �@ 
IsSelected" . 66   �� 5�      ! �@��IsSelectionActive" . 6F   ./�5�      ��  � �� �#408CFF6/   �� 5�       � �� �#EFF4FF6/   5�      P� 5�       � {� .  . �5�      ��  �@J�Opacity$	 .56Q�6,   5�      5�      �� 5�      "  67   .�5�   
   ��  � ��$ Center=�65   �� 5�   
    � ��$ 12(�6/   �� 5�   
    � ��$ Medium"�61   �� 5�   
    � ��$ Right=�67   �� 5�   
    � ��$ Center=�60   �� 5�   
    � �� �#E3F3FF6'   �� 5�   
    � ��# �  6'   �� 5�   
    � �� 5�      �� 5�      "  6"   	 5�      ���� 5�      GoToVisible .��5�      U� $ SortDirectionIndicator��6<   $
 Width�6k   .\�5�   "      $ 0:0:0.0��67   $ 0Q�6I      5�   "   $ 0:0:0.2��67   $ 12Q�6I   5�      5�      �� 5�      
GoToHidden .��5�      U� $ SortDirectionIndicator��6<   $
 Width�6k   .\�5�   "      $ 0:0:0.0��67   $ 12Q�6I      5�   "   $ 0:0:0.2��67   $ 0Q�6I   5�      5�      5�      .R�5�      � ���#E3F3FF.+�5�      �� #��z��6!   #��z��6M   #��z��6�   ## z��6�   ._�5�      �  5�   "   �� 5�   &   $
��Auto �67   �� 5�   &   $��* �67   .+�5�   "   �� $��1��63   #��z��6D   $��Center=�6g   5�      5�      n� 5�      $$ PART_LeftHeaderGripper��6    $
��Left=�6@   #���  6[   n� 5�      $$ PART_RightHeaderGripper��6    $��Right=�6A   #���  6]   5�       5�      P� 5�       �@J�IsMouseOver . . �5�      �� # �  6;    � ��5�      P� 5�       �@ SortDirection$ 	AscendingX�6;   . �5�      �� # �  6;    � ��5�      P� 5�       �@ SortDirection$ 
DescendingX�6;   . �5�      �� # �  6;    � ��5�      5�      5�      5�      �� 5�      "  64   .�5�   
   ��  � ��$ 10��6#   �� 5�   
    � ��$ Center=�60   �� 5�   
    � �� �#E3F3FF6'   �� 5�   
    � �� 5�      �� 5�      "  6"   .R�5�      � $	��100��6   .+�5�      �� #��z��6!   #��z��6M   #��z��6�   ## z��6�   ._�5�      �� $% 
Horizontal=�6)   .+�5�   "   �� ��. # z 6N   $��Center=�6�   $��Center=�6�   �� 5�   "    .  ��6F   �� *ValidationErrorTemplate+ �� "  5�      5�      n� 5�      $$ PART_LeftHeaderGripper��6    $
��Left=�6@   #���  6[   n� 5�      $$ PART_RightHeaderGripper��6    $��Right=�6A   #���  6]   5�      5�      5�      5�      �� 5�      "  6.   .�5�   
   ��  � ��
 ���� 6'   �� 5�   
    �@J�SnapsToDevicePixels . 60   �� 5�   
    �@=�ErrorTemplate 65   Z� �� 5�   
    � ��$ Center=�6.   �� 5�   
    �@ ValidationErrorTemplate 5�      �� 5�      .R�5�      �� ���#d50000$��2,0,0,0q�65   $��!��6F   $��Center=�6O   5�      5�      �� 5�   
    � �� 5�      �� 5�      "  6"   .R�5�      �� $& 
DGR_Border��6   #��z��61   #��z��6]   #��z��6�    . ._�5�         5�      �� 5�   "   $
��Auto �63   �� 5�   "   $��* �63   ' 5     �� 5  "   $��* �60   �� 5  "   $
��Auto �60   .+�5       $( cellpre��6�   $��1��65   #��z) 6E   # z 6o   6�     5     $��1��67   $��1��6G   #y�z* 6k  + 6T   �� *AreRowDetailsFrozen+#- Z, #/ Z.  �� " 	 6k    5     $��2��60   $+ Vertical=�6A   y�6�   �� *HeadersVisibility+#- Z0 #/ Z1  �� " 	 5     5	     5
     5      5  
   P� 5      �@ 
IsSelected . . �5     ��  � �� �#EFF4FF6/   5     P� 5      �@J�IsMouseOver . . �5     ��  � �� �#EFF4FF6/   5     P� 5      �@ 	IsNewItem . . �5     ��  � �� 6+   �� *NewItemMargin+ �� " 	 5     5     �� 5     " 	 6+   .�5  
   ��  � �� �#FFFFFF6'   �� 5  
    � ��# �  6'   �� 5  
    � �� �#EEEEEE6(   �� 5  
    � ��$ 	0 0 0 0.5q�6,   �� 5  
    � ��$ 15(�6%   �� 5   
     �@	 RowDetailsVisibilityMode$ VisibleWhenSelected=�65   �� 5!  
    �@	 HeadersVisibility$ Column=�6.   �� 5"  
    � �� . 6:   �� 5#  
    �@��PanningMode$
 Both=�65   �� 5$  
    �@��IsFlicksEnabled .  63   �� 5%  
     �@	 HorizontalGridLinesBrush# �  65   �� 5&  
    �@	 	RowHeight$ 35Q�6&   �� 5'  
    � �� 5(     �� 5)     " 	 6"   .R�5*     �� #��z��6   #��z��6I   #��z��6}   ## z��6�    . ._�5+     �� $2 DG_ScrollViewer��6'   |�.  ��5,     �� 5-  "   " ��62   .R�5.  &   �  5/  *   �� 50  .   $
��auto �6?   �� 51  .   $��* �6?   �� 52  .   $
��auto �6?   ' 54  *   �� 55  .   $
��auto �6<   �� 56  .   $��* �6<   �� 57  .   $
��auto �6<   .+�5:  *   �� #��Z3 61   |�.  ��6r   C� *�� $"4 DataGridSelectAllButtonStyle��"5 	 +y�6�   �� *HeadersVisibility+#- Z6 #/ Z1  �� " 	 ��6�  �� *CellsPanelHorizontalOffset+ �� " 	 �� 5;  *   $��0 0 0 1q�61   #���  6L   $��1��6�   y�6�   �� *HeadersVisibility+#- Z7 #/ Z1  �� " 	 ._�5<  .     $!8 PART_ColumnHeadersPresenter��6M   5=  +   �� 5?  *   $!9 PART_ScrollContentPresenter��6A   #: z��6f   $��2��6�   $��1��6�   �� 5A  *   $; PART_VerticalScrollBar��64   $��2��6T   #= z< 6d   $> Vertical=�6�   $��1��6�   #y�z? 6�   #A z@ 6W  B 6�   �� *VerticalOffset+$C OneWay=� �� *TemplatedParent+6W  � 5B  *   $��1��6/   $��2��6?    5C  .   �� 5D  2   ��6C   �� **(NonFrozenColumnsViewportHorizontalOffset+ �� " 	 �� 5E  2   $��* �6C   .+�5H  .   �� $; PART_HorizontalScrollBar��68   $��1��6Z   #= zD 6j   $> 
Horizontal=�6�   #y�zE 6�   #A zF 6U  B 6�   �� *HorizontalOffset+$C OneWay=� �� *TemplatedParent+6U  5I  +   5J  '   5K  #   .��5M     �� # z 6-   5N     5O     5P     5R     5S     5T     