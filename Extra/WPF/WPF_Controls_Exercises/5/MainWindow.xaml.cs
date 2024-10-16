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

namespace _5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double x = 0;
        double y = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void xySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
            if (xCheckBox.IsChecked == true) 
            {
                y = xySlider.Value;

                yLabel.Margin = new Thickness(0, xySlider.Value, 0, 0);
                yLabel.Content = $"Y value: {xySlider.Value} X value: {x}";
            }
            else if(yCheckBox.IsChecked == true)
            {
                x = xySlider.Value;
                yLabel.Margin = new Thickness(xySlider.Value, 0, 0, 0);
                yLabel.Content = $"Y value: {y} X value: {xySlider.Value}";
            }
            else 
            { 
                yLabel.Margin = new Thickness(xySlider.Value, xySlider.Value, 0, 0);
                yLabel.Content = $"Y value: {xySlider.Value} X value: {xySlider.Value}";
            }
        }

        
    }
}