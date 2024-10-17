using Microsoft.Win32;
using System;
using System.ComponentModel;
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
using System.Xml.Linq;

namespace _3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string path = "";
        private string title = "";
        public MainWindow()
        {
            Application.Current.MainWindow.Closing += new CancelEventHandler(MainWindow_Closing);

            InitializeComponent();
            this.Title = "Untitled Document";

        }

        private void menuOpenButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();

            var result = dialog.ShowDialog();
            path = dialog.FileName;

            this.Title = System.IO.Path.GetFileName(dialog.FileName);

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
            Application.Current.MainWindow.Close();
        }

        private void menuSaveButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (this.Title == "Untitled Document" || this.Title == "") { 
            var result = dialog.ShowDialog();
            this.Title = System.IO.Path.GetFileName(dialog.FileName);
                path = dialog.FileName;

            if (result == true)
            {
                using (StreamWriter sw = new StreamWriter(dialog.FileName))
                {
                    sw.WriteLine(textBox.Text);
                }
            }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(textBox.Text);
                }
            }
        }

        private void menuNewButton_Click(object sender, RoutedEventArgs e)
        {
            this.Title = "Untitled Document";

            if (textBox.Text != "")
            {
                MessageBoxResult result = MessageBox.Show("You have unsaved changes, do you want to save first?","Unsaved changes.", MessageBoxButton.YesNoCancel, MessageBoxImage.Warning);

                if (result == MessageBoxResult.Yes)
                {
                    var dialog = new SaveFileDialog();
                    path = dialog.FileName;
                    var diagResult = dialog.ShowDialog();
                    if (diagResult == true)
                    {
                        using (StreamWriter sw = new StreamWriter(dialog.FileName))
                        {
                            sw.WriteLine(textBox.Text);
                        
                        textBox.Text = "";
                        this.Title = "Untitled Document";


                        }

                    }

                }
                else if (result == MessageBoxResult.No)
                {
                    textBox.Text = "";
                    this.Title = "Untitled Document";


                }
            }



        }

        private void menuSaveAsButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.FileName = $"{this.Title}.txt";
            var result = dialog.ShowDialog();
            this.Title = System.IO.Path.GetFileName(dialog.FileName);
            path = dialog.FileName;

            if (result == true)
            {
                using (StreamWriter sw = new StreamWriter(dialog.FileName))
                {
                    sw.WriteLine(textBox.Text);
                }
            }
        }

        void MainWindow_Closing(object sender, CancelEventArgs e)
        {
            if(textBox.Text != "" || this.Title != "Untitled Document")
            { 
            MessageBoxResult result = MessageBox.Show("You have unsaved data, do you want to save?", "Unsaved progress!", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.No)
            {
                    Environment.Exit(0);

            }
            else
            {
                    var dialog = new SaveFileDialog();
                    dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

                    if (this.Title == "Untitled Document" || this.Title == "")
                    {
                        var result1 = dialog.ShowDialog();
                        this.Title = System.IO.Path.GetFileName(dialog.FileName);
                        path = dialog.FileName;

                        if (result1 == true)
                        {
                            using (StreamWriter sw = new StreamWriter(dialog.FileName))
                            {
                                sw.WriteLine(textBox.Text);
                            }
                        }
                    }
                    else
                    {
                        using (StreamWriter sw = new StreamWriter(path))
                        {
                            sw.WriteLine(textBox.Text);
                        }
                    }
                }
            }


        }
    }
}