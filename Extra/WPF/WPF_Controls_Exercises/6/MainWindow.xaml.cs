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

namespace _6
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




        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var person = (listBox?.SelectedItem as ListBoxItem)?.Content.ToString();
            var pArray = person?.Split(" ");
            
            if(listBox.SelectedItem == null)
            {
                rmButton.IsEnabled = false;
                removeStudentMenu.IsEnabled = false;
                rmContextButton.IsEnabled = false;
            }
            else
            {  
                rmButton.IsEnabled = true;
                removeStudentMenu.IsEnabled = true;
                rmContextButton.IsEnabled = true;

            }

            if (person != null) { 
            firstNameTextBox.Text = pArray[0];
            lastNameTextBox.Text = pArray[1];
            emailTextBox.Text = $"{pArray[0]}.{pArray[1]}@gmail.com";
            }
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Add("New ");
        }

        private void rmButton_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Remove(listBox.SelectedItem);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}