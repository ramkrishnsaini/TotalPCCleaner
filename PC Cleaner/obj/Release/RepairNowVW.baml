   M S B A M L   `   `   `  ���� J  FMahApps.Metro, Version=0.0.0.999, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls   
PC Cleaner   PC_Cleaner.RepairNowVW   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro       � Title$  Repair Errors��$��Center=�$	��Top=� � WindowStartupLocation$ CenterScreen=�(   "MahApps.Metro.Controls.MetroWindow   ShowTitleBar .  $	��600��$	��500��   ShowCloseButton .     ShowMaxRestoreButton .     ShowMinButton .  .��� ����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FFD5FBFF��	 � Offset$	 0Q�� $ White��$	 1Q�
 � RowDefinitions
 �� $��50 ��� $��* ��� $
��Auto �.+��� $��0��$��0��$
��Left=�$	��Top=� �� Orientation$ 
Horizontal=� K� ZIndex$ 10��.+��� $"��Assets/Img/pcCleanerIcon.png��$
��Left=�$	��Top=�$��50��$��50��$
��10,5q��� $��1,0,0,0q�
�������$��50��$
��10,5q��� $��Total PC Cleaner��$
��Left=�$��Center=�$��18(�$��SemiBold"�� -    �Name$ grdInfo��$��1��$��10q�
 �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $��* � � ColumnDefinitions �� $	��200 ��� $��* �.+��� $��0��$��0��$��2��$
��Left=�$	��Top=�$3��-Continue Your PC Repair and Cleaning Process:��$
��10,5q��� $��1��$��0��$��2��$
��Left=�$	��Top=�$"��Talk to computer expert Now.��$
��10,5q��� $��2��$��0��$��2��$
��Left=�$	��Top=�$��USA Toll Free No:��$��	10,10,5,5q�$
��Bold"�$��18(��� $��3��$��0��$��2��$
��Left=�$	��Top=�$��1-877-776-3645��$
��10,5q�$
��Bold"�$��18(��� $��4��$��0��$
��Left=�$	��Top=�$��Status��$
��10,5q�
���  ��$
��Bold"�$��14(��� $��4��$��1��$
��Left=�$	��Top=�$
��Poor��$
��10,5q�
���  ��$
��Bold"�$��14(��� $��5��$��0��$
��Left=�$	��Top=�$��Error Result��$
��10,5q�
���  ��$
��Bold"�$��14(��� -    ��Name$ txtErrorResult��$��5��$��1��$
��Left=�$	��Top=�$
��10,5q�
���  ��$
��Bold"�$��14(��� $��6��$��0��$��2��$
��Left=�$	��Top=�$��Browser found corrupted��$
��10,5q�
���  ��$
��Bold"�$��14(��� $��7��$��0��$��2��$
��Left=�$	��Top=�$��Need urgent maintanance��$
��10,5q�
���  ��$
��Bold"�$��14(��� $��8��$��0��$
��Left=�$	��Top=�$��With the Trial Version��$
��10,5q�$
��Bold"�$��14(��� -   $! txtwithTheTrialPeriodResult��$��8��$��1��$
��Left=�$	��Top=�$
��10,5q�$
��Bold"�$��14(�$
��Wrap=��� $��9��$��0��$
��Left=�$	��Top=�$��Remaining Errors��$
��10,5q�$
��Bold"�$��14(�
���  ���� $��9��$��1��$
��Left=�$	��Top=�$3��-Continue Your PC Repair and Cleaning Process:��$
��10,5q�$
��Bold"�$��14(�
���  ��$
��Wrap=��� $��10��$��1��$
��Left=�$	��Top=�$��Call Now��$
��10,5q�$
��Bold"�$��14(�
���  ���� $��11��$��1��$
��Left=�$	��Top=�$��USA Toll Free No:��$
��10,5q�$
��Bold"�$��14(�
���  ���� $��12��$��1��$
��Left=�$	��Top=�$��1-877-776-3645��$
��10,5q�$
��Bold"�$��14(�
���  ���� $��13��$��0��$��2��$
��Left=�$	��Top=�$a��[*Note - If the status shows 'Poor' please call on toll-free to get free dignosis by expert.��$
��10,5q�$
��Bold"�$��14(�
���  ��$
��Wrap=��� -    ��Name$ spProgressRepair��$ Vertical=�$��1��$
��Left=�$��Center=�$y�	Collapsed=�$
��20,5q�.+��� $ 
Horizontal=�$��5q�.+��� $
��Left=�$	��Top=�$��5q�$��Error Result:��
���  ��$
��Bold"�$��14(��� -   $ txtErrorfound��$
��Left=�$	��Top=�$��50,5,5,5q�
���  ��$
��Bold"�$��14(��� $ 
Horizontal=�$��5q�.+��� $
��Left=�$	��Top=�$��5q�$��Error Fixed:��
��� � �$
��Bold"�$��14(��� -   $ txtErrorFixed��$
��Left=�$	��Top=�$��50,5,5,5q�
��� � �$
��Bold"�$��14(��� -   $ txtErrorsScanProgress��$
��Left=�$	��Top=�$��5q�� -    �Name$ ProgressBar1��$��20��$��5,5,20,5q�$
��Left=�$	��Top=�$	��400���� $��1��$��Stretch=�$��Stretch=�
����ح�$��3q� �� CornerRadius$ 5��$��10q��� -	    ��Name$ 	btnRepair��$��2��$
��Left=�$	��Top=�$��	20,5,5,10q�$��
Repair Now��$��5q�$	��150���� -
   $ btnClose��$��2��$��Right=�$	��Top=�$��	20,5,5,10q�$��Close��$��5q�$	��150���� 
���   �$��1q�$ 10��$��Stretch=�$��Stretch=�$��5��$��5��