   M S B A M L   `   `   `  ���� E  APC Cleaner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:PC_Cleaner
PC_Cleaner  J FMahApps.Metro, Version=0.0.0.999, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls     PC_Cleaner.MainWindow   '
PC_Cleanerclr-namespace:PC_Cleaner  W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro       � Title$  
PC Cleaner��$��Center=�$	��Top=� � WindowStartupLocation$ CenterScreen=�(  "MahApps.Metro.Controls.MetroWindow   ShowTitleBar .  $	��950��$	��700�� � Icon$" Assets/Img/pcCleanerIcon.png�� � ShowInTaskbar .     ShowCloseButton .     ShowMinButton .     ShowMaxRestoreButton .   � 	Resources    imgBrush	 �� ImageSource��%2   &	        �� $"	 Assets/Img/img_backgroud.jpg��.��� -   
 �Name$
 
layoutGrid��$��Stretch=�$��Stretch=� � ShowGridLines .   � RowDefinitions �� $��60 ��� $��80 ��� $��* ��� $��40 � � ColumnDefinitions �� $��* ��� $	��150 ��� $	��200 �.+��� #��[  $��Stretch=�$��Stretch=�$��3��$��5�� J� Opacity$	 0.4Q� K� ZIndex$ 5���� $��0��$��0��$
��Left=�$	��Top=� �� Orientation$ 
Horizontal=�$ 10��.+��� $&�� Assets/Img/seek experts logo.JPG��$
��Left=�$	��Top=�$��50��$��50��$
��10,5q��� $��1,0,0,0q�
�������$��50��$
��10,5q��� $��Total PC Cleaner��$
��Left=�$��Center=�$��18(�$��SemiBold"��� $ Vertical=�$��Right=�$	��Top=�$��5q�$ 7��$��2��.+��� $H��BYou are one call away from peace of mind, any time 24/7 assistance��$��14(��� $��Call: 1-877-776-3645��$��20(�$
��Bold"�
��� � �$��Center=��� $��1��$��0��$��2��
���   �$��1q�$��Stretch=�$��80��$	��Top=�$ 6�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 10Q�   ShadowDepth$ 5Q�����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FFF10A0A�� � Offset$ 0.513Q�� $ 	#FFD62323��� $ 	#FFD62323��$ 0.991Q�._��� $ ��! Your computer is at risk��$
��Bold"�
�������$��28(�$
��Left=�$��Center=�$
��50,0q��� $��1��$��2��$��2��$��Right=�$	��Top=�$ 10��.+��� 
����=H� �� StrokeDashArray$	 2 2R�	 �� X2$	 150���� -    ��Name$ spHomeButton��$ 
Horizontal=�$
��Left=�$��10q�.+��� $��Assets/Img/Home_icon.png��$��15��$��15���� -    ��Name$ txtHome��$
��Home��$
��10,0q�
����=H�$��	Underline{�$��14(� � Cursor$
 Hand���� 
����=H�$	 2 2R�$	 150���� $ 
Horizontal=�$
��Left=�$��10q�.+��� $!��Assets/Img/Setting-icon.png��$��15��$��15���� -   $ txtSettings��$��Settings��$
��10,0q�$��14(�$
 Hand���� 
����=H�$	 2 2R�$	 150���� $ 
Horizontal=�$
��Left=�$��10q�.+��� $��Assets/Img/favicon.png��$��15��$��15���� -   $ txtStartupManager��$��Startup Manager��$
��10,0q�$��14(�$
 Hand���� 
���   �$	 2 2R�$	 150��   PC_Cleaner.ScanErrorVW  -     Name$ cntrlScanerror��$��2��$ 50��$y�	Collapsed=�!   PC_Cleaner.usrcntrlSettings  -     Name$ cntrlSettings��$��2��$ 50��$y�	Collapsed=�� -   $
 grdMain1��$��2��$��0�� .   �� $��* ��� $��* � �� $��* ��� $��* �.+��� $��0��$��0��
�������
�������$��1q� �� CornerRadius$ 5��$��20q�$	��250��$	��220��$��Center=�$��Center=�   $ 10Q�$ 5Q��� $��0��$��1��
�������
�������$��1q�$ 5��$��20q�$	��250��$	��220��$��Center=�$��Center=�   $ 10Q�$ 5Q��� $��1��$��0��
�������
�������$��1q�$ 5��$��20q�$	��250��$	��220��$��Center=�$��Center=�   $ 10Q�$ 5Q��� $��1��$��1��
�������
�������$��1q�$ 5��$��20q�$	��250��$	��220��$��Center=�$��Center=�   $ 10Q�$ 5Q�� -	   $
 grdMain2��$��2��$��0��$ 10��$��Stretch=�$��Stretch=� �� $��* ��� $��* � �� $��* ��� $��* �.+��� -
   $ 	spScanNow��$ Vertical=�$��0��$��0��$	��250��$��Center=�$��Center=�.+��� -   $ txtScanComputer��$��Scan Computer��$��20(�$��10q�
����=H�$��	Underline{�$
��Left=�$
 Hand���� $L��FRun a scan to eliminate viruses, spware, and other threats on your PC.��$��Center=�$
��Wrap=��� $ 
Horizontal=�.+�F� $��11��$��11��  J� SnapsToDevicePixels  .  
��� � �$��2��F���Ѐ�  	= Ӏ�  	= ��- @KL @KL @]� �@KL @]� @KL ��-  � 	$��10,5,0,0q��� $��Real-Time Scan:��$��18(�$��10q��� $��On��$��18(�$
��5,10q�
��� � ��� $ Vertical=�$��0��$��1��$	��250��$��Center=�$��Center=�.+��� -   $ btnUndoRepair��$��Undo Repair��$��20(�$��10q�
����=H�$��	Underline{�$
��Left=�$
 Hand���� $5��/To restore your PC System to previous settings.��$��10,0,0,0q�$
��Left=�$
��Wrap=��� $ 
Horizontal=�.+�F� $��11��$��11��  .  
��� � �$��2��F���Ѐ�  	= Ӏ�  	= ��- @KL @KL @]� �@KL @]� @KL ��-  � 	$��10,5,0,0q��� $��Data Protection:��$��18(�$��10q��� $��On��$��18(�$
��5,10q�
��� � ��� $ Vertical=�$��1��$��0��$	��250��$��Center=�$��Center=�.+��� -   $��Total Activity��$��20(�$��10q�
����=H�$��	Underline{�$
��Left=�$
 Hand���� $M��GHere's a summary of activity on your PC since you installed pc cleaner.��$��10,0,0,0q�$
��Left=�$
��Wrap=��� $ 
Horizontal=�.+�F� $��11��$��11��  .  
��� � �$��2��F���Ѐ�  	= Ӏ�  	= ��- @KL @KL @]� �@KL @]� @KL ��-  � 	$��10,5,0,0q��� $��Track History:��$��18(�$��10q��� $��On��$��18(�$
��5,10q�
��� � ��� $ Vertical=�$��1��$��1��$	��250��$��Center=�$��Center=�.+��� -   $ btnRegisterNow��$��Register Now��$��20(�$��10q�
��� � �$��	Underline{�$
��Left=�$
 Hand���� $k��eYour subscription provides automatic updates for protection from the most current viuses and malware.��$��10,0,0,0q�$
��Left=�$
��Wrap=��� $ 
Horizontal=�.+��� $��!��$��24(�$��10,5,0,0q�
���  ��$
��Bold"��� $��Subscription:��$��18(�$��10q��� $��Trial��$��18(�$��10q�
���  ���� $��2��$��1��$��2��
�������$��1q�$ 20��$��20,100q�$	��250��$	��150��$��Center=�$	��Top=�$ 7��._��� $ Vertical=�$��Center=�$	��Top=�.+��� $��Repair Summary��$
��Wrap=�$
��10,5q�$��18(��� $ 
Horizontal=�.+��� $��Errors Found to date:��$
��Wrap=�$
��10,5q��� -   $ txtErrorFound��$
��Wrap=�$��5q�
���  ��$
��Left=����� *mainErrorFound+! �� Mode$! TwoWay=��� $ 
Horizontal=�.+��� $��Errors Fixed to date:��$
��Wrap=�$
��10,5q��� -   $ txtErrorFixed��$
��Wrap=�$��5q�
��� � �$
��Left=����� *mainErrorFixed+$! TwoWay=��� $��2��$��1��$��2��
�������
�������$��1q�$ 20��$��20q�$	��250��$	��200��$��Center=�$��Bottom=�$ 8��   $ 10Q�$ 5Q�._��� $ Vertical=�$��Center=�$	��Top=�.+��� $U��OTo optimize your computer performance and security call now for free diagnosis!��$
��Wrap=�$
��10,5q�$��18(�$	��Top=��� $6��0Get your computer check by certified technician.��$
��Wrap=�$
��10,5q�$��18(�$	��Top=��� $&�� USA Toll Free No: 1-877-776-3645��$
��Bold"�$��18(�$
��Wrap=�$
��10,5q�$	��Top=�