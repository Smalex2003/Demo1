   M S B A M L   `   `   `  ����F  BProductDEmo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ProductDEmoProductDEmo  5   	       ProductDEmo.AdminWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:ProductDEmo     5   	     � Title$  AdminWindow��5   	   $	��550��6   $	��800��6*    � WindowStartupLocation$ CenterScreen=�66    � Icon$ Resources/icon.ico��6[   .��5	      �  � RowDefinitions 5
   
   �� 5      $��75 �6   6*   �� 5      6   �� 5      $��75 �6   6*   .+�5   
   �� $��0��6   ���#468C5165   �� 5   
   $��Comic Sans MS)�6   $��20(�6/   $]��WЗдесь вы можете добавлять/редактировать товары��6=   $��Center=�6s   $��Center=�6�   6�   �� 5   
   $��2��6   ���#468C5165   �� 5   
   -   5        $��Comic Sans MS)�5      $��16(�6,   
������$��
Назад��6R   $	��150��6b   $
��Left=�6n   $��4��6�   $��10q�6�    � 	Resources 5       �� 
TargetType �� Property �� Value��%d   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$ 20��65   6B   5      5      5      �� 5   
   -   5        
������$!��Добавить товар��5   )   $	��195��6B   $��Center=�6N   $��4��6l   $��10q�6y   $��Comic Sans MS)�6�   $��16(�6�    5      ��%d   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$ 20��65   6B   5      5      5      &   System.Windows.Controls.DataGrid  5    
   -   5        $��AdminProductGrid��5    4   $��16(�6L   $��1��6Z   $��5q�6g      AutoGenerateColumns .  	   Columns	 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Код��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 40 62   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *	ProductID+  5#      $
 Артикль��6%   $ 80 66    6A   �� *ProductArticleNumber+  5$      $
 Название��6%   $ 80 67    6B   �� *ProductName+  5%      $
 Кол-во��6%   $ 50 65    6@   �� *
UnitTypeID+  5&      $
 Стоимость��6%   $ 80 68    6C   �� *ProductCost+  5'      $
 Макс. скидка��6%   $ 80 6;    6F   �� *ProductMaxDiscountAmount+  5(      $'
 !Код производителя��6%   $ 80 6@    6K   �� *ProductManufacturerID+  5)      $!
 Код поставщика��6%   $ 80 6=    6H   �� *ProductSupplierID+  5*      $
 Код категории��6%   $ 80 6<    6G   �� *ProductCategoryID+  5+      $
 Скидка��6%   $ 70 65    6@   �� *ProductDiscountAmount+  5,      $
 Кол-во��6%   $	 100 65    6A   �� *ProductQuantityInStock+  5-      $
 Описание��6%   $	 100 67    6C   �� *ProductDescription+4  .System.Windows.Controls.DataGridTemplateColumn  5.      $
 Photo��6)      CellTemplate 5/      �� 50      .R�51      �� $��50��6$   ��6/   �� *ProductPhoto+ �� TargetNullValue$ Resources/picture.png��6y   52      54      56      57      58      