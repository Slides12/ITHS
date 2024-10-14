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

namespace L047_Intro_WPF
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (sender as Button);

            MessageBox.Show($"Du klickade på knapp: {button1.Content}!");
            button.HorizontalAlignment = button.HorizontalAlignment == HorizontalAlignment.Right 
                ? HorizontalAlignment.Left: 
                HorizontalAlignment.Right;
            button2.IsEnabled = !button2.IsEnabled;


            Button newButton = new Button();
            newButton.Content = "1";
            newButton.Margin = new Thickness(0,10,10,10);
            newButton.Width = 50;
            myStackPanel.Children.Add(newButton);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button button = (sender as Button);
            button.IsEnabled = false;
        }

       
    }
}