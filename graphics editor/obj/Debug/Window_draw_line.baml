   M S B A M L   `   `   `  ����J  Fgraphics editor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:graphics_editorgraphics_editor  5   	   &     graphics_editor.Window_draw_line   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:graphics_editor     5   	     � Title$#  Отрисовка линии��5   	   $	��220��5	   	   $	��300��5
   	   $	��220��5   	   $	��300��5   	    � 
ResizeMode$ CanResizeWithGrip=�5   	    � ShowInTaskbar .   � WindowStartupLocation$ CenterOwner=�5   	    +� FocusedElement 5   	   ��  �� ElementName$ leftMarginTextBox��.��5      � 
�������.+�5   
   �� -   5        $��ittem_x1��5      
�������$��0��5      $��	65,7,72,0q�5      $��25��5      $	��Top=�5      .��6*   5      �� 5   
   $
��X1: ��5      $
��Left=�5      $��25��5      $��12(�5       $��20,7,0,0q�5!      $	��Top=�5"      $��28��5#      
�������$��Center=�5%      $��Center=�5&      5'      �� 5)   
   $
��Y1: ��6   $
��Left=�5*      
�������$��25��5,      $��	20,37,0,0q�5-      $	��Top=�5.      $��28��5/      50      �� 52   
   -   5         ��Name$ ittem_y1��52      
�������$��0��56      $��
65,37,72,0q�57      $��25��58      $	��Top=�59      .��6*   5:      �� 5<   
   -   5        $ ittem_x2��5=      
�������$��0��5A      $��
65,68,72,0q�5B      $��25��5C      $	��Top=�5D      .��6%   5E      �� 5G   
   $
��X2: ��5H      $
��Left=�5I      $��25��5J      $��12(�5K      $��	20,68,0,0q�5L      $	��Top=�5M      $��28��5N      
�������$��Center=�5P      $��Center=�5Q      5R      �� 5T   
   $	��Y2:��6   $
��Left=�5U      
�������$��25��5W      $��	20,98,0,0q�5X      $	��Top=�5Y      $��28��5Z      5[      �� 5]   
   -   5        $ ittem_y2��5]      
�������$��0��5a      $��
65,98,72,0q�5b      $��25��5c      $	��Top=�5d      .��6*   5e      �� 5g   
   -   5        $��okButton��5g       �� 	IsDefault . $��65,138,167,10q�5j      $��OK��5k      5l      �� 5n   
   -   5         ��Name$ cancelButton��5n      	 �� IsCancel	 . $��Cancel��5p      $��168,138,47,10q�5q      5s      5t      5u      