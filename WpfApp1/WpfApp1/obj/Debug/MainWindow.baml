   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:TicTacToe	TicTacToe  5   	       TicTacToe.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:TicTacToe     5   	     � 
ResizeMode$  NoResize=�5   	    � Title$ Tic Tac Toe��5	   	   $	��630��6   $	��900��6*    � Topmost .  � Icon$ tictactoe.png��6E    � 	Resources 5
       �� 
TargetType �� Property �� Value��%�   '��       �� 5   
   " ��6   .�5      ��  � ��$	 0.5q�60   �� 5       � ��
 �����6+   �� 5       � ��$ 70(�6)   �� 5       � ��$$ Tw Cen MT Condensed Extra Bold)�6+   5      5      .��5      � -   5         �Name$ 	Container��5      	 � ColumnDefinitions	 5   
   �� 5      $��200px �6   �� 5      $��200px �6   �� 5      $��200px �6   �� 5      $��200px �6   
 � RowDefinitions
 5   
   �� 5      $��200px �6   �� 5      $��200px �6   �� 5      $��200px �6   �� 5      $��200px �6   .+�5    
   �� -   5         ��Name$ 	Button0_0��5    &   $��0��69   $��0��6I   $�� ��6V   �� 5!   
   -   5        $ 	Button1_0��5!   &   $��1��69   $��0��6I   $�� ��6V   �� 5"   
   -   5        $ 	Button2_0��5"   &   $��2��69   $��0��6I   �� 5#   
   -   5        $ 	Button0_1��5#   &   $��0��69   $��1��6I   �� 5$   
   -   5        $ 	Button1_1��5$   &   $��1��69   $��1��6I   �� 5%   
   -   5        $ 	Button2_1��5%   &   $��2��69   $��1��6I   �� 5&   
   -   5        $ 	Button0_2��5&   &   $��0��69   $��2��6I   �� 5'   
   -	   5        $ 	Button1_2��5'   &   $��1��69   $��2��6I   �� 5(   
   -
   5        $ 	Button2_2��5(   &   $��2��69   $��2��6I   �� 5)   
   -   5        $��Restart��5)      $��3��6#   $
��Left=�63   $��84��6N   $��59.6,47,-42.8,0q�6Z   $��2��6s   $	��Top=�6�   $	��184��6�   $��36(�6�   6�   �� 5*   
   -   5         ��Name$ PlayerIndicator��5*      $��3��6-   $
��Left=�6=   $��98.6,69,-42.8,0q�6X   $
��Wrap=�6q   $��O��6�   $	��Top=�6�   $	��107��6�   $	��145��6�   $��72(�6�   $��MS Reference Sans Serif)�6�   �� 5+   
   $��3��6   $
��Left=�6$   $��50��6?   $��33.6,0,-42.8,0q�6K   $
��Wrap=�6c   $��Ruch gracza��6w   $	��Top=�6�   $	��210��6�   $��36(�6�   5-      5.      