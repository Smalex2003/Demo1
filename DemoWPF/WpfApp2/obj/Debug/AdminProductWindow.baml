   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2  5   	        WpfApp2.AdminProductWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp2     5   	     � Title$  Окно товаров��5   	   $	��500��6   $
��1000��6+    � Icon$ Resource/icon.ico��68   .��5	      �  � RowDefinitions 5
   
   �� 5      $��1* �6    6.   �� 5      $��4* �6    6.   �� 5      $��1* �6    6.   .+�5      �� $��0��6   
���   ����#76e383$��1q�6K   �� 5   
   $��/Resource/logo.png��6   $
��Left=�6,   $��60��6G   $��60��6S   $	��Top=�6^   $��-1,9,0,0q�6v   6�   �� 5   
   $
��Left=�6   $��Center=�6+   $g��aНа этой странице вы можете посмотреть список товаров��6F   $��Comic Sans MS)�6�   $��22(�6�   $��97,0,0,0q�6�   �� 5      -   5         ��Name$ AutorizationBtn_Copy��5   1   $'��!Посмотреть заказы��6   ���#498c51$��Comic Sans MS)�6d   $��18(�6   $
��Left=�6�   $��570,295,0,0q�6�   $��1��6�   $	��Top=�6�   $	��192��6�   &   System.Windows.Controls.DataGrid  5      -   5        $��	ProductDG��5      $��1��6)      AutoGenerateColumns .     
IsReadOnly .    ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6d   $��Comic Sans MS)�6t      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Код��6)   	   Width$	 40 66   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6A   �� *	ProductID+  5      $ Артикль��6)   $	 80 6:   
 6E   �� *ProductArticleNumber+  5      $ Название��6)   $	 80 6;   
 6F   �� *ProductName+  5      $ Кол-во��6)   $	 50 69   
 6D   �� *
UnitTypeID+  5      $ Стоимость��6)   $	 80 6<   
 6G   �� *ProductCost+  5      $ Макс. скидка��6)   $	 80 6?   
 6J   �� *ProductMaxDiscountAmount+  5      $' !Код производителя��6)   $	 80 6D   
 6O   �� *ProductManufacturerID+  5      $! Код поставщика��6)   $	 80 6A   
 6L   �� *ProductSupplierID+  5      $ Код категории��6)   $	 80 6@   
 6K   �� *ProductCategoryID+  5      $ Скидка��6)   $	 70 69   
 6D   �� *ProductDiscountAmount+  5      $ Кол-во��6)   $		 100 69   
 6E   �� *ProductQuantityInStock+  5       $ Описание��6)   $		 100 6;   
 6G   �� *ProductDescription+4  .System.Windows.Controls.DataGridTemplateColumn  5!      $ Фото��6-      MaxWidth$ 40Q�6;      CellTemplate 5"      �� 5#      .R�5$   "   �� $��40��6H   $��40��6S   ��6(   �� *ProductPhoto+6S   5%      5'        5(       5)      �� 5*      .R�5+   "   �� $ EditBtn��6)   -   5        
������$ ��Редактировать��5+   R   6�   5,      5.      50      �� 51      -   5        $��FIOLb��51      $�� ��6   $��Comic Sans MS)�6,   $��14(�6G   $
��Left=�6U   $��
781,10,0,0q�6p   $	��Top=�6�   �� 52      -   5        $��ExitBtn��52   %   $��
Выйти��6   ���#498c51$��Comic Sans MS)�6I   $��18(�6d   $
��Left=�6r   $��10,0,0,0q�6�   $��2��6�   $��Center=�6�   $	��154��6�   6�   53      55      