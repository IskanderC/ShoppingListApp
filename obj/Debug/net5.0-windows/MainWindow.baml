   M S B A M L   `   `   `  ����J  FShoppingListApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ShoppingListAppShoppingListApp  5   	        ShoppingListApp.MainWindow   5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:ShoppingListApp     5   	     � Title$  Shopping.lisT��5	   	   $	��750��6   $
��1300��6,   $��Roboto)�69   .��5      � 
���� �� � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��0.1* �6   �� 5      $��* �6   .+�5   
   � $��0��6   $��0��6   .+�5      �� 
�������$��To Buy��6+   $��40(�6<   $��Center=�6J   $��Center=�5      62   5      � 5   
   $��0��6   $��1��6   .+�5      �� 
�������$��Bought��6+   $��40(�6<   $��Center=�6J   $��Center=�5      5      5       &   System.Windows.Controls.DataGrid  5"   
   -   5          Name$ DatagridProductsToBuy��5"   0   $��1��6   $��0��6       AutoGenerateColumns$ False��6P      CanUserAddRows$ False��6l      Columns 5#      0  *System.Windows.Controls.DataGridTextColumn  5$      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 63   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6?   �� *Name+  5%      $ Quantity��6%   	 67   �� *
Quantity+4  .System.Windows.Controls.DataGridTemplateColumn  5&      
   CellTemplate
 5'      �� 5(      .R�5)      �� -   5        
 � Tag$ 	fromToBuy��5)   B   $��100px��6R   .��6`   Remove6h   5*      5,        5.      
 5/      �� 50      .R�51      ��  ��Name$ MarkAsBought��6%   -   5        $��120px��51   V   .��6d   Set as bought6s   52      55      58        59   
   -   5        $ DatagridBoughtProducts��59   0   $��1��6   $��1��6    $ False��6Q   $ False��6m    5:        5;      $
 Name��6%   $	 100 63   	 6?   �� *Name+  5<      $ Quantity��6%   	 67   �� *
Quantity+  5=      
 5>      �� 5?      .R�5@      �� -   5        $ 
fromBought��5@   B   $��100px��6S   .��6a   Remove6i   5A      5C      5F      �� 5G   
   -   5        $ 	AddButton��5G      $��Center=�6<   $��Center=�6W   $��0��6t   $��1��6�   $��29(�5H      $��41��6   $��64��6)   .��64   +67   5I      5K      