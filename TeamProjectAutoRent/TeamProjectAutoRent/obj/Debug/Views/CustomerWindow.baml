   M S B A M L   `   `   `  ����N  JTeamProjectAutoRent, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:TeamProjectAutoRent.ViewsTeamProjectAutoRent.Views  5   	   E ALogicAndDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;,clr-namespace:LogicAndDb;assembly=LogicAndDb
LogicAndDb 5   	   .    (TeamProjectAutoRent.Views.CustomerWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:TeamProjectAutoRent.Views     5   	   C
LogicAndDb,clr-namespace:LogicAndDb;assembly=LogicAndDb     5   	   -   5          � Title$  Customer window��5	   	   $��298.192��6!   $��273.638��62    � 
ResizeMode$ NoResize=�6Z    � 	Resources 5
         customerViewSource��%   &	        �� 5   
   6   5      .��5      � .+�5   
   � -   5         �Name$ grid1��5      $	��Top=�6   $��	10,10,0,0q�66   $
��Left=�6I    � DataContext# [  6d    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#   .+�5      �� $��Center=�6   $��0��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��customer address:��6r   �� 5      -   5         ��Name$ customer_addressTextBox��5      $	��120��67   $��Center=�6C   $��0��6�   $��3q�6�   $��23��6�   $
��Left=�6�   $��1��6  ��6^   �� *customer_address+ �� Mode$ TwoWay=�	 �� NotifyOnValidationError	 . 
 �� ValidatesOnExceptions
 . 6  �� 5      $��Center=�6   $��1��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��driving experience:��6r   �� 5      -   5        $ driving_experienceTextBox��5      $	��120��6m   $��Center=�6y   $��1��6�   $��3q�6  $��23��6  $
��Left=�6#  $��1��6>  ��6�   �� *driving_experience+$ TwoWay=�	 . 
 . 6>  �� 5       $��Center=�6   $��2��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��
full name:��6r   �� 5!      -   5        $ full_nameTextBox��5!      $	��120��60   $��Center=�6<   $��2��6�   $��3q�6�   $��23��6�   $
��Left=�6�   $��1��6�   ��6W   �� *	full_name+$ TwoWay=�	 . 
 . 6�   �� 5"      $��Center=�6   $��3��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��gender:��6r   �� 5#      -   5         ��Name$ genderComboBox��5#      $	��120��6/   $��Center=�6;   $��3��6V   $��3q�6c   $��23��6n   $
��Left=�6z   $��1��6�   �� 5$      $��Center=�6   $��4��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��passport number:��6r   �� 5%      -   5        $ passport_numberTextBox��5%      $	��120��66   $��Center=�6B   $��4��6�   $��3q�6�   $��23��6�   $
��Left=�6�   $��1��6  ��6]   �� *passport_number+$ TwoWay=�	 . 
 . 6  �� 5&      $��Center=�6   $��5��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��phone number:��6r   �� 5'      -   5        $ phone_numberTextBox��5'      $	��120��63   $��Center=�6?   $��5��6�   $��3q�6�   $��23��6�   $
��Left=�6�   $��1��6�   ��6Z   �� *phone_number+$ TwoWay=�	 . 
 . 6�   5(      �� 5)   
   -	   5        $��OK��5)      $
��Left=�6   $��
10,207,0,0q�69   $	��Top=�6M   $	��242��6e   $��50��6q   6}   5+      5,      