   M S B A M L   `   `   `  ����A  =labor1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:labor1labor1  5   	       labor1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:labor1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $��50 �6   �� 5      $	��100 �6   �� 5      $
��auto �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $��50 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $
��auto �6   �� 5      $��20 �6   .+�5   
   �� $��1��6   $��1��6%   $��28(�62   $��Personal Information��5   	   $��4��6%   $��0, 0, 0, 10q�5   	   �� 5   
   $��	FirstName��6   $��1��6%   $��2��65   �� 5    
   $��LastName��6   $��1��6$   $��3��64   �� 5!   
   -   5         ��Name$ firstnametxt��5!      $��2��6)   $��2��69   $��10q�6F   �� 5"   
   -   5        $ lastnametxt��5"      $��2��6'   $��3��67   $	�� 10q�6D   �� 5#   
   $��1��6   $��4��6$   $��6��64   .��5$      ��  �� Orientation$ Vertical=�6   .+�5%      �� $	��200��6   $	��200��6(   $M��GC:\Users\tanko\OneDrive\Dokumentumok\harmadev\kepfeldolgozas\alma\2.JPG��67   �� 5&      $	��200��6   $	��200��6(   $��labor1\2.JPG��67   �� 5'      $	��200��6   $	��200��6(   $M��GC:\Users\tanko\OneDrive\Dokumentumok\harmadev\kepfeldolgozas\alma\2.JPG��67   �� 5(      $	��200��6   $	��200��6(   $M��GC:\Users\tanko\OneDrive\Dokumentumok\harmadev\kepfeldolgozas\alma\2.JPG��67   5)      5*      �� 5+   
   -   5         ��Name$ peopleComboBox��5+      $��1��6+   $��4��6;   $��2��6H   ��5,      �� 5-      .R�5.      �� $��10q�6!   $ 
Horizontal=�6-   .+�50      �� ��6%   �� *	FirstName+�� 51      $�� ��6$   �� 52      ��6$   �� *
LastName+53      54      56      �� 57   
   -   5         ��Name$ 	submitbtn��57      $��Run me��6$   $��1��65   $��5��6E   $��2��6R   $	�� 10q�6f   6s   5:      5;      