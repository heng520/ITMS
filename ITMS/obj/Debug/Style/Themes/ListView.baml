   M S B A M L   `   `   `  ����?  ;ITMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ITMS.Style.ThemesITMS.Style.Themes  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� 
TargetType �� Property �� Value $   DefaultGridViewScrollViewerStyle �� BasedOn �� 
TargetType J� SnapsToDevicePixels � ColumnDefinitions � RowDefinitions ��Name	 �� AllowsColumnReorder
 �� RelativeSource! �� ColumnHeaderContainerStyle �� ColumnHeaderToolTip �� ColumnHeaderStringFormat �� ColumnHeaderContextMenu �� ColumnHeaderTemplate �� Columns# �� ColumnHeaderTemplateSelector ��Name �� CanContentScroll-   'System.Windows.Input.KeyboardNavigation    DirectionalNavigation ��Name � Cursor �� ScrollableWidth � Maximum � Minimum �� Orientation, �� %ComputedHorizontalScrollBarVisibility �� ViewportWidth �� ViewportSize � Value �� Mode  �� ScrollableHeight*! �� #ComputedVerticalScrollBarVisibility" �� ViewportHeight# �� Triggers$ �� Binding% �� ElementName& �� Value' �� 
TargetName  DefaultListViewItem( ��Name) �Name* ��Name+ P� Value, P� Property ' #NonSelectableListViewContainerStyle  ItemMouseOverBackground  ItemMouseOverForeground- �� Triggers % !ItemsAlternationContentBackground  DefaultListView  GridViewColumnHeaderGripper. �� Padding  DefaultGridViewColumnHeader/ J� IsHitTestVisible0 �� CornerRadius1 n�Name2 � ActualWidth3 � ActualHeight�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     5      )localclr-namespace:ITMS.Style.Themes  5      %&  '��       &	  �     7$�&	 ;	    &	 u    7  7  7  &	 �    7  7   &	 g    &	 �    7  �� 5      "  ��6   .�5   
   ��  � �� �#031E6B6'   �� 5   
    � ��$ 30��6#   �� 5   
    � �� �#FFFFFF6'   �� 5   
    � ��$ 15(�6%   �� 5	   
    � ��$ 0q�6,   5
      �� 5      "  ��65   8   .�5   
   ��  � |� .  6&   �� 5   
    � �� 5      �� 5      " ��6"   .R�5      � #��z��6    .  5      �� 5      $��* �6/   �� 5      $
��Auto �6/    5      �� 5      $��* �6,   �� 5      $
��Auto �6,   .+�5      ]� #��z��6$   .+�5      �� $	��Top=�6+   |�.  $��Hidden=�6R   $��Hidden=�6y   .��5   "   �� $ PART_Header��5$   ]   $��0q�6=   $y�Visible=�6H   $
��auto��6r   # z 5%   =   	 5   =   �� **(TemplatedParent.View.AllowsColumnReorder+
 �� *TemplatedParent+ 5   =   �� *1/TemplatedParent.View.ColumnHeaderContainerStyle+
 �� *TemplatedParent+ 5   =   �� **(TemplatedParent.View.ColumnHeaderToolTip+
 �� *TemplatedParent+ 5   =   �� */-TemplatedParent.View.ColumnHeaderStringFormat+
 �� *TemplatedParent+ 5    =   �� *.,TemplatedParent.View.ColumnHeaderContextMenu+
 �� *TemplatedParent+ 5!   =   �� *+)TemplatedParent.View.ColumnHeaderTemplate+
 �� *TemplatedParent+ 5"   =   �� *TemplatedParent.View.Columns+
 �� *TemplatedParent+ 5#   =   �� *31TemplatedParent.View.ColumnHeaderTemplateSelector+
 �� *TemplatedParent+5%   =   5&      �� 5'      $! PART_ScrollContentPresenter��65   # z��5(   5   #��z��5)   5   #��z��5*   5   $ Local=�5+   5   # z 5,   5   5-      �� 5.      $ PART_HorizontalScrollBar��6$   $ Arrow��6F   # z 6U   $	 0.0Q�5/   $   $ 
Horizontal=�62   $��1��6K   #y�z 50   $   # z 52   $    51   $   �� *HorizontalOffset+$ OneWay=�
 �� *TemplatedParent+52   $   �� 53      $ PART_VerticalScrollBar��6$   $ Arrow��6D   $��1��6S   # z  6c   $	 0.0Q�54   $   $ Vertical=�62   #y�z! 55   $   # z" 57   $    56   $   �� *VerticalOffset+$ OneWay=�
 �� *TemplatedParent+57   $   58      # 59      �� 5:      $ 6&   �� *	Columns+$% PART_Header��& 6[   Z� .a�5;      �� $' PART_Header��6;    � y�$ 	Collapsed=�6T   6h   5<      5>      5@      5A      �� 5D      "  ��6(   .�5E   
   ��  � �� �#FFFFFF6'   �� 5F   
    � ��$ Stretch=�67   �� 5G   
    � ��$ Center=�65   �� 5H   
    � ��$ 25��6&   �� 5I   
    � ��$ 0q�6#   �� 5J   
    �@J�SnapsToDevicePixels . 60   �� 5K   
    � ��
 ���� 6=   �� 5L   
    � ��$ 3,0,0,0q�6$   66   �� 5M   
    � �� 5N      �� 5O      " ��6"   .R�5P      �� $( Bd��6   #��z��6)    . #��z��6n   ._�5Q      � $) 	PART_Root��6   #��z��62   .+�5R      �� #��z��63   �� 5S      $* contentPresenter��6/   #��z��6I   $y�	Collapsed=�6�   5T      5U      # 5V      P� 5W      + 6G   Z� , �@��ColumnCollection. �5X      �� $' contentPresenter��6%    � y�$ Visible=�6Y   5Y      5w      5y      5z      �� 5}      "  ��68   .�5~   
   ��  � �� �#FFFFFF6'   �� 5   
    � ��$ Stretch=�67   �� 5�   
    � ��$ Center=�65   �� 5�   
    � ��$ 25��6&   �� 5�   
    � ��$ 0q�6#   �� 5�   
    �@J�SnapsToDevicePixels . 60   �� 5�   
    � ��
 ���� 6=   �� 5�   
    � ��$ 3,0,0,0q�6$   66   �� 5�   
    � �� 5�      �� 5�      " ��6"   .R�5�      �� $( Bd��6   #��z��6)   #��z��5�       . ._�5�      �� #��z��6/   5�      # 5�      P� 5�      , �@J�IsMouseOver+ . . �5�      �� $' Bd��6%   8    � ��6K   �� 5�      8   � ��6;   5�      5�      5�      - 5�   
   P� 5�      , �@��AlternationIndex$+ 0��6?   . �5�      ��  � ��
 ���� 6/   5�      P� 5�      , �@��AlternationIndex$+ 1��6?   . �5�      ��  � ��8  6/   5�      5�      �� 5�      "  ��6$   .�5�   
   ��  � �� �#23338d6(   �� 5�   
    � �� �#FFFFFF6'   �� 5�   
    � ��$ 0q�6,   �� 5�   
    � ��$ 15(�6%   �� 5�   
    � �� �#FFFFFF6'   �� 5�   
    � �� . 6:   �� 5�   
    �@%�IsVirtualizing . 6Q   �� 5�   
    �@%�VirtualizationMode$ 	Recycling=�6F   �� 5�   
   " �@��IsDeferredScrollingEnabled .  6D   �� 5�   
    �@��AlternationCount$ 2��6-   �� 5�   
    �@J�SnapsToDevicePixels . 60   �� 5�   
    �@�OverridesDefaultStyle . 62   �� 5�   
    � ��$
 Auto=�6G   �� 5�   
    � ��$
 Auto=�6E   �� 5�   
    � ��$ Center=�65   �� 5�   
    �@��SelectionMode$ Single=�6*   �� 5�   
    � ��8   6^   �� 5�   
    � �� 5�      �� 5�      " ��6"   .R�5�      �� $( Border��6   #��z��6-   #��z��6W   #��z��5�       . ._�5�      �� #��z��6'   8�� .��5�      �� 5�      5�      # 5�      P� 5�      , �@��
IsGrouping+ . . �5�      ��  � �� .  6N   5�      5�      5�      5�      �� 5�      "  n�60   .�5�   
   ��  � ��$ 18��6"   �� 5�   
    � �� �#23338d6'   �� 5�   
    � �� 5�      �� 5�      " n�6"   .R�5�      �� #. z��6   
������ $��0 0 0 2q�6Z   ._�5�      �� $��1��6$   #��z��6.   $��Center=�6R   5�      5�      5�      5�      �� 5�      "  ��60   .�5�   
   ��  � �� �#FFFFFF6'   �� 5�   
    � �� �#23338d69   �� 5�   
    �@J�SnapsToDevicePixels . 60   �� 5�   
    � ��$
 Left=�67   �� 5�   
    � ��$ Center=�65   �� 5�   
    � ��$ 4 2 4 2q�6$   �� 5�   
    � ��$ 26��6&   �� 5�   
    � ��$ 80��6#   �� 5�   
    � ��$ 0,0,0,3q�6,   �� 5�   
    � �� �#23338d6(   �� 5�   
    � �� 5�      �� 5�      " ��6"   .R�5�      � .+�5�      �� 
������ / . 67   �� 5�      $( HeaderBorder��6!   #. z��67   #��z��6[   $0 4��6�   #��z��5�   !   #��z��6U   ._�5�      �� $* HeaderContent��6/   #��z��6F   #��z��5�   /   $��5,1,5,1q�6c   #��z��5�   /   #��z��5�   /   ��. # z 5�   /   5�      n� 5�      $1 PART_HeaderGripper��6    $��Right=�6<   $��0,0,-9,0q�6X   8��  6j   5�      # 5�      P� 5�      , � ��+ . . �5�      �� $' HeaderContent��6%    � ��$ 6,1,6,1q�6R   5�      P� 5�      , � {�+ .  . �5�      �� # � ��6;    � ��5�      5�      5      �� 5  
    � �� 5     �� 5     .R�5     �� $��SemiBold"�6    ��6@   �� 5     5     - 5  
   P� 5
     , �@��Role$+ Floating=�6&   . �5     ��  �@J�Opacity$	 0.7Q�6,   �� 5      � �� 5     �� 5     " ��6*   .R�5     �� $��PART_FloatingHeaderCanvas��6%   .+�5  "   �� ���	#60000000#��z2 6=   #��z3 6c   5     5     5     5     5     5     