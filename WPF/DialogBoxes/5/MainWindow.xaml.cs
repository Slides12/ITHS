using _5.Windows;
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

        public MainWindow()
        {
            InitializeComponent();
            FillGridWRectangles();
            SetColorPalettes();

        }

        private void colourButton_Click(object sender, RoutedEventArgs e)
        {
            ColorWindow colorWindow = new ColorWindow();
            colorWindow.ShowDialog();
        }

        private void rec1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ColorWindow colorWindow = new ColorWindow();
            colorWindow.ShowDialog();
            if(colorWindow.DialogResult == true) {
            selectedColor = colorWindow.MySolidColorBrush;
            (sender as Rectangle).Fill = selectedColor;
            }
        }

        private void FillGridWRectangles()
        {
            paintGrid.Children.Clear();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                Rectangle rect = new Rectangle();
                rect.StrokeThickness = 1;
                rect.Stroke = new SolidColorBrush(Colors.Black);
                rect.Fill = new SolidColorBrush(Colors.White);
                rect.MouseLeftButtonDown += rec1_MouseLeftButtonDown_1;
                
                paintGrid.Children.Add(rect);
                Grid.SetRow(rect, i);
                Grid.SetColumn(rect, j);
                }
            }
        }

        private void SetColorPalettes()
        {
            for (int i = 0; i < 8; i++)
            {

                Rectangle rect = new Rectangle();
                rect.StrokeThickness = 1;
                rect.Fill = new SolidColorBrush(Colors.Beige);
                rect.Stroke = new SolidColorBrush(Colors.Black);
                rect.Width = 50;
                rect.Height = 50;
                rect.MouseRightButtonDown += rec1_MouseLeftButtonDown;
                rect.MouseLeftButtonDown += rec1_MouseLeftButtonDown_2;
                stackPanel.Children.Add(rect);
            }
        }

        private void rec1_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            (sender as Rectangle).Fill = selectedColor;
        }

        private void rec1_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
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
    }
}