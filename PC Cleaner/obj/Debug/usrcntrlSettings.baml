   M S B A M L   `   `   `  ����  
PC Cleaner!    PC_Cleaner.usrcntrlSettings   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      � -   5          �Name$  layoutrootSetting��5      $��5q�6&   $��Stretch=�61   $��Stretch=�6O   
������� � RowDefinitions 5	   
   �� 5
      $��* �6   .+�5   
   �� $��0��6   $��0q�6"    � 	Resources 5       �� 
TargetType   AzureTabItem �� BasedOn��%0   '��       7   �� 5      " ��6   8   6-   5      .@�5      �� $��General Settings��6   .��5      ��  5        AzureNavTabItem��%0   '��       7  �� 5      " ��6    8   65   5      .@�5      �  5      �� 5      $	��100 �6,   �� 5      $��* �6,   �� 5      $��80 �6,    � ColumnDefinitions 5      �� 5      $	��110 �6/   �� 5      $��* �6/   .+�5       �� $%��Assets/Img/Gen Setting icon.jpg��6    $
��Left=�6I   $	��Top=�6d   $
��10,5q�6|   $	��100��6�   �� 5!      $5��/Customize general settings for Total PC Cleaner��6$   $��0��6[   $��1��6h   $
��Left=�6x   $	��Top=�6�   $��5q�6�   $
��Bold"�6�   $��18(�6�   �� 5#      $��Stretch=�6!   $��Stretch=�6?   
�������$��1q�6n   $��1��6�   $��2��6�   �� 5%      $��Center=�6'   $��Stretch=�6D   $��5q�6`   $��1��6k   $��2��6x   ��6�   �� *lstsettingsTypes+ �� Mode$ TwoWay=���5&      �� 5'   "   .R�5(   &   ��  �� Orientation$ 
Horizontal=�61   .+�5)   *   �� $��5q�63   $
��Left=�6>   $	��Top=�6Y    d� 	IsChecked 6q   �� *settingChecked+$ TwoWay=��� 5*   *   $��5q�64   $
��Left=�6?   $	��Top=�6Z   ��6r   �� *settingName+5+   '   5,   #   5.      �� 5/      $ 
Horizontal=�6%   $��Right=�6>   $	��Top=�6Z   $��5q�6r   $��2��6}   $��2��6�   .+�50      �� -   5        	 ��Name$	 
btnDefault��50   %   $��Default Settings��69   $
��Left=�6T   $	��Top=�6o   $��5q�6�   6�   �� 51      $
��Save��6%   $
��Left=�64   $	��Top=�6O   $��5q�6g   $��80��6r   52      54      55      56      �� 57      $��Ignore List��6   
���  ��.��58      ��  59      ��%0   '��       7  �� 5:      " ��6    8   65   5;      .@�5<      �  5=      �� 5>      $	��100 �6,   �� 5?      $��* �6,   �� 5@      $��80 �6,    5B      �� 5C      $	��110 �6/   �� 5D      $��* �6/   .+�5F      �� $ ��Assets/Img/Delete-file.png��6    $
��Left=�6D   $	��Top=�6_   $
��10,5q�6w   $	��100��6�   �� 5G      $����Here is the list of errrors that you don't want us to correct (if any). If you want us to correct the errors in the future, select them and click 'Delete'.��6$   $��0��6�   $��1��6�   $
��Left=�6�   $	��Top=�6�   $��5q�6  $
��Wrap=�6"  &   System.Windows.Controls.DataGrid  5I      -   5        
  Name$
 	dgStatics��5I   #   $��1��66   $��2��6C   $��Stretch=�6W   $��Stretch=�6u   $��5q�6�      AutoGenerateColumns .  $   HorizontalScrollBarVisibility$
 Auto=�6�      CanUserAddRows .  ��6�   �� *lstignoreList+$ TwoWay=���5J      �� 5K   "   "  6(   .�5L   &   ��  �� Property  �@ AlternatingRowBackground �� Value �	#FFE6F9FF6Q   5M   #      Columns 5O      4  .System.Windows.Controls.DataGridCheckBoxColumn  5P   "   ,  &System.Windows.Controls.DataGridColumn   Header$  ��69      Width5  /System.Windows.Controls.DataGridLengthConverter$ 20 6C   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6N   �� *ignoreChecked+$ TwoWay=�0  *System.Windows.Controls.DataGridTextColumn  5Q   "   $ Category��65   $	 150 6G      
IsReadOnly .  6S   �� *
fileType+6p     5R   "   $ Items��65   $
 Auto 6D    .  6Q   �� *
ignoreName+6p   5T      �� 5U      $ 
Horizontal=�6%   $��Right=�6>   $	��Top=�6Z   $��5q�6r   $��2��6}   $��2��6�   .+�5V      �� -   5        $	 	btnDelete��5V   %   $��Delete��68   $
��Left=�6I   $	��Top=�6d   $��5q�6|   6�   5W      5Y      5Z      5[      �� 5\      $��Log Details��6   
������.��5]      ��  5^      ��%0   '��       7  �� 5_      " ��6    8   65   5`      .@�5a      �  5b      �� 5c      $	��100 �6,   �� 5d      $��* �6,   �� 5e      $��80 �6,    5g      �� 5h      $	��110 �6/   �� 5i      $��* �6/   .+�5k      �� $"��Assets/Img/log_file_icon.jpg��6    $
��Left=�6F   $	��Top=�6a   $
��10,5q�6y   $	��100��6�   �� 5l      $^��XTotal PC Cleaner saves all changes. Simply click on any file below to revers the repair.��6$   $��0��6�   $��1��6�   $
��Left=�6�   $	��Top=�6�   $��5q�6�   $
��Wrap=�6�     5n      -   5        $
 dgLogDetails��5n   #   $��1��6j   $��2��6w   $��Stretch=�6�   $��Stretch=�6�   $��5q�6�    .  $
 Auto=�6�    .  ��6:   �� *
lstLogFile+$ TwoWay=���5o      �� 5p   "   "  6(   .�5q   &   ��   �@ AlternatingRowBackground �	#FFE6F9FF6Q   5r   #    5t        5u   "    69   �� *fileChecked+$ TwoWay=�  5v   "   $ 	Date Time��65   $	 150 6H    .  6T   �� *
fileTime+6q     5w   "   $ 	File Name��65   $
 Auto 6H    .  6U   �� *
fileName+6r   5y      �� 5z      $ 
Horizontal=�6%   $��Right=�6>   $	��Top=�6Z   $��5q�6r   $��2��6}   $��2��6�   .+�5{      �� -   5        $	 btnGotoFolder��5{   %   $��Go to folder��6<   $
��Left=�6S   $	��Top=�6n   $��5q�6�   6�   �� 5|      -   5        $	 btnDeleteLogFile��5|   %   $��Delete��6?   $
��Left=�6P   $	��Top=�6k   $��5q�6�   6�   5}      5      5�      5�      �� 5�      $��Schedule Repairs��6   
��� ���.��5�      ��  5�      ��%0   '��       7  �� 5�      " ��6    8   65   5�      .@�5�      �  5�      �� 5�      $	��100 �6,   �� 5�      $��* �6,   �� 5�      $��80 �6,    5�      �� 5�      $	��110 �6/   �� 5�      $��* �6/   .+�5�      �� $"��Assets/Img/SchedulerIcon.png��6    $
��Left=�6F   $	��Top=�6a   $
��10,5q�6y   $	��100��6�   �� 5�      $K��ETotal PC Cleaner can be scheduled to auto-scan for errors at anytime.��6$   $��0��6q   $��1��6~   $
��Left=�6�   $	��Top=�6�   $��5q�6�   $
��Wrap=�6�   �� 5�      $��Stretch=�6!   $��Stretch=�6?   
�������$��1q�6n   $��1��6�   $��2��6�   �� 5�      $c��]To schedule auto-scan you need to register. This functionalty not available in trial version.��6$   $��1��6�   $��2��6�   
���  ��$
��Bold"�6�   $
��Wrap=�6�   $��5q�6�   �� 5�      $ 
Horizontal=�6%   $��Right=�6>   $	��Top=�6Z   $��5q�6r   $��2��6}   $��2��6�   .+�5�      �� -   5        $	 btnDeleteScheduler��5�   %   $��Delete��6A   $
��Left=�6R   $	��Top=�6m   $��5q�6�   {�.  6�   �� 5�      -	   5        $	 btnSchedule��5�   %   $��Schedule��6:   $
��Left=�6M   $	��Top=�6h   $��5q�6�   {�.  6�   5�      5�      5�      5�      5�      5�      5�      