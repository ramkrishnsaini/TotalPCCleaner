   M S B A M L   `   `   `  ����J  FMahApps.Metro, Version=0.0.0.999, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5       
PC Cleaner"   PC_Cleaner.wndStartupManager   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   NControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Startup Manager��5   	   $	��500��6!   $	��700��6.   (   "MahApps.Metro.Controls.MetroWindow   ShowMinButton .     ShowMaxRestoreButton .   � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�6�   .��5      � -   5         �Name$ layoutRootStartupManager��5       � RowDefinitions 5   
   �� 5	      $	��100 �6   �� 5
      $��* �6   �� 5      $��80 �6    � ColumnDefinitions 5   
   �� 5      $	��110 �6   �� 5      $��* �6   .+�5   
   �� $&�� Assets/Img/lockstart_session.png��6   $
��Left=�6:   $	��Top=�6U   $
��10,5q�6m   $	��100��6{   �� 5   
   $����The startup manager, allows you to control what programs to auto-launch when you turn on or logon to your computer. Startup Manager ensures a fast PC startup process. Select each program to auto-launch at startup. To stop a program from auto-launching, uncheck the program, then click 'Save'.��6   $��0��6@  $��1��6M  $
��Left=�6]  $	��Top=�6x  $��5q�6�  $
��Wrap=�6�  &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgStartupManager��5      $��1��6_   $��2��6l   $��Stretch=�6�   $��Stretch=�6�   $��5q�6�   	   AutoGenerateColumns	 .  $
   HorizontalScrollBarVisibility$

 Auto=�6�      CanUserAddRows .  ��6-   �� *lstBackupFile+ �� Mode$ TwoWay=���5      �� 5       �� 
TargetType"  6   .�5      ��  �� Property  �@ AlternatingRowBackground �� Value �	#FFE6F9FF6A   5         Columns 5      4  .System.Windows.Controls.DataGridCheckBoxColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6V   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   �� *fileChecked+$ TwoWay=�6V   0  *System.Windows.Controls.DataGridTextColumn  5         Header$ Application��6%   $	 150 6:      
IsReadOnly .  6F   �� *
fileName+6c     5      $ File Location��6%   $
 Auto 6<    .  6I   �� *
filePath+6f   5      �� 5    
    �� Orientation$ 
Horizontal=�6   $��Right=�6.   $	��Top=�6J   $��5q�6b   $��2��6m   $��2��6z   .+�5!      �� -   5         ��Name$ btnSave��5!      $
��Save��6&   $
��Left=�65   $	��Top=�6P   $��5q�6h   6s   5"      5#      5$      