   M S B A M L   `   `   `  ���� J  FMahApps.Metro, Version=0.0.0.999, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls   
PC Cleaner"   PC_Cleaner.wndStartupManager   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    NControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Startup Manager��$	��500��$	��700��(   "MahApps.Metro.Controls.MetroWindow   ShowMinButton .     ShowMaxRestoreButton .   � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�.��� -    �Name$ layoutRootStartupManager�� � RowDefinitions �� $	��100 ��� $��* ��� $��80 � � ColumnDefinitions �� $	��110 ��� $��* �.+��� $&�� Assets/Img/lockstart_session.png��$
��Left=�$	��Top=�$
��10,5q�$	��100���� $����The startup manager, allows you to control what programs to auto-launch when you turn on or logon to your computer. Startup Manager ensures a fast PC startup process. Select each program to auto-launch at startup. To stop a program from auto-launching, uncheck the program, then click 'Save'.��$��0��$��1��$
��Left=�$	��Top=�$��5q�$
��Wrap=�&   System.Windows.Controls.DataGrid  -     Name$ dgStartupManager��$��1��$��2��$��Stretch=�$��Stretch=�$��5q�	   AutoGenerateColumns	 .  $
   HorizontalScrollBarVisibility$

 Auto=�   CanUserAddRows .  ���� *lstBackupFile+ �� Mode$ TwoWay=�����  �� 
TargetType"  .���  �� Property  �@ AlternatingRowBackground �� Value �	#FFE6F9FF   Columns 4  .System.Windows.Controls.DataGridCheckBoxColumn  ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *fileChecked+$ TwoWay=�0  *System.Windows.Controls.DataGridTextColumn     Header$ Application��$	 150    
IsReadOnly .  �� *
fileName+  $ File Location��$
 Auto  .  �� *
filePath+��  �� Orientation$ 
Horizontal=�$��Right=�$	��Top=�$��5q�$��2��$��2��.+��� -    ��Name$ btnSave��$
��Save��$
��Left=�$	��Top=�$��5q�