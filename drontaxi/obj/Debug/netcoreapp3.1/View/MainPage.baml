   M S B A M L   `   `   `  ����C  ?drontaxi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:drontaxi.Viewdrontaxi.View  5          drontaxi.View.MainPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:drontaxi.View     5        N� Title$  MainPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $��300px �6   �� 5       � RowDefinitions 5   
   �� 5      $
��60px �6   �� 5      .+�5   
   � ���#821d80$��0��6$   $��2��64   $��0��6H   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $8��2pack://application:,,,/Images/Logo Dron Taxi-2.png��6   $��5q�6T   �� 5      $��	DRON TAXI��6   $
��Bold"�6-   
�������$��20(�6R   $��Center=�6`   5      5      �� 5   
   $��1��6   $��0��6"   ���#821d80.+�5      � $
��40px��6   $��20px 50px 20px 0q�6!   .+�5      �� 
������ $��0q�62      FlatButtonStyle#��[  6F   .��5      ]� $
��True��6    $��230px��65   .+�5      �� $/��)pack://application:,,,/Images/profile.png��6    $��25��6S   �� 5       $��Профиль��6$   $
��Left=�63   $��39 0 0 0q�6N   $��Center=�6`   
�������$��13(�5!   7   5"      5#      5$      � 5&      $
��40px��6   $��20px 10px 20px 0q�6!   y�6;   ��  �� Path$ ShowUserControl�   booleanToVisibilityConverter �� 	Converter# [ .+�5'      �� 
������ $��0q�62   #��[  6F   .��5(      ]� $
��True��6    $��230px��65   .+�5)      �� $2��,pack://application:,,,/Images/manag-user.png��6    $��25��6V   �� 5*      $*��$Упр. пользователями��6$   $
��Left=�6?   $��30 0 0 0q�6Z   $��Center=�6l   
�������$��13(�5+   7   5,      5-      5.      � 50      $
��40px��6   $��20px 10px 20px 0q�6!   y�6;   �� $ ShowRoleControl�# [ .+�51      �� 
������ $��0q�62   #��[  6F   .��52      ]� $
��True��6    $��230px��65   .+�53      �� $2��,pack://application:,,,/Images/manag-role.png��6    $��25��6V   �� 54      $��Упр. ролями��6$   $
��Left=�67   $��30 0 0 0q�6R   $��Center=�6d   
�������$��13(�55   7   56      57      58      59       � 5:   
   -   5          �Name$ ContainerForPages��5:   M   $��1��6   $��1��6     � NavigationUIVisibility$ Hidden=�6�   ��6-   �� *CurrentPage+6�   5;      5<      