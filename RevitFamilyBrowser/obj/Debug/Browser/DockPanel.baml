   M S B A M L   `   `   `  ����Q  MzRevitFamilyBrowser, Version=2017.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:zRevitFamilyBrowser.WPF_ClasseszRevitFamilyBrowser.WPF_Classes  5      /    )zRevitFamilyBrowser.WPF_Classes.DockPanel   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:zRevitFamilyBrowser.WPF_Classes     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      
�������  � 	Resources  5         FamilyHeaderStyle �� 
TargetType �� Property �� Value �� 
TargetType 9�Name 9� 
IsExpanded �� Orientation��%�  &	        �� 5   
   " ��6*   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      9� $ Expander��5      
�������
�������
���   � .  ��5      �� 5   "   
�������$��1q�6A   ._�5   &   �� $	��500��5   )   
�������$ 
Horizontal=�5   )   .+�5   *   �� $��5��64   
�������6>   �� 5    *   $��0��5!   -   $��0��5"   -   $��50��5#   -   $��50��5$   -   $��80��5%   -   ��5&   -   �� *Items[0].img+�� 5'   *   $��5��64   
�������6>   �� 5(   *   $��0��5)   -   $��0��5*   -   $	��500��5+   -   $��5,0,0,0q�5,   -   $
��Left=�5-   -   $��Center=�5.   -   ��5/   -   �� *Name+50   '   51   #   .��53      �� 54      56      58      59      5:      .��5<      � .+�5=   
   �� -   5         ��Name$ 
tabControl��5=      $��0,0,0,0q�6)   .@�5>      �� $��New Elements��6   .��5?      � 
�������.+�5A      �� -   5        	 ��Name$	 label��5B      $��60��5C      $
��Left=�5D      $	��Top=�5E      $��
Category: ��5F      �� 5G      -   5        $	 label_CategoryName��5H      $	��220��5I      $��80,0,0,0q�5J      $
��Left=�5K      $	��Top=�5L      $�� ��5M      &   System.Windows.Controls.DataGrid  5N      -   5        
  Name$
 dataGrid��5O      $��0,25,0,0q�5P         AutoGenerateColumns .  $��0q�5R      !   EnableColumnVirtualization .     EnableRowVirtualization .     HeadersVisibility$ Column=�5U         HorizontalGridLinesBrush
 �����   
IsReadOnly .    VerticalGridLinesBrush
 ����� �� 
GroupStyle 5`      (  "System.Windows.Controls.GroupStyle  5a         ContainerStyle# [  6)      Panel 5b   "   �� 5c   &   .R�5d   *   >  8System.Windows.Controls.Primitives.DataGridRowsPresenter  5e   '   5g         Columns 5j      4  .System.Windows.Controls.DataGridTemplateColumn  5l      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 85 65      Header$ Image��6@      CellTemplate 5m   "   �� 5n   &   5p   '   5r      0  *System.Windows.Controls.DataGridTextColumn  5t      $ * 5u   !   $
 Name��5w   !   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5v   !   �� *Name+   ElementStyle 5x   "   �� 5y   &   .�5z   *   ��  � ��$ Center=�6_   �� 5{   *    � ��$ 10, 0, 10, 0q�6T   5|   '   5~      5�      5�      5�      �� 5�      $��Elements in project��6   .��5�      � 
�������.+�5�        -   5        $
 dataGridHistory��5�      $��0,25,0,0q�5�       .  $��0q�5�       .   .  $ Column=�5�      
 ����� . 
 ����� 5�        5�      # [  6)    5�   "   �� 5�   &   .R�5�   *     5�   '   5�       5�        5�      $ 85 65   $ Image��6@    5�   "   �� 5�   &   5�   '   5�        5�      $ * 5�   !   $
 Name��5�   !    5�   !   �� *Name+ 5�   "   �� 5�   &   .�5�   *   ��  � ��$ Center=�6_   �� 5�   *    � ��$ 10, 0, 10, 0q�6T   5�   '   5�      5�      5�      5�      5�      5�      5�      