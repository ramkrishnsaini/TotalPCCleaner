   M S B A M L   `   `   `  ����J  FMahApps.Metro, Version=0.0.0.999, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	    
PC Cleaner   PC_Cleaner.StaticsVW   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   $	��500��5   	   $	��600��6     � WindowStartupLocation$  CenterScreen=�6"   (   "MahApps.Metro.Controls.MetroWindow   ShowTitleBar .     ShowCloseButton .    ShowMaxRestoreButton .     ShowMinButton .  .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5	      $
��Auto �6   �� 5
      $��* �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $%��Assets/Img/Statistics Error.jpg��6   $
��Left=�69   $	��Top=�6T   $
��10,5q�6l   $��3��6z   $��80��6�   $	��100��6�   �� 5   
   $��0��6   $��1��6!   $
��Left=�61   $	��Top=�6L   $��Repors / Statics��6d   $
��Bold"�6|   $��24(�6�   $��5q�6�   
����  �6�   �� 5   
   $��0��6   $��2��6!   $
��Left=�61   $	��Top=�6L   $��Errors Found��6d   $
��Bold"�6x   $��10q�6�   $��18(�6�   
���  ��6�   �� 5   
   $��0��6   $��3��6!   $
��Left=�61   $	��Top=�6L   $��Errors Fixed��6d   $
��Bold"�6x   $��10q�6�   $��18(�6�   
��� � �6�   �� 5   
   $��Stretch=�6   $��Stretch=�6/   $��5q�6K   
���   �$��1q�6j   $��0��6~   $��2��6�   $��2��6�    �� CornerRadius$ 5��6�   �� 5   
   $��Stretch=�6   $��Stretch=�6/   $��5q�6K   
���   �$��1q�6j   $��0��6~   $��3��6�   $��2��6�   $ 5��6�   �� 5   
   -   5         ��Name$ txtErrorFound��5      $��1��6+   $��2��68   $��Center=�6H   $	��Top=�6e   $
��Bold"�6~   $��10q�6�   $��18(�6�   
���  ��6�   �� 5   
   -   5        $ txtErrorFixed��5      $��1��6+   $��3��68   $��Center=�6H   $	��Top=�6e   $
��Bold"�6}   $��10q�6�   $��18(�6�   
��� � �6�   &   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$	 	dgStatics��5      $��2��6&   $��5��63   $��Stretch=�6G   $	��Top=�6e   $��20q�6}   
   AutoGenerateColumns
 .  ��5      �� 5        �� 
TargetType"  6   .�5!      ��  �� Property  �@ AlternatingRowBackground �� Value �	#FFE6F9FF6A   5"         Columns 5$      0  *System.Windows.Controls.DataGridTextColumn  5%      ,  &System.Windows.Controls.DataGridColumn   Header$ Types��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 250 64      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6@   �� *ErrorTypeName+6b     5&      $ Errors��6%   $	 150 65    .  6A   �� *
ErrorCount+6`     5'      $ Fixed��6%   $	 150 64    .  6@   �� *
ErrorFixed+6_   5)      �� 5+   
   $��2��6   $��5��6   $��Stretch=�62   $��Stretch=�6P   
����ح�$��3q�6�   $ 5��6�   $��10q�6�   5-      5.      