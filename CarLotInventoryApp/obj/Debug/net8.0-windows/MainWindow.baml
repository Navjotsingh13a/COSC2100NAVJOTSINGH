   M S B A M L   `   `   `  ����M  ICarLotInventoryApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:CarLotInventoryAppCarLotInventoryApp  5   	   #    CarLotInventoryApp.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:CarLotInventoryApp     5   	     � Title$  Car Lot Inventory��5   	   $	��602��6#   $	��609��60   .��5	      � $��0,0,0,0q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   .+�5   
   �� $��0��6    �� Orientation$ Vertical=�6"   $��Center=�69   $��0,0,0,0q�6T   .+�5      �� $��0q�6   .+�5      �� $��Make:��6   �� 5      -   5         ��Name$ comboBoxMake��5      $��90��61    � ToolTip$ Select car manufacturer��6<   5      �� 5      $��0q�6   .+�5      �� $��Model:��6   �� 5      -   5        $��textBoxModel��5      $��90��6.   $ Enter car model��69   5       �� 5"      $��0q�6   .+�5$      �� $��Colour:��6   �� 5%      -   5        $��comboBoxColour��5%      $��90��61   $ Enter car colour��6<   5&      �� 5(      $��0q�6   .+�5*      �� $��Year:��6   �� 5+      -   5        $��comboBoxYear��5+      $��90��6/   $  Select year of manufacture��6:   5,      �� 5.      $��0q�6   .+�50      �� $��Price:��6   �� 51      -   5        $��textBoxPrice��51      $��90��6.   $ Enter car price��69   52      �� 54      $��0q�6   .+�56      �� -   5        $��checkBoxNew��56      $��IsNew��6.   $ Check if the car is new��6>   57      58      &   System.Windows.Controls.DataGrid  5;   
   -   5        $��dataGridCars��5;      $��1��6'      AutoGenerateColumns$ False��64   $��	0,24,0,97q�6P      Columns 5<      4  .System.Windows.Controls.DataGridCheckBoxColumn  5=      ,  &System.Windows.Controls.DataGridColumn   Header$	 New��6)   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 50 6P   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 66   �� *IsNew+6P   0  *System.Windows.Controls.DataGridTextColumn  5>      $ ID��6%   $	 50 6Z   
 61   �� *IdentificationNumber+6Z     5?      $
 Make��6%   $		 100 6L   
 63   �� *Make+6L     5@      $ Model��6%   $		 100 6N   
 64   �� *Model+6N     5A      $
 Year��6%   $	 50 6L   
 63   �� *Year+6L     5B      $ Price��6%   $	 80 6N   
 64   �� *Price+6N   5D      �� 5G   
   -   5        $��labelResult��5G      $��1��6#   $��Center=�60   $��90��6M   $	��Top=�5H      $��	0,197,0,0q�6(   $	��589��6;   �� 5K   
   $��2��6   $ 
Horizontal=�6"   $
��Left=�6;   $��	312,3,0,7q�6V   $��2��6i   .+�5L      �� -	   5        $��ButtonEnter��5L      $��_Enter��6(   $��75��69   $��10q�6^   �� 5M      -
   5        $��ButtonReset��5M      $��_Reset��6(   $��75��69   $��10q�6^   �� 5N      -   5        $��
ButtonExit��5N      $��E_xit��6'   $��75��67   $��10q�6[   5O      5P      5Q      