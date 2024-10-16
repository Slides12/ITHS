﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _4
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

        private void ySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            yLabel.Margin = new Thickness(xSlider.Value, ySlider.Value, 0,0);

            yLabel.Content = $"Y value: {ySlider.Value} X value: {xSlider.Value}";
        }

        private void xSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            yLabel.Margin = new Thickness(xSlider.Value, ySlider.Value, 0, 0);

            yLabel.Content = $"Y value: {ySlider.Value} X value: {xSlider.Value}";
        }
    }
}

