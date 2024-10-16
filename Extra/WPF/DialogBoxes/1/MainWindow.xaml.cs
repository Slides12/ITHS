using System.ComponentModel;
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

namespace _1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Application.Current.MainWindow.Closing += new CancelEventHandler(MainWindow_Closing);

            MessageBox.Show($"Application is about to start!");
            InitializeComponent();
            MessageBox.Show($"Application started!");

        }



        void MainWindow_Closing(object sender, CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to quit?", "HUH??", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if( result == MessageBoxResult.No ) 
            { 
            e.Cancel = true;
            }
        }
    }
}