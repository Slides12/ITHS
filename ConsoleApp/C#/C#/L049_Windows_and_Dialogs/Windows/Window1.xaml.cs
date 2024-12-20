﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace L049_Windows_and_Dialogs.Windows
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddUserWindow addUserWindow = new AddUserWindow();


            var result = addUserWindow.ShowDialog();

            if(result == true)
            {
                listBox.Items.Add($"{addUserWindow.FirstName} {addUserWindow.LastName}");
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NonDialogWindow nonDialogWindow = new(myTextBox);

            nonDialogWindow.Show();
        }
    }
}
