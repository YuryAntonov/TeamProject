   M S B A M L   `   `   `  ����N  JTeamProjectAutoRent, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:TeamProjectAutoRent.ViewsTeamProjectAutoRent.Views  5   	   E ALogicAndDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;,clr-namespace:LogicAndDb;assembly=LogicAndDb
LogicAndDb 5   	   +    %TeamProjectAutoRent.Views.LeaseWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:TeamProjectAutoRent.Views     5   	   C
LogicAndDb,clr-namespace:LogicAndDb;assembly=LogicAndDb     5   	   -   5          � Title$  LeaseWindow��5	   	   $��345.507��6   $��278.215��6.    � 
ResizeMode$ NoResize=�6V    � 	Resources 5
         lease_contractViewSource��%   &	        �� 5   
   6   5      .��5      � .+�5   
   � -   5         �Name$ grid1��5      $	��Top=�6   $��	10,10,0,0q�66   $
��Left=�6I    � DataContext# [  6d    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#   .+�5      �� $��Center=�6   $��0��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��carplate number:��6r   �� 5       -   5         ��Name$ carplate_numberComboBox��5       $	��120��68   $��Center=�6D   $��0��6_   $��3q�6l   $��23��6w   $
��Left=�6�   $��1��6�   �� 5!      $��Center=�6   $��8��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��daily cost:��6r   �� 5"      -   5         ��Name$ daily_costTextBox��5"      $	��120��61   $��Center=�6=   $��8��6�   $��3q�6�   $��23��6�   $
��Left=�6�   $��1��6�   ��6X   �� *
daily_cost+	 �� Mode$	 TwoWay=�
 �� NotifyOnValidationError
 .  �� ValidatesOnExceptions . 6�   �� 5#      $��Center=�6   $��3��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��	end date:��6r   (  "System.Windows.Controls.DatePicker  5$      -   5          Name$ end_dateDatePicker��5$      $��Center=�65   $��3��6�   $��3,4,0,4q�6�   $
��Left=�6�   $��1��6�   $	��120��6     SelectedDate 6P   �� *
end_date+$	 TwoWay=�
 .  . 6  �� 5%      $��Center=�6   $��4��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��issue date:��6r     5&      -   5        $ issue_dateDatePicker��5&      $��Center=�67   $��4��6�   $��3,4,0,4q�6�   $
��Left=�6�   $��1��6�   $	��120��6   6R   �� *
issue_date+$	 TwoWay=�
 .  . 6  �� 5'      $��Center=�6   $��5��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��native office address:��6r   �� 5(      -   5        $# native_office_addressComboBox��5(      $	��120��6>   $��Center=�6J   $��5��6f   $��3q�6s   $��23��6~   $
��Left=�6�   $��1��6�   �� 5)      $��Center=�6   $��6��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��passport number:��6r   �� 5*      -   5        $ passport_numberComboBox��5*      $	��120��68   $��Center=�6D   $��6��6_   $��3q�6l   $��23��6w   $
��Left=�6�   $��1��6�   �� 5+      $��Center=�6   $��7��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��return office address:��6r   �� 5,      -	   5        $# return_office_addressComboBox��5,      $	��120��6>   $��Center=�6J   $��7��6f   $��3q�6s   $��23��6~   $
��Left=�6�   $��1��6�   �� 5-      $��Center=�6   $��2��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��start date:��6r     5.      -
   5        $ start_dateDatePicker��5.      $��Center=�67   $��2��6�   $��3,4,0,4q�6�   $
��Left=�6�   $��1��6�   $	��120��6   6R   �� *
start_date+$	 TwoWay=�
 .  . 6  5/      �� 50   
   -   5        $��Add lease info��50   &   $
��Left=�6?   $��
10,271,0,0q�6Z   $	��Top=�6n   $	��250��6�   $��38��6�   52      53      