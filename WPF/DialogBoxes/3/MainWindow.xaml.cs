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
        private string line = "";
        OpenFileDialog dialog = new OpenFileDialog();
        SaveFileDialog saveDialog = new SaveFileDialog();

        public MainWindow()
        {
            Application.Current.MainWindow.Closing += new CancelEventHandler(MainWindow_Closing);
            saveDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            InitializeComponent();
            this.Title = "Untitled Document";

        }

        private void menuOpenButton_Click(object sender, RoutedEventArgs e)
        {
            var resultOpen = dialog.ShowDialog();
            path = dialog.FileName;
            this.Title = System.IO.Path.GetFileName(dialog.FileName);

            if (resultOpen == true)
            {
                using (StreamReader sr = new StreamReader(dialog.FileName))
                {
                    line = sr.ReadToEnd();
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

            if (this.Title == "Untitled Document" || this.Title == "") { 
            var result = saveDialog.ShowDialog();
            this.Title = System.IO.Path.GetFileName(saveDialog.FileName);
                path = saveDialog.FileName;

            if (result == true)
            {
                    SaveAs(saveDialog);
            }
            }
            else
            {
                Save();
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
                    var saveDialog = new SaveFileDialog();
                    path = saveDialog.FileName;
                    var diagResult = saveDialog.ShowDialog();
                    if (diagResult == true)
                    {
                        SaveAs(saveDialog);
                        
                        textBox.Text = "";
                        this.Title = "Untitled Document";

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
            var result = saveDialog.ShowDialog();
            path = saveDialog.FileName;

            this.Title = System.IO.Path.GetFileName(saveDialog.FileName);



            if (result == true)
            {
                SaveAs(saveDialog);
            }
        }

        void MainWindow_Closing(object sender, CancelEventArgs e)
        {

            if (textBox.Text.Equals(line))
            {
                Environment.Exit(0);

            }

            if (textBox.Text != "" || this.Title != "Untitled Document")
            { 
            MessageBoxResult result = MessageBox.Show("You have unsaved data, do you want to save?", "Unsaved progress!", MessageBoxButton.YesNoCancel, MessageBoxImage.Warning);
            if(result == MessageBoxResult.Cancel)
            {
                    e.Cancel = true;
            }
            else if (result == MessageBoxResult.No)
            {
                    Environment.Exit(0);

            }
            else
            {

                    if (this.Title == "Untitled Document" || this.Title == "")
                    {
                        var result1 = saveDialog.ShowDialog();
                        this.Title = System.IO.Path.GetFileName(saveDialog.FileName);

                        if (result1 == true)
                        {
                            SaveAs(saveDialog);
                        }
                    }
                    else
                    {
                        Save();
                    }
                }
            }


        }

        public void Save()
        {
            line = textBox.Text;
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(textBox.Text);
            }
        }

        public void SaveAs(SaveFileDialog dialog)
        {
            line = textBox.Text;

            using (StreamWriter sw = new StreamWriter(dialog.FileName))
            {
                sw.WriteLine(textBox.Text);
            }
        }

        private void textBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            int row = textBox.GetLineIndexFromCharacterIndex(textBox.CaretIndex);
            int col = textBox.CaretIndex - textBox.GetCharacterIndexFromLineIndex(row);
            textBlock.Text = "Line " + (row + 1) + ", Char " + (col + 1);
        }
    }
}