   M S B A M L   `   `   `  ����C  ?Semaforo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:SemaforoSemaforo  5   	       Semaforo.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Semaforo     5   	     � Title$  	Semáforo��5   	   $	��350��6   $	��600��6'   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $��* �6   6)    � ColumnDefinitions 5   
   �� 5      $
��auto �6   6.   �� 5      $
��auto �6   6.   �� 5      $��* �6   6+   .+�5   
   �� $��	SEMÁFORO��6   $��0��6$   $��1��61   $��10q�6A   $��45(�6M   
����+��6[   �� 5   
   -   5        $��
PanelRadio��5      $��10q�6'   $��1��63   $��1��6C   .+�5      	� -   5        $��RBRed��5      $��5,10,5,5q�6'   .��5      �� $��20(�6   
���  ��Rojo6A   5      	� 5      -   5        $��RBOrange��5      $��5,10,5,5q�6*   .��5      �� $��20(�6   
��� ���Ambar6E   5      	� 5      -   5        $��RBGreen��5      $��5,10,5,5q�6)   .��5      �� $��20(�6   
��� � �Verde6D   5       5!      �� 5"   
   $��1��6   $��0��6"   .+�5#      � $��1��6   .+�5$      �� $��/Semaforo.png��6   $	��200��6/   $	��200��6;   A� 5%      -   5        $��eRojo��5%      
���  ��$��78,22,77,133q�62   $y�Hidden=�6H   A� 5&      -   5        $��eAmbar��5&      
��� ���$��78,75,77,81q�66   $y�Hidden=�6K   A� 5'      -   5        $��eVerde��5'      
��� � �$��78,126,77,29q�65   $y�Hidden=�6K   5(      5)      5*      5+      