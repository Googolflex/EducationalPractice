   M S B A M L   `   `   `  ����B  >pract11, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:pract11pract11  5   	       pract11.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:pract11     5   	     � Title$  
MainWindow��5   	   $	��550��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $	��200 �6   �� 5      .+�5   
   ]� $��2��6   .+�5   
   �� $��75,0,0,0q�6   .+�5      �� $��0,40,0,0q�6   $��15(�6&   .��64   " Количество строк:6G   �� 5      $��0,10,0,0q�6   $��15(�6&   .��64   (&Количество столбцов:6J   5      �� 5   
   $��30,0,0,0q�6   $
��Left=�6'   $	��120��6B   .+�5      �� -   5         ��Name$ rowsBox��5      $��0,40,0,0q�6'   $��30��69   $��60��6E   $
��Left=�6P   6m   �� 5      -   5        $ 
columnsBox��5      $��0,10,0,0q�6*   $��30��6<   $��60��6H   $
��Left=�6S   6p   5      5      �� 5   
   -   5         ��Name$ 
showMatrix��5      $��1��6%   $��2��65   $��Bottom=�6I   $��40��6d   $	��275��6p   $��18(�6|   .��6�   !Показать матрицу6�   �� 5   
   $��1��6   $��4��6$   $��Visible=�68   .��5       �� -   5        $ 	matrixBox��5       $��20(�6)   69   5!      5"      5#      