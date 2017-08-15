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
        private void Draw_line(object sender, RoutedEventArgs e)
        {
            LineGeometry MyLine = new LineGeometry();
            Window_draw_line dlg = new Window_draw_line();
            if(dlg.ShowDialog() == true)
            {
                MyLine.StartPoint = new Point(Convert.ToInt32(dlg.ittem_x1.Text),
                Convert.ToInt32(dlg.ittem_y1.Text));
                MyLine.EndPoint = new Point(Convert.ToInt32(dlg.ittem_x2.Text),
                    Convert.ToInt32(dlg.ittem_y2.Text));
                Path myPath = new Path();
                myPath.Stroke = Brushes.Black;
                myPath.StrokeThickness = 1;
                myPath.Data = MyLine;
                t.Children.Add(myPath);
            }
        }

        /*
         * Отрисовка прямоугольника
         */
        private void Draw_rectangle(object sender, RoutedEventArgs e)
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
        private void Draw_elipse(object sender, RoutedEventArgs e)
        {
            EllipseGeometry myEllipseGeometry = new EllipseGeometry();
            Window_Draw_circle dlg = new Window_Draw_circle();
            if (dlg.ShowDialog() == true)
            {
                /*myEllipseGeometry.Center = new Point(Convert.ToInt32
                    (dlg.x1_center.Text) + Convert.ToInt32(dlg.x1_begin.Text),
                    Convert.ToInt32(dlg.y1_center.Text) + 
                    Convert.ToInt32(dlg.y1_begin.Text));*/
                myEllipseGeometry.Center = new Point(Convert.ToInt32
                (dlg.x1_begin.Text), Convert.ToInt32(dlg.y1_begin.Text));
                myEllipseGeometry.RadiusX = Convert.ToInt32(dlg.x1_center.Text);
                myEllipseGeometry.RadiusY = Convert.ToInt32(dlg.y1_center.Text);
                Path myPath = new Path();
                myPath.Stroke = Brushes.Green;
                myPath.StrokeThickness = 3;
                myPath.Data = myEllipseGeometry;
                t.Children.Add(myPath);
            }
        }

        /*
         * Выход из программы
         */
        private void MenuItem_ClickExit(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        /*
         * О программе
         */
        private void MenuItem_ClickAbout(object sender, RoutedEventArgs e)
        {
            MenuItem menuItem = (MenuItem)sender;
            MessageBox.Show("О программе:" + "\n" +
                "Данный графический редактор предназначен для открытия " +
                "рисунков, а также для рисования несложных " +
                "геометрических фигур.";
                );
        }
    }
}