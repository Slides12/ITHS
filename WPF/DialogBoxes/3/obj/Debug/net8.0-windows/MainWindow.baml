   M S B A M L   `   `   `  ����>  :3&4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:_3_3  5   	       _3.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:_3     5   	     � Title$  
MainWindow��5   	   $	��850��6   $
��1024��6)   .��5	      �  � RowDefinitions 5   
   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   .+�5   
   �� .+�5   
   ]� .+�5      o� $	��Top=�6   .@�5      m� $��_File��6   .@�5      m� -   5         m�Name$ menuNewButton��5   #   $
��_New��5   !   5   !   m� 5      -   5        $ menuSaveButton��5   #   $��_Save��5   !   5   !   m� 5!      -   5        $ menuSaveAsButton��5!   #   $��_Save As��5"   #   5#   #   m� 5%      -   5        $ menuOpenButton��5%   #   $��_Open��5&      5'      m� 5+      -   5        $ menuExitButton��5+   #   $��_Exit��5,   #   5-   #   50      m� 51      $
��Edit��6   .@�52      m� -   5        $ cutMenuButton��52   #   $	��Cut��53   #    m� Command$ ApplicationCommands.Cut��54   #   m� 55      -   5        $ copyMenuButton��55   #   $
��Copy��56   #   $ ApplicationCommands.Copy��57   #   m� 58      -   5        $ pasteMenuButton��58   #   $��Paste��59   #   $ ApplicationCommands.Paste��5:   #   5;      5<      5=      �� 5?      .��5@      �� -	   5        $��textBox��5A       �� TextWrapping$
 Wrap=�5B      $	��750��5C      $
��1024��5D      " �� VerticalScrollBarVisibility$ Visible=�5E       �� AcceptsReturn$
 True��5F      5G      5I      �� 5J      $��20��6   .@�5K      ��  �� Orientation$ 
Horizontal=�6   .+�5M      �� -
   5        	 ��Name$	 	textBlock��5M      $��- Number of chars: 5 -��5N      5R      5S      5T      5U      5V      