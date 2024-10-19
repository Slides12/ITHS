using _5.Windows;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SolidColorBrush selectedColor = new SolidColorBrush();
        OpenFileDialog dialog = new OpenFileDialog();
        SaveFileDialog saveDialog = new SaveFileDialog();
        private string openFile = "";
        private int numberOfPalletes = 8;
        private int sizeOfPainting = 100;


        public MainWindow()
        {
            InitializeComponent();
            SetColumnAndRowDefinitions();
            FillGridWRectangles();
            SetColorPalettes();

        }

        private void colourButton_Click(object sender, RoutedEventArgs e)
        {
            ColorWindow colorWindow = new ColorWindow();
            colorWindow.ShowDialog();
        }

        private void SelectColorPallette_Click(object sender, MouseButtonEventArgs e)
        {
            ColorWindow colorWindow = new ColorWindow();
            colorWindow.ShowDialog();
            if(colorWindow.DialogResult == true) {
            selectedColor = colorWindow.MySolidColorBrush;
            (sender as Rectangle).Fill = selectedColor;
            }
        }

        private void SetColumnAndRowDefinitions()
        {
            for(int i = 0; i < sizeOfPainting;i++)
            {
                ColumnDefinition columnDefinition = new ColumnDefinition();
                RowDefinition rowDefinition = new RowDefinition();
                columnDefinition.Width = new GridLength(80, GridUnitType.Star);
                rowDefinition.Height = new GridLength(80, GridUnitType.Star);

                paintGrid.ColumnDefinitions.Add(columnDefinition);
                paintGrid.RowDefinitions.Add(rowDefinition);

            }
        }

        private void FillGridWRectangles()
        {
            paintGrid.Children.Clear();
            for (int i = 0; i < sizeOfPainting; i++)
            {
                for (int j = 0; j < sizeOfPainting; j++)
                {
                Rectangle rect = new Rectangle();
                rect.StrokeThickness = .1;
                rect.Stroke = new SolidColorBrush(Colors.Black);
                rect.Fill = new SolidColorBrush(Colors.LightGray);
                rect.MouseLeftButtonDown += PaintTheRectangle_Click;
                rect.MouseMove += PaintWhile_moveMouse;
                paintGrid.Children.Add(rect);
                Grid.SetRow(rect, i);
                Grid.SetColumn(rect, j);
                }
            }
        }

        private void PaintWhile_moveMouse(object sender, MouseEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed) { 
            (sender as Rectangle).Fill = selectedColor;
            }

        }

        private void SetColorPalettes()
        {
            for (int i = 0; i < numberOfPalletes; i++)
            {

                Rectangle rect = new Rectangle();
                rect.StrokeThickness = 1;
                rect.Fill = new SolidColorBrush(Colors.Beige);
                rect.Stroke = new SolidColorBrush(Colors.Black);
                rect.Width = 50;
                rect.Height = 50;
                rect.MouseRightButtonDown += SelectColorPallette_Click;
                rect.MouseLeftButtonDown += SelectedPallette_Click;
                stackPanel.Children.Add(rect);
            }
        }

        private void PaintTheRectangle_Click(object sender, MouseButtonEventArgs e)
        {
            (sender as Rectangle).Fill = selectedColor;
        }

        private void SelectedPallette_Click(object sender, MouseButtonEventArgs e)
        {
            foreach (var child in stackPanel.Children)
            {
                if(child is Rectangle rect) { 
                rect.StrokeThickness = 1;
                }
            }

            (sender as Rectangle).StrokeThickness = 2;

            selectedColor = (sender as Rectangle).Fill as SolidColorBrush;
        }

        private void menuNewButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void menuOpenButton_Click(object sender, RoutedEventArgs e)
        {
            var result = dialog.ShowDialog();
            this.Title = System.IO.Path.GetFileName(saveDialog.FileName);
            byte[] rgbByte = Load(dialog);
            int index = 0;

            for (int i = 0; i < rgbByte.Length; i+=3)
            {
                if (i<numberOfPalletes * 3) { 
                //Debug.WriteLine(rgbByte[i]);
                byte r = rgbByte[i];     
                byte g = rgbByte[i + 1]; 
                byte b = rgbByte[i + 2];
                Color color = new Color() { A = 255, R = r, G = g, B = b };
                (stackPanel.Children[index] as Rectangle).Fill = new SolidColorBrush(color);
                }
                else
                {
                    byte r = rgbByte[i];
                    byte g = rgbByte[i + 1];
                    byte b = rgbByte[i + 2];
                    Color color = new Color() { A = 255, R = r, G = g, B = b };
                    (paintGrid.Children[index - numberOfPalletes] as Rectangle).Fill = new SolidColorBrush(color);
                }
                index++;
            }


        }

        private void menuExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Close();

        }


        private void menuSaveButton_Click(object sender, RoutedEventArgs e)
        {
            var result = saveDialog.ShowDialog();
            this.Title = System.IO.Path.GetFileName(saveDialog.FileName);
            
                Save(saveDialog);
           
        }

        public void Save(SaveFileDialog dialog)
        {
            using (FileStream stream = new FileStream(dialog.FileName, FileMode.Create))
            {
                foreach (var item in stackPanel.Children)
                {
                    if(item != null) { 
                    byte r = ((item as Rectangle)?.Fill as SolidColorBrush).Color.R;
                    byte g = ((item as Rectangle)?.Fill as SolidColorBrush).Color.G;
                    byte b = ((item as Rectangle)?.Fill as SolidColorBrush).Color.B;
                        stream.WriteByte(r);
                        stream.WriteByte(g);
                        stream.WriteByte(b);

                    }

                    //sw.Write(StringToBinary(((item as Rectangle)?.Fill as SolidColorBrush).Color);
                }


                foreach (var item in paintGrid.Children)
                {
                    if (item != null)
                    {
                        byte r = ((item as Rectangle)?.Fill as SolidColorBrush).Color.R;
                        byte g = ((item as Rectangle)?.Fill as SolidColorBrush).Color.G;
                        byte b = ((item as Rectangle)?.Fill as SolidColorBrush).Color.B;
                        stream.WriteByte(r);
                        stream.WriteByte(g);
                        stream.WriteByte(b);

                    }

                }

            }
        }


        public byte[] Load(OpenFileDialog dialog)
        {
            return File.ReadAllBytes(dialog.FileName);
        }


        public string StringToBinary(string data)
        {
            StringBuilder sb = new StringBuilder();
            if(data != null) { 
            foreach (char c in data.ToCharArray())
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }

        public static string BinaryToString(string data)
        {
            List<Byte> byteList = new List<Byte>();

            for (int i = 0; i < data.Length; i += 8)
            {
                byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));
            }
            return Encoding.ASCII.GetString(byteList.ToArray());
        }

    }
}