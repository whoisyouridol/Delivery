   M S B A M L   `   `   `  ����J  FDelivery_on_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Delivery_on_WPFDelivery_on_WPF  5   	   &     Delivery_on_WPF.Equipment_Window   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Delivery_on_WPF     5   	     � Title$  Equipment_Window��5   	   $	��500��6"   $	��900��6/   .��5	      � .+�5
   
   �� -   5         ��Name$ Add_Data_CheckBox��5
      $��Add data��6.   $
��Left=�6A   $��	15,21,0,0q�6\   $	��Top=�6o   $��14(�6�   $��1q�6�   $��Center=�6�   �� 5   
   -   5        $��Ok��5      $
��Left=�6   $��748,415,0,0q�69   $	��Top=�6N   $	��121��6f   $��15(�6r   $��36��6�   6�   �� 5   
   $��Product`s name��6   $
��Left=�6)   $��	15,68,0,0q�6D   $	��Top=�6W   $��95��6o   �� 5   
   $��Amount��6   $
��Left=�6!   $��	15,99,0,0q�6<   $	��Top=�6O   $��95��6g   �� 5   
   $��Income��6   $
��Left=�6!   $��
15,130,0,0q�6<   $	��Top=�6P   $��70��6h   �� 5   
   $��Consumption��6   $
��Left=�6&   $��
15,161,0,0q�6A   $	��Top=�6U   $��95��6m   �� 5   
   $��Producer��6   $
��Left=�6#   $��
15,192,0,0q�6>   $	��Top=�6R   $��70��6j   �� 5   
   -   5         ��Name$ 	prod_name��5      $
��Left=�6%   $��22��6@   $��
135,71,0,0q�6L    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��143��6�   6�   �� 5   
   -   5        $ amount��5      $
��Left=�6"   $��23��6=   $��135,102,0,0q�6I   $
 Wrap=�6^   $	��Top=�6r   $	��143��6�   6�   �� 5   
   -   5        $ income��5      $
��Left=�6"   $��23��6=   $��135,134,0,0q�6I   $
 Wrap=�6^   $	��Top=�6r   $	��143��6�   6�   �� 5   
   -   5        $ consumption��5      $
��Left=�6'   $��23��6B   $��135,165,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��143��6�   6�   �� 5   
   -   5        $ producer��5      $
��Left=�6$   $��23��6?   $��135,196,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��143��6�   6�   �� 5   
   -   5        $ Delete_Data_CheckBox��5      $$��Delete data by product`s name:��61   $
��Left=�6Z   $��
10,336,0,0q�6u   $	��Top=�6�   $	��223��6�   $��14(�6�   $��Center=�6�   �� 5   
   -	   5        $! prod_name_to_delete_TextBox��5      $
��Left=�67   $��23��6R   $��
10,359,0,0q�6^   $
 Wrap=�6r   $	��Top=�6�   $	��218��6�   6�   �� 5   
   -
   5        $ Create_table_CheckBox��5      $=��7Create table (don`t use it if you created table before)��62   $
��Left=�6t   $��
10,415,0,0q�6�   $	��Top=�6�   $	��353��6�   $��14(�6�   $��Center=�6�   �� 5   
   -   5        $ Show_Data_CheckBox��5      $��	Show data��6/   $
��Left=�6C   $��
331,21,0,0q�6^   $	��Top=�6r   $��14(�6�   $	��118��6�   $��Center=�6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ Show_data_DataGrid��5      $
��Left=�6/   $	��343��6J   $��
295,39,0,0q�6W   $	��Top=�6k   $	��589��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Product`s name��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *Product_name+  5      $ Amount��6%    65   �� *Amount+  5      $ Income��6%    65   �� *Income+  5      $ Consumption��6%    6:   �� *Consumption+  5       $ Producer��6%    67   �� *
Producer+5"      �� 5#   
   -   5         ��Name$ Back_Button��5#      $
��Back��6&   $
��Left=�65   $��600,415,0,0q�6P   $	��Top=�6e   $	��128��6}   $��36��6�   $��14(�6�   6�   5&      5'      