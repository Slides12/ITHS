using System.Diagnostics.Metrics;
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

namespace L048_WPF_Standardkontroller
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            comboBox.Items.Add(new Language("English", "Engelska"));
            comboBox.Items.Add(new Language("Swedish", "Svenska"));
            comboBox.DisplayMemberPath = "EnglishName";
            listBox.Items.Add("Spain");
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            
            myLabel.Content = myTextBox.Text;
            comboBox.Items.Add(new Language(myTextBox2.Text, myTextBox.Text));

        }

        private void myTextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            myButton.Content = myTextBox2.Text;

        }

        private void myTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                myLabel.Content = "ENTER";
            }

            myLabel.Content = e.Key.ToString();

        }

        private void checkBox_Click(object sender, RoutedEventArgs e)
        {
           myButton.IsEnabled = checkBox.IsChecked == true;
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            if(radioButtonA.IsChecked == true)
            {
                myLabel.Content = "OptionA";
            }
            else if (radioButtonB.IsChecked == true)
            {
                myLabel.Content = "OptionB";
            }
            else if (radioButtonC.IsChecked == true)
            {
                myLabel.Content = "OptionC";
            }
            else if (radioButtonD.IsChecked == true)
            {
                myLabel.Content = "OptionD";
            }
           
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            myLabel.Content = slider.Value.ToString("n2");
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Language language = comboBox.SelectedItem as Language;
            Language? language = comboBox.Items[comboBox.SelectedIndex] as Language;

            myTextBox.Text = language.EnglishName;
            myTextBox2.Text = language.SwedishhName;

        }





        // En knapp som gör flera knappar
        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    Button newButton = new Button();
        //    newButton.Content = $"new Button {wrapPanel.Children.Count}";
        //    newButton.VerticalContentAlignment = VerticalAlignment.Center;
        //    newButton.Margin = new Thickness(10,10,0,0);
        //    wrapPanel.Children.Add(newButton);
        //}




    }



    public class Language
    {
        public Language(string englishName, string swedishhName)
        {
            EnglishName = englishName;
            SwedishhName = swedishhName;
        }

        public String EnglishName { get; set; }
        public String SwedishhName { get; set; }


        
    }
}