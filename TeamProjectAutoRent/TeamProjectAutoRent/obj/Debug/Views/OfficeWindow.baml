   M S B A M L   `   `   `  ����N  JTeamProjectAutoRent, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:TeamProjectAutoRent.ViewsTeamProjectAutoRent.Views  5   	   E ALogicAndDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;,clr-namespace:LogicAndDb;assembly=LogicAndDb
LogicAndDb 5   	   ,    &TeamProjectAutoRent.Views.OfficeWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:TeamProjectAutoRent.Views     5   	   C
LogicAndDb,clr-namespace:LogicAndDb;assembly=LogicAndDb     5   	   -   5          � Title$  OfficeWindow��5	   	   $��152.125��6   $��256.209��6/    � 
ResizeMode$ NoResize=�6W    � 	Resources 5
         officeViewSource��%   &	        �� 5   
   6   5      .��5      � .+�5   
   � -   5         �Name$ grid1��5      $	��Top=�6   $��	10,10,0,0q�66   $
��Left=�6I    � DataContext# [  6d    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#   .+�5      �� $��Center=�6   $��0��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��	capacity:��6r   �� 5      -   5         ��Name$ capacityTextBox��5      $	��120��6/   $��Center=�6;   $��0��6�   $��3q�6�   $��23��6�   $
��Left=�6�   $��1��6�   ��6V   �� *
capacity+ �� Mode$ TwoWay=�	 �� NotifyOnValidationError	 . 
 �� ValidatesOnExceptions
 . 6�   �� 5      $��Center=�6   $��1��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��office address:��6r   �� 5      -   5        $ office_addressTextBox��5      $	��120��65   $��Center=�6A   $��1��6�   $��3q�6�   $��23��6�   $
��Left=�6�   $��1��6  ��6\   �� *office_address+$ TwoWay=�	 . 
 . 6  5      �� 5   
   -   5        $��OK��5      $
��Left=�6   $��	16,74,0,0q�69   $	��Top=�6L   $	��209��6d   $��37��6p   6|   5      5       