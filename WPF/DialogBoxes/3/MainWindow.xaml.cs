﻿using Microsoft.Win32;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void menuOpenButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();

            var result = dialog.ShowDialog();

            if (result == true)
            {
                using (StreamReader sr = new StreamReader(dialog.FileName))
                {
                    String line = sr.ReadToEnd();
                    textBox.Text = line;
                }
            }
        }

        private void menuExitButton_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}