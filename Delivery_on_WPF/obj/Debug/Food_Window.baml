   M S B A M L   `   `   `  ����J  FDelivery_on_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Delivery_on_WPFDelivery_on_WPF  5   	   !    Delivery_on_WPF.Food_Window   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Delivery_on_WPF     5   	     � Title$  Food_Window��5   	   $
��500 ��6   $	��900��6+   .��5
      � .+�5   
   �� $��Product`s name��6   $
��Left=�6)   $��	10,46,0,0q�6D   $	��Top=�6W   �� 5   
   $��Amount��6   $
��Left=�6!   $��	10,77,0,0q�6<   $	��Top=�6O   �� 5   
   $��Income��6   $
��Left=�6!   $	��Top=�6<   $��
10,115,0,0q�6T   �� 5   
   $��
Consumtion��6   $
��Left=�6%   $��
10,137,0,0q�6@   $	��Top=�6T    J� RenderTransformOrigin$ 9.793,1.746&�6l   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.587Q�6&   T� 5      5      5      �� 5   
   $��Is Certified or not?��6   $
��Left=�6/   $��
10,176,0,0q�6J   $	��Top=�6^   �� 5   
   $��Food`s type��6   $
��Left=�6&   $��
10,207,0,0q�6A   $	��Top=�6U   �� 5   
   -   5         ��Name$ Add_Data_CheckBox��5      $��Add Data��6.   $
��Left=�6A   $��	10,26,0,0q�6\   $	��Top=�6o   $ 0.152,1.579&�6�   6�   �� 5   
   -   5         ��Name$ 	Prod_name��5      $
��Left=�6%   $��23��6@   $��
129,50,0,0q�6L    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��174��6�   6�   �� 5   
   -   5        $ Amount��5      $
��Left=�6"   $��23��6=   $��
129,82,0,0q�6I   $
 Wrap=�6]   $	��Top=�6q   $	��174��6�   6�   �� 5   
   -   5        $ Income��5      $
��Left=�6"   $��23��6=   $��129,115,0,0q�6I   $
 Wrap=�6^   $	��Top=�6r   $	��174��6�   6�   �� 5   
   -   5        $ Consumption��5      $
��Left=�6'   $��23��6B   $��129,150,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��174��6�   6�   �� 5   
   -   5        $ IsCertified��5      $
��Left=�6'   $��23��6B   $��129,179,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��174��6�   6�   �� 5    
   -   5        $ 	Food_type��5       $
��Left=�6%   $��23��6@   $��129,210,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��174��6�   6�   �� 5!   
   -   5        $��Ok��5!      $
��Left=�6   $��758,404,0,0q�69   $	��Top=�6N   $	��111��6f   $��35��6r   $��14(�6~   6�   �� 5"   
   -	   5        $ Delete_Data_CheckBox��5"      $$��Delete Data by product`s name:��61   $
��Left=�6Z   $��
10,281,0,0q�6u   $	��Top=�6�   
�������
���   �6�   �� 5#   
   -
   5        $ Prod_name_to_delete��5#      $
��Left=�6/   $��23��6J   $��
10,305,0,0q�6V   $
 Wrap=�6j   $	��Top=�6   $	��183��6�   6�   �� 5$   
   -   5        $ Create_table_CheckBox��5$      $>��8Create table (if you used it before don`t use it again) ��62   $
��Left=�6u   $��
10,375,0,0q�6�   $	��Top=�6�   $ 0.529,0.526&�6�   $	��300��6�   $y�Visible=�6	  z�5%      V� 5&      .~�5'      ��  �� ScaleY$ 1Q�6%    �� ScaleX$ 1Q�60   �� 5(       �� AngleY$ 0Q�6$   	 �� AngleX$	 0Q�6/   �� 5)      $ 0Q�6&   T� 5*      5+      5-      &   System.Windows.Controls.DataGrid  5.   
   -   5        
  Name$
 Show_data_DataGrid��5.      $
��Left=�6/   $	��349��6J   $��
315,41,0,0q�6W   $	��Top=�6k   $	��554��6�      Columns 5/      0  *System.Windows.Controls.DataGridTextColumn  50      ,  &System.Windows.Controls.DataGridColumn   Header$ Product`s name��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *Product_name+  51      $ Amount��6%    65   �� *Amount+  52      $ Income��6%    65   �� *Income+  53      $ Consumption��6%    6:   �� *Consumption+  54      $ Certification��6%    6<   �� *isCertified+  55      $ 	Food type��6%    68   �� *	Food_type+57      �� 59   
   -   5        $ Show_data_CheckBox��59      $��	Show Data��6/   $
��Left=�6C   $��
315,14,0,0q�6^   $	��Top=�6r   $��87��6�   6�   �� 5:   
   -   5         ��Name$ Back_Button��5:      $��Back
��6&   $
��Left=�6?   $��621,405,0,0q�6Z   $	��117��6o   $��35��6{   $��14(�6�   $	��Top=�6�   $��Center=�6�   $��Center=�6�   $��1,6,1,1q�6�   6  5<      5=      