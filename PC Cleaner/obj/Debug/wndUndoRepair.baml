   M S B A M L   `   `   `  ����J  FMahApps.Metro, Version=0.0.0.999, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   -    
PC Cleaner   PC_Cleaner.wndUndoRepair   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   NControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro    5   -   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Undo Repairs��5   	   $	��500��6   $	��500��6+   (   "MahApps.Metro.Controls.MetroWindow   ShowMinButton .     ShowMaxRestoreButton .   � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�6�   .��5      � -   5         �Name$ layoutRootUndorRepair��5       � RowDefinitions 5   
   �� 5	      $	��100 �6   �� 5
      $��* �6   �� 5      $��80 �6    � ColumnDefinitions 5   
   �� 5      $	��110 �6   �� 5      $��* �6   .+�5   
   �� $#��Assets/Img/system-restore.png��6   $
��Left=�67   $	��Top=�6R   $
��10,5q�6j   $	��100��6x   �� 5   
   $����Total PC Cleaner makes a backup of your registry before any changes are made, allowing for easy restore of your PC. To restore your PC system to previous settings, select one of the following dates of your last error search and click 'Undo Repair'.��6   $��0��6  $��1��6!  $
��Left=�61  $	��Top=�6L  $��5q�6d  $
��Wrap=�6o  &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgLogDetails��5      $��1��6[   $��2��6h   $��Stretch=�6|   $��Stretch=�6�   $��5q�6�   	   AutoGenerateColumns	 .  $
   HorizontalScrollBarVisibility$

 Auto=�6�      CanUserAddRows .  ��6)   �� *lstBackupFile+ �� Mode$ TwoWay=���5      �� 5       �� 
TargetType"  6   .�5      ��  �� Property  �@ AlternatingRowBackground �� Value �	#FFE6F9FF6A   5         Columns 5      4  .System.Windows.Controls.DataGridCheckBoxColumn  5      1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   �� *fileChecked+$ TwoWay=�0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Date Time��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 68      
IsReadOnly .  6D   �� *
fileTime+6a   4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5       .R�5!      ��  �� Orientation$ 
Horizontal=�6)   .+�5"   "   �� $!��Assets/Img/RegistryIcon.jpg��6(   $
��Left=�6M   $	��Top=�6h   $
��10,5q�6�   $��20��6�   $��20��6�   �� 5#   "   $
��Left=�6,   $	��Top=�6G   $��5q�6_   ��6j   �� *
fileName+5$      5%      5'      5)      �� 5*   
   $ 
Horizontal=�6   $��Right=�6.   $	��Top=�6J   $��5q�6b   $��2��6m   $��2��6z   .+�5+      �� -   5         ��Name$ 
btnReverse��5+      $��Undo Repair��6)   $
��Left=�6?   $	��Top=�6Z   $��5q�6r   6}   �� 5,      -   5        $ 	btnDelete��5,      $��Delete��6(   $
��Left=�69   $	��Top=�6T   $��5q�6l   6w   5-      5.      50      