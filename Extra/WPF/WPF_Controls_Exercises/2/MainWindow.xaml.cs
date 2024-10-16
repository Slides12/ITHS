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

namespace _2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int count = 5;
        public MainWindow()
        {
            InitializeComponent();
        }

     

        private void buttonDecrease_Click(object sender, RoutedEventArgs e)
        {
            if (count > 0) { 
                myLabel.Content = $"{count--}";
            }
            else
            {
                myLabel.Content = $"{count}";

            }

        }

        private void buttonIncrease_Click(object sender, RoutedEventArgs e)
        {
            if (count < 9) { 
                myLabel.Content = $"{count++}";
            }
            else
            {
                myLabel.Content = $"{count}";

            }

        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            count = (int)slider.Value;
            myLabel.Content = $"{count}";

        }
    }
}