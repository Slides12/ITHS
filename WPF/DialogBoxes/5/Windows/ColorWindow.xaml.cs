using System;
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

namespace _5.Windows
{
    /// <summary>
    /// Interaction logic for ColorWindow.xaml
    /// </summary>
    public partial class ColorWindow : Window
    {
        public Color color = new Color() { A = 255, R = 0, G = 0, B = 0 };

        public SolidColorBrush MySolidColorBrush { 
            get
            {
                return new SolidColorBrush(color);
            } set 
            { 
                MySolidColorBrush = value;
            } 
        }

        public ColorWindow()
        {
            InitializeComponent();
            SetStartColor();

        }

        public void SetStartColor()
        {
            rectangle.Fill = MySolidColorBrush;

        }

        private void redSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            color.R = (byte)redSlider.Value;
            rectangle.Fill = MySolidColorBrush;
        }

        private void greenSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            color.G = (byte)greenSlider.Value;
            rectangle.Fill = MySolidColorBrush;
        }

        private void blueSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            color.B = (byte)blueSlider.Value;
            rectangle.Fill = MySolidColorBrush;
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.Close();
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            this.Close();
        }
    }
}
