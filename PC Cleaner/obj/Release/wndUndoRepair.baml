   M S B A M L   `   `   `  ���� J  FMahApps.Metro, Version=0.0.0.999, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls   
PC Cleaner   PC_Cleaner.wndUndoRepair   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    NControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Undo Repairs��$	��500��$	��500��(   "MahApps.Metro.Controls.MetroWindow   ShowMinButton .     ShowMaxRestoreButton .   � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�.��� -    �Name$ layoutRootUndorRepair�� � RowDefinitions �� $	��100 ��� $��* ��� $��80 � � ColumnDefinitions �� $	��110 ��� $��* �.+��� $#��Assets/Img/system-restore.png��$
��Left=�$	��Top=�$
��10,5q�$	��100���� $����Total PC Cleaner makes a backup of your registry before any changes are made, allowing for easy restore of your PC. To restore your PC system to previous settings, select one of the following dates of your last error search and click 'Undo Repair'.��$��0��$��1��$
��Left=�$	��Top=�$��5q�$
��Wrap=�&   System.Windows.Controls.DataGrid  -     Name$ dgLogDetails��$��1��$��2��$��Stretch=�$��Stretch=�$��5q�	   AutoGenerateColumns	 .  $
   HorizontalScrollBarVisibility$

 Auto=�   CanUserAddRows .  ���� *lstBackupFile+ �� Mode$ TwoWay=�����  �� 
TargetType"  .���  �� Property  �@ AlternatingRowBackground �� Value �	#FFE6F9FF   Columns 4  .System.Windows.Controls.DataGridCheckBoxColumn  1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *fileChecked+$ TwoWay=�0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ 	Date Time��   Width5  /System.Windows.Controls.DataGridLengthConverter$	 150    
IsReadOnly .  �� *
fileTime+4  .System.Windows.Controls.DataGridTemplateColumn     CellTemplate �� .R���  �� Orientation$ 
Horizontal=�.+��� $!��Assets/Img/RegistryIcon.jpg��$
��Left=�$	��Top=�$
��10,5q�$��20��$��20���� $
��Left=�$	��Top=�$��5q����� *
fileName+�� $ 
Horizontal=�$��Right=�$	��Top=�$��5q�$��2��$��2��.+��� -    ��Name$ 
btnReverse��$��Undo Repair��$
��Left=�$	��Top=�$��5q��� -   $ 	btnDelete��$��Delete��$
��Left=�$	��Top=�$��5q�