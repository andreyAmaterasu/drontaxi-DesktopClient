   M S B A M L   `   `   `  ����C  ?drontaxi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:drontaxi.Viewdrontaxi.View  5          drontaxi.View.LoginPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:drontaxi.View     5        N� Title$  	LoginPage��5	      .��5      � ��5   
   �� 5       j� Stretch$ UniformToFill=�6    �� ImageSource$3 -pack://application:,,,/Images/flying-taxi.jpg��61    � RowDefinitions 5   
   �� 5      $
��60px �6   �� 5      �� 5      $
��70px �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   .+�5      �� $8��2pack://application:,,,/Images/Logo Dron Taxi-2.png��6   $��5q�6P   �� 5      $��	DRON TAXI��6   $
��Bold"�6*   
�������$��20(�6O   $��Center=�6]   5      �� 5   
   $��1��6   $��60px 0 0 70pxq�6"   $��330px��69   $
��Left=�6G   $��Center=�6b   .+�5      �� $��АВТОРИЗАЦИЯ��6   $
��Bold"�6+   
�������$��	0 10 0 10q�6P   �� 5      $��
Логин��6   $
��Bold"�6%   
�������$��0 10 0 5q�6N   �� 5      $	��1.5q�6    �� CornerRadius$ 3��6+   ���#04a0ff$
��35px��6R   $��0 0 0 10q�6`   ._�5      �� -   5         ��Name$ 
inputLogin��5      $��Center=�6.   $��10 0 0 0q�6P   ��6c   �� *Login+5      �� 5!      $��Пароль��6   $
��Bold"�6&   
�������$��0 0 0 5q�6O   �� 5"      $	��1.5q�6   $ 3��6+   ���#04a0ff$
��35px��6R   $��0 0 0 20q�6`   ._�5#      G� -   5         G�Name$ inputPassword��5#      $��10 0 0 0q�65   $��Center=�6H   5$      � 5'      $��0 0 0 20q�6    � ColumnDefinitions 5(      �� 5)      $
��30px �6'   �� 5*      �� 5+      .+�5-      �� -   5        	 ��Name$	 	CheckSave��5-      $��Center=�6.   �� 5/      $��1��6   $��Запомнить��6,   $
��Bold"�6=   
�������$��Center=�6b   �� 50      $��2��6      InputTabButton#��[  6)   $��Right=�6Q   $
��Bold"�6m   $��
Войти��6   $��150px��6�   $
��35px��6�   ��6�   �� *EntryCommand+51      �� 52      $��2��6     RegistrationTabButton#��[ 6%   $��Right=�6T   $
��Bold"�6p   
���   �$��Регистрация��53      $��330px��6+   $
��35px��69   ��6G   �� *RegistrationCommand+54      �� 56   
   $��2��6   ���#9c2898$��60��63   $��Bottom=�6?   y�6Z   �� 
 �� Path$
 	ShowError�   booleanToVisibilityConverter �� 	Converter# [ ._�58      �� 
�������$��Center=�6+   $��Center=�6H   $^��XНе удалось установить соединение с базой данных��6c   59      �� 5:   
   $��2��6   ���#9c2898$��60��63   $��Bottom=�6?   y�6Z   �� $
 ShowMassage�# [ ._�5<      �� 
�������$��Center=�6+   $��Center=�6H   $5��/Неверный логин или пароль��6c   5=      5>      5?      