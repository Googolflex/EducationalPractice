   M S B A M L   `   `   `  ����F  Bpract20.5.3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:pract20._5._3pract20._5._3  5   	       pract20._5._3.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:pract20._5._3     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      .+�5   
   `� $��0��6   $��2��6#    `� Orientation$ Vertical=�64   $��60��6K   $	��250��6V   $
��Left=�6c    `� 
Background
 �����$��Bottom=�6�   .�5      c� 
�������.@�5      d� -   5         d�Name$ oneNum��5      .��5      �� $��/3564180.png��6   64   5      d� 5      -   5        $ twoNums��5      .��5      �� $��/free-icon-2-3564186.png��6   6@   5      d� 5      -   5        $ 	threeNums��5      .��5      �� $��/free-icon-3-3564189.png��6   6@   5      d� 5      -   5        $ fourNums��5      .��5      �� $��/free-icon-4-3564198.png��6   6@   5      5       5!      �� 5"   
   .+�5#      �� $��20(�6   .��6"   Первое число:61   �� 5$      -   5         ��Name$ firstNum��5$      $��20(�6(   68   �� 5%      $��20(�6   .��6"   Второе число:61   �� 5&      -   5        $ 	secondNum��5&      $��20(�6)   69   5'      �� 5(   
   -   5         ��Name$ resultButton��5(      $��1��6'   $��50��67   $	��300��6C   $��20(�6O   .��6x   Ok6|   �� 5)   
   $��0��6   $��2��6!   $��1��65   
���   �$��2q�6V   $	��450��6j    �� CornerRadius$ 10��6v   ._�5*      �� -   5        	 ��Name$	 result��5*      $	��450��6$   $��20(�60   $��Результат��6>   $��Center=�6R   $��Center=�6t   6�   5+      5,      5-      