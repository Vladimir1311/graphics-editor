using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace graphics_editor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /*
         * Отрисовка линии
         */
        void Draw_line(object sender, RoutedEventArgs e)
        {
            Line MyLine = new Line();
            MyLine.X1 = 1;// BeginPoint.X;
            MyLine.Y1 = 1;// BeginPoint.Y;
            MyLine.X2 = 35;// EndPoint.X;
            MyLine.Y2 = 50;// EndPoint.Y;
            MyLine.Stroke = System.Windows.Media.Brushes.Black;
            MyLine.StrokeThickness = 1;
            /*MyLine.HorizontalAlignment = HorizontalAlignment.Left;
            MyLine.VerticalAlignment = VerticalAlignment.Center;*/
            t.Children.Add(MyLine);
        }

        /*
         * Отрисовка прямоугольника
         */
        void Draw_rectangle(object sender, RoutedEventArgs e)
        {
        }
    }
}