   M S B A M L   `   `   `  ���� J  FMahApps.Metro, Version=0.0.0.999, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls   
PC Cleaner   PC_Cleaner.StaticsVW   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     $	��500��$	��600��  � WindowStartupLocation$  CenterScreen=�(   "MahApps.Metro.Controls.MetroWindow   ShowTitleBar .     ShowCloseButton .    ShowMaxRestoreButton .     ShowMinButton .  .���  � RowDefinitions �� $
��Auto ��� $
��Auto ��� $��* ��� $
��Auto � � ColumnDefinitions �� $
��Auto ��� $
��Auto ��� $��* ��� $��* �.+��� $%��Assets/Img/Statistics Error.jpg��$
��Left=�$	��Top=�$
��10,5q�$��3��$��80��$	��100���� $��0��$��1��$
��Left=�$	��Top=�$��Repors / Statics��$
��Bold"�$��24(�$��5q�
����  ��� $��0��$��2��$
��Left=�$	��Top=�$��Errors Found��$
��Bold"�$��10q�$��18(�
���  ���� $��0��$��3��$
��Left=�$	��Top=�$��Errors Fixed��$
��Bold"�$��10q�$��18(�
��� � ��� $��Stretch=�$��Stretch=�$��5q�
���   �$��1q�$��0��$��2��$��2�� �� CornerRadius$ 5���� $��Stretch=�$��Stretch=�$��5q�
���   �$��1q�$��0��$��3��$��2��$ 5���� -    ��Name$ txtErrorFound��$��1��$��2��$��Center=�$	��Top=�$
��Bold"�$��10q�$��18(�
���  ���� -   $ txtErrorFixed��$��1��$��3��$��Center=�$	��Top=�$
��Bold"�$��10q�$��18(�
��� � �&   System.Windows.Controls.DataGrid  -   	  Name$	 	dgStatics��$��2��$��5��$��Stretch=�$	��Top=�$��20q�
   AutoGenerateColumns
 .  ����  �� 
TargetType"  .���  �� Property  �@ AlternatingRowBackground �� Value �	#FFE6F9FF   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Types��   Width5  /System.Windows.Controls.DataGridLengthConverter$	 250    
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *ErrorTypeName+  $ Errors��$	 150  .  �� *
ErrorCount+  $ Fixed��$	 150  .  �� *
ErrorFixed+�� $��2��$��5��$��Stretch=�$��Stretch=�
����ح�$��3q�$ 5��$��10q�