   M S B A M L   `   `   `  ����   
PC Cleaner    PC_Cleaner.ScanErrorVW   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     .��� -     �Name$  layourRootScanError��
�������$��Stretch=�$��Stretch=� � RowDefinitions �� $
��Auto ��� $��* ��� $
��Auto ��� $
��Auto �.+��  �� $��50 ��� $��30 ��� $��40 ��� $��30 ��� $��* � � ColumnDefinitions �� $
��Auto ��� $
��Auto ��� $��* �.+��� $&�� Assets/Img/file_scanner_icon.jpg��$
��Left=�$	��Top=�$
��10,5q�$��3���� $��0��$��1��$
��Left=�$��Bottom=�$
��10,5q�$
��Bold"�$��24(�$��Date of Last Error Scan:���� $��2�� �� Orientation$ 
Horizontal=�.+��� $��Assets/Img/error.jpg��$
��Left=�$��Bottom=�$��20��$��20��$��5q��� -    ��Name$ txtErrorFound��$
��Left=�$��Bottom=�$��5q�
���  ��$
��Bold"�$��18(�$��Errors Found���� $��1��$��2��$ 
Horizontal=�.+��� $��Assets/Img/ok.png��$
��Left=�$	��Top=�$��5q�$��20��$��20���� -   $ txtErrorFixed��$
��Left=�$	��Top=�$��5q�
��� � ��� -   $ 
txtLasScan��$��1��$��1��$
��Left=�$	��Top=�$��5q�
���  ��$��18(��� -   $ txtLasScanStatus��$��2��$��1��$��2��$
��Left=�$	��Top=�$��5q�
��� � �$��18(��� -   $ txtErrorsScanProgress��$��3��$��1��$��2��$
��Left=�$	��Top=�$��5q�� -    �Name$ ProgressBar1��$��4��$��1��$��2��$��20��$��5,5,20,5q�$��Stretch=�$	��Top=��� $��5��$��5��$��Stretch=�$��Stretch=�
���   �$��.5q�$��5,5,5,0q�� $��1��.+��� -    ��Name$ lstbxErrorsType��$��Stretch=�$��Stretch=�$��5q����� *lstErrorTypes+ �� Mode$ TwoWay=����� .R�A�  A� Columns$ 2������ .R��� $ 
Horizontal=�.+��� $
��Left=�$	��Top=�$��15��$��15��$��2q����� *icon+�� $��Assets/Img/error.jpg��$
��Left=�$	��Top=�$��15��$��15��$��2q�y��� *erroIconVisiblity+$ TwoWay=��� $��Assets/Img/ok.png��$
��Left=�$	��Top=�$��15��$��15��$��2q�y��� *okIconVisiblity+$ TwoWay=��� $��2q�	 d� 	IsChecked	 �� *ErrorChecked+$ TwoWay=�y��� *" DataContext.visibilityDuringScan+
 �� ElementName$
 layourRootScanError��$ TwoWay=��� $��2q����� *ErrorTypeName+���� *	FontColor+$ TwoWay=��� $��(������ *	FontColor+$ TwoWay=��� $��2q����� *
ErrorCount+$ TwoWay=����� *	FontColor+$ TwoWay=��� $��)������ *	FontColor+$ TwoWay=��� $��5��$��5��$��Stretch=�$��Stretch=�
���   �$��
.5,0,.5,.5q�$	��5,0q��� -	    ��Name$ chkbxSelectAll��$��2��$
��Left=�$	��Top=�$��25,10q�$
	 TrueY�$#��Select / Clear all categories���� -
    ��Name$ btnFindError��$��2��$��Right=�$	��Top=�$��10q�$��Find Errors��$��5q���Z� �� -   $ btnReset��$��3��$
��Left=�$	��Top=�$��10q�$��Reset��$��5q�$y�	Collapsed=���Z� �� -   $ btnRepaierNow��$��3��$��Right=�$	��Top=�$��10q�$��
Repair Now��$��5q�$y�	Collapsed=���Z� 