   M S B A M L   `   `   `  ����K  GL051_DataContext, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:L051_DataContextL051_DataContext  5   	   !    L051_DataContext.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:L051_DataContext     5   	     � Title$  
MainWindow��5   	   $	��150��6   $	��300��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� .+�5      �� -   5         ��Name$ textBox��5      $��10q�5      ��5      ��  �� Path$
 Name� �� Mode$ TwoWay=��� 5       � DataContext 6   �� $ Moons[0]�.+�5      �� $��10q�5      ��5      �� $
 Name�5      �� 5      -   5        $��10q�5      ��5      �� $
 Name�5      5      �� 5!   
   $��1��6   $��10q�5"       �� DisplayMemberPath$
 Name��5#   5   ��6   �� $ Moons�65   5%      5&      