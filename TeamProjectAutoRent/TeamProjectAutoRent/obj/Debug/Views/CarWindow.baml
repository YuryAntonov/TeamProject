   M S B A M L   `   `   `  ����N  JTeamProjectAutoRent, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:TeamProjectAutoRentTeamProjectAutoRent  5   	   E ALogicAndDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;,clr-namespace:LogicAndDb;assembly=LogicAndDb
LogicAndDb 5   	   #    TeamProjectAutoRent.CarWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:TeamProjectAutoRent     5   	   C
LogicAndDb,clr-namespace:LogicAndDb;assembly=LogicAndDb     5   	   -   5          � Title$  
Car window��5	   	   $��258.076��6   $��263.181��6-    � 
ResizeMode$ NoResize=�6U    � 	Resources 5
         carViewSource��%   &	        �� 5   
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
��Left=�6G   $��0��6b   $��car status:��6r   �� 5      -   5         ��Name$ car_statusComboBox��5      $	��120��63   $��Center=�6?   $��0��6[   $��3q�6h   $��23��6s   $
��Left=�6   $��1��6�   �� 5      $��Center=�6   $��1��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��carplate number:��6r   �� 5      -   5         ��Name$ carplate_numberTextBox��5      $	��120��66   $��Center=�6B   $��1��6�   $��3q�6�   $��23��6�   $
��Left=�6�   $��1��6  ��6]   �� *carplate_number+	 �� Mode$	 TwoWay=�
 �� NotifyOnValidationError
 .  �� ValidatesOnExceptions . 6  �� 5      $��Center=�6   $��2��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��color:��6r   �� 5       -   5        $ colorTextBox��5       $	��120��6,   $��Center=�68   $��2��6�   $��3q�6�   $��23��6�   $
��Left=�6�   $��1��6�   ��6S   �� *color+$	 TwoWay=�
 .  . 6�   �� 5!      $��Center=�6   $��3��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��mileage:��6r   �� 5"      -   5        $ mileageTextBox��5"      $	��120��6W   $��Center=�6c   $��3��6�   $��3q�6�   $��23��6�   $
��Left=�6  $��1��6  ��6~   �� *	mileage+$	 TwoWay=�
 .  . 6  �� 5#      $��Center=�6   $��4��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��model name:��6r   �� 5$      -   5        $ model_nameComboBox��5$      $	��120��63   $��Center=�6?   $��4��6Z   $��3q�6g   $��23��6r   $
��Left=�6~   $��1��6�   5%      �� 5&   
   -   5        $��OK��5&      $
��Left=�63   $��
10,175,0,0q�6N   $	��Top=�6b   $	��232��6z   $��42��6�   5(      5)      