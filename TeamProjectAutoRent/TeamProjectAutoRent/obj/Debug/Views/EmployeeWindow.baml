   M S B A M L   `   `   `  ����N  JTeamProjectAutoRent, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:TeamProjectAutoRent.ViewsTeamProjectAutoRent.Views  5   	   E ALogicAndDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;,clr-namespace:LogicAndDb;assembly=LogicAndDb
LogicAndDb 5   	   .    (TeamProjectAutoRent.Views.EmployeeWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:TeamProjectAutoRent.Views     5   	   C
LogicAndDb,clr-namespace:LogicAndDb;assembly=LogicAndDb     5   	   -   5          � Title$  EmployeeWindow��5	   	   $��263.939��6    $��271.151��61    � 
ResizeMode$ NoResize=�6Y    � 	Resources 5
         employeeViewSource��%   &	        �� 5   
   6   5      .��5      � .+�5   
   � -   5         �Name$ grid1��5      $	��Top=�6   $��	10,10,0,0q�66   $
��Left=�6I    � DataContext# [  6d    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#   .+�5      �� $��Center=�6   $��0��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��birth date:��6r   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ birth_dateDatePicker��5      $��Center=�67   $��0��6�   $��3q�6�   $
��Left=�6�   $��1��6�      SelectedDate 6R   �� *
birth_date+	 �� Mode$	 TwoWay=�
 �� NotifyOnValidationError
 .  �� ValidatesOnExceptions . 6�   �� 5      $��Center=�6   $��1��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��
full name:��6r   �� 5      -   5         ��Name$ full_nameTextBox��5      $	��126��60   $��Center=�6<   $��1��6�   $��3,4,0,4q�6�   $��24��6�   $
��Left=�6�   $��1��6�   ��6W   �� *	full_name+$	 TwoWay=�
 .  . 6�   �� 5      $��Center=�6   $��2��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��gender:��6r   �� 5       -   5         ��Name$ genderComboBox��5       $	��126��6/   $��Center=�6;   $��2��6W   $��3,4,0,4q�6d   $��24��6u   $
��Left=�6�   $��1��6�   �� 5!      $��Center=�6   $��3��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��office address:��6r   �� 5"      -   5        $ office_addressComboBox��5"      $	��126��67   $��Center=�6C   $��3��6^   $��3,4,0,4q�6k   $��24��6|   $
��Left=�6�   $��1��6�   �� 5#      $��Center=�6   $��4��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��passport number:��6r   �� 5$      -   5        $ passport_numberTextBox��5$      $	��126��66   $��Center=�6B   $��4��6�   $��3,4,0,4q�6�   $��24��6�   $
��Left=�6�   $��1��6
  ��6]   �� *passport_number+$	 TwoWay=�
 .  . 6
  5%      �� 5&   
   -   5        $��OK��5&      $
��Left=�63   $��
10,175,0,0q�6N   $	��Top=�6b   $	��241��6z   $��48��6�   5(      5)      