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
            LineGeometry MyLine = new LineGeometry();
            MyLine.StartPoint = new Point(1, 1);
            MyLine.EndPoint = new Point(50, 40);
            Path myPath = new Path();
            myPath.Stroke = Brushes.Black;
            myPath.StrokeThickness = 1;
            myPath.Data = MyLine;
            t.Children.Add(myPath);
        }

        /*
         * Отрисовка прямоугольника
         */
        void Draw_rectangle(object sender, RoutedEventArgs e)
        {
            RectangleGeometry rectangle = new RectangleGeometry();
            rectangle.Rect = new Rect(1, 50, 60, 40);
            Path myPath = new Path();
            myPath.Fill = Brushes.LemonChiffon;
            myPath.Stroke = Brushes.Red;
            myPath.StrokeThickness = 2;
            myPath.Data = rectangle;
            t.Children.Add(myPath);
        }

        /*
         * Отрисовка круга
         */
        void Draw_elipse(object sender, RoutedEventArgs e)
        {
            Path myPath = new Path();
            myPath.Stroke = Brushes.Green;
            //myPath.Fill = Brushes.MediumSlateBlue;
            myPath.StrokeThickness = 3;
            EllipseGeometry myEllipseGeometry = new EllipseGeometry();
            myEllipseGeometry.Center = new Point(44, 140);
            myEllipseGeometry.RadiusX = 40;
            myEllipseGeometry.RadiusY = 40;
            myPath.Data = myEllipseGeometry;
            t.Children.Add(myPath);
        }


        /*
         * Отрисовка неизвестного
         */
        void Draw_dont_know(object sender, RoutedEventArgs e)
        {
            Path myPath = new Path();
            myPath.Stroke = Brushes.Black;
            //myPath.Fill = Brushes.MediumSlateBlue;
            myPath.StrokeThickness = 3;
            EllipseGeometry myEllipseGeometry = new EllipseGeometry();
            myEllipseGeometry.Center = new Point(44, 120);
            myEllipseGeometry.RadiusX = 40;
            myEllipseGeometry.RadiusY = 40;
            myPath.Data = myEllipseGeometry;
            t.Children.Add(myPath);
        }
    }
}