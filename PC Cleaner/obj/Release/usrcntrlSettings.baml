   M S B A M L   `   `   `  ����   
PC Cleaner!    PC_Cleaner.usrcntrlSettings   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     .��� -     �Name$  layoutrootSetting��$��5q�$��Stretch=�$��Stretch=�
������� � RowDefinitions �� $��* �.+��� $��0��$��0q� � 	Resources  �� 
TargetType   AzureTabItem �� BasedOn��%   '��       7   �� " ��8   .@��� $��General Settings��.����    AzureNavTabItem��%   '��       7  �� " ��8   .@��  �� $	��100 ��� $��* ��� $��80 � � ColumnDefinitions �� $	��110 ��� $��* �.+��� $%��Assets/Img/Gen Setting icon.jpg��$
��Left=�$	��Top=�$
��10,5q�$	��100���� $5��/Customize general settings for Total PC Cleaner��$��0��$��1��$
��Left=�$	��Top=�$��5q�$
��Bold"�$��18(��� $��Stretch=�$��Stretch=�
�������$��1q�$��1��$��2���� $��Center=�$��Stretch=�$��5q�$��1��$��2������ *lstsettingsTypes+ �� Mode$ TwoWay=����� .R���  �� Orientation$ 
Horizontal=�.+��� $��5q�$
��Left=�$	��Top=� d� 	IsChecked �� *settingChecked+$ TwoWay=��� $��5q�$
��Left=�$	��Top=����� *settingName+�� $ 
Horizontal=�$��Right=�$	��Top=�$��5q�$��2��$��2��.+��� -   	 ��Name$	 
btnDefault��$��Default Settings��$
��Left=�$	��Top=�$��5q��� $
��Save��$
��Left=�$	��Top=�$��5q�$��80���� $��Ignore List��
���  ��.����  ��%   '��       7  �� " ��8   .@��  �� $	��100 ��� $��* ��� $��80 � �� $	��110 ��� $��* �.+��� $ ��Assets/Img/Delete-file.png��$
��Left=�$	��Top=�$
��10,5q�$	��100���� $����Here is the list of errrors that you don't want us to correct (if any). If you want us to correct the errors in the future, select them and click 'Delete'.��$��0��$��1��$
��Left=�$	��Top=�$��5q�$
��Wrap=�&   System.Windows.Controls.DataGrid  -   
  Name$
 	dgStatics��$��1��$��2��$��Stretch=�$��Stretch=�$��5q�   AutoGenerateColumns .  $   HorizontalScrollBarVisibility$
 Auto=�   CanUserAddRows .  ���� *lstignoreList+$ TwoWay=����� "  .���  �� Property  �@ AlternatingRowBackground �� Value �	#FFE6F9FF   Columns 4  .System.Windows.Controls.DataGridCheckBoxColumn  ,  &System.Windows.Controls.DataGridColumn   Header$  ��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 20 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *ignoreChecked+$ TwoWay=�0  *System.Windows.Controls.DataGridTextColumn  $ Category��$	 150    
IsReadOnly .  �� *
fileType+  $ Items��$
 Auto  .  �� *
ignoreName+�� $ 
Horizontal=�$��Right=�$	��Top=�$��5q�$��2��$��2��.+��� -   $	 	btnDelete��$��Delete��$
��Left=�$	��Top=�$��5q��� $��Log Details��
������.����  ��%   '��       7  �� " ��8   .@��  �� $	��100 ��� $��* ��� $��80 � �� $	��110 ��� $��* �.+��� $"��Assets/Img/log_file_icon.jpg��$
��Left=�$	��Top=�$
��10,5q�$	��100���� $^��XTotal PC Cleaner saves all changes. Simply click on any file below to revers the repair.��$��0��$��1��$
��Left=�$	��Top=�$��5q�$
��Wrap=�  -   $
 dgLogDetails��$��1��$��2��$��Stretch=�$��Stretch=�$��5q� .  $
 Auto=� .  ���� *
lstLogFile+$ TwoWay=����� "  .���   �@ AlternatingRowBackground �	#FFE6F9FF    �� *fileChecked+$ TwoWay=�  $ 	Date Time��$	 150  .  �� *
fileTime+  $ 	File Name��$
 Auto  .  �� *
fileName+�� $ 
Horizontal=�$��Right=�$	��Top=�$��5q�$��2��$��2��.+��� -   $	 btnGotoFolder��$��Go to folder��$
��Left=�$	��Top=�$��5q��� -   $	 btnDeleteLogFile��$��Delete��$
��Left=�$	��Top=�$��5q��� $��Schedule Repairs��
��� ���.����  ��%   '��       7  �� " ��8   .@��  �� $	��100 ��� $��* ��� $��80 � �� $	��110 ��� $��* �.+��� $"��Assets/Img/SchedulerIcon.png��$
��Left=�$	��Top=�$
��10,5q�$	��100���� $K��ETotal PC Cleaner can be scheduled to auto-scan for errors at anytime.��$��0��$��1��$
��Left=�$	��Top=�$��5q�$
��Wrap=��� $��Stretch=�$��Stretch=�
�������$��1q�$��1��$��2���� $c��]To schedule auto-scan you need to register. This functionalty not available in trial version.��$��1��$��2��
���  ��$
��Bold"�$
��Wrap=�$��5q��� $ 
Horizontal=�$��Right=�$	��Top=�$��5q�$��2��$��2��.+��� -   $	 btnDeleteScheduler��$��Delete��$
��Left=�$	��Top=�$��5q�{�.  �� -	   $	 btnSchedule��$��Schedule��$
��Left=�$	��Top=�$��5q�{�.  