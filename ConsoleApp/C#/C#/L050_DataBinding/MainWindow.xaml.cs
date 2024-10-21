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

namespace L050_DataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var grid=myGrid.Resources;
        }

        //private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    textBox2.Text = textBox1.Text;
        //}

        //private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    textBox1.Text = textBox2.Text;

        //}
    }
}