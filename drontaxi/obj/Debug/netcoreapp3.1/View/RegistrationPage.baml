   M S B A M L   `   `   `  ����C  ?drontaxi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:drontaxi.Viewdrontaxi.View  5      $    drontaxi.View.RegistrationPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:drontaxi.View     5        N� Title$  RegistrationPage��5	      .��5      � ��5   
   �� 5       j� Stretch$ UniformToFill=�6    �� ImageSource$3 -pack://application:,,,/Images/flying-taxi.jpg��61    � RowDefinitions 5   
   �� 5      $
��60px �6   �� 5      �� 5      $
��70px �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   .+�5      �� $8��2pack://application:,,,/Images/Logo Dron Taxi-2.png��6   $��5q�6P   �� 5      $��	DRON TAXI��6   $
��Bold"�6*   
�������$��20(�6O   $��Center=�6]   �� 5      $��1��6   
������ $��0q�6>   $��Right=�6S   $��10 0 0 0q�6o   ��5      �� *BackToLoginPage+.��5      �� $,��&pack://application:,,,/Images/back.png��6   $��15q�6H   5      5      �� 5   
   $��1��6   $��350px��6"   $��530px��60   ���#9c2898.+�5       �� $��Регистрация��6   $��300px��6+   $
��14pt(�69   $
��Bold"�6I   
�������$��0 30px 0 10pxq�6n   �� 5!      $��Фамилия *��6   $��300px��6)   
�������$	��9pt(�6N   $��	0 0 0 5pxq�6]   �� 5"      $��2q�6    �� CornerRadius$ 3��6)   ���#04a0ff$
��35px��6P   $��300px��6^   $��0 0 0 10q�6l   ._�5#      �� $��Center=�6G   $��10 0 0 0q�6i   ��6   �� *CreatedUseraccount.Lastname+6i   5$      �� 5%      $��Имя *��6   $��300px��6%   
�������$	��9pt(�6J   $��	0 0 0 5pxq�6Y   �� 5&      $��2q�6   $ 3��6)   ���#04a0ff$
��35px��6P   $��300px��6^   $��0 0 0 10q�6l   ._�5'      �� $��Center=�6H   $��10 0 0 0q�6j   ��6   �� *CreatedUseraccount.Firstname+6j   5(      �� 5)      $��Отчество *��6   $��300px��6*   
�������$	��9pt(�6O   $��	0 0 0 5pxq�6^   �� 5*      $��2q�6   $ 3��6)   ���#04a0ff$
��35px��6P   $��300px��6^   $��0 0 0 10q�6l   ._�5+      �� $��Center=�6I   $��10 0 0 0q�6k   ��6   �� *CreatedUseraccount.Patronymic+6k   5,      �� 5-      $��Email *��6   $��300px��6'   
�������$	��9pt(�6L   $��	0 0 0 5pxq�6[   �� 5.      $��2q�6   $ 3��6)   ���#04a0ff$
��35px��6P   $��300px��6^   $��0 0 0 10q�6l   ._�5/      �� $��Center=�6D   $��10 0 0 0q�6f   ��6   �� *CreatedUseraccount.Email+6f   50      �� 51      $��Пароль *��6   $��300px��6(   
�������$	��9pt(�6M   $��	0 0 0 5pxq�6\   �� 52      $��2q�6   $ 3��6)   ���#04a0ff$
��35px��6P   $��300px��6^   $��0 0 0 10q�6l   ._�53      �� $��Center=�6G   $��10 0 0 0q�6i   ��6   �� *CreatedUseraccount.Password+6i   54      �� 55      $+��%Подтвердить пароль *��6   $��300px��64   
�������$	��9pt(�6Y   $��	0 0 0 5pxq�6h   �� 56      $��2q�6   $ 3��6)   ���#04a0ff$
��35px��6P   $��300px��6^   $��
0 0 0 20pxq�6l   ._�57      �� $��Center=�6   $��10 0 0 0q�6<   58      �� 59      $��2��6      RegistrationTabButton#��[  6%   $
��Bold"�6T   
���   �$��Регистрация��5:      $��300px��6+   $
��35px��69   ��6G   �� *RegistrationCommand+5;      �� 5=   
   $��2��6   ���#9c2898$��60��63   $��Bottom=�6?   y�6Z   ��  �� Path$ ShowMassage�   booleanToVisibilityConverter �� 	Converter# [ ._�5?      �� 
�������$��Center=�6+   $��Center=�6H   $L��FПользователь успешно зарегистрирован��6c   5@      �� 5A   
   $��2��6   ���#9c2898$��60��63   $��Bottom=�6?   y�6Z   �� $ 	ShowError�# [ ._�5C      �� 
�������$��Center=�6+   $��Center=�6H   $_��YПользователь с указанным логином уже существует��6c   5D      5E      5F      