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
    public class Figure
    {
        Path myPath = new Path();
        public void get_fill_color()
        {
            MainWindow dlg = new MainWindow();
            //цвет заливки
            if (dlg.checkBox_fill_green_color.IsChecked == true)
            {
                dlg.checkBox_fill_red_color.IsChecked = false;
                dlg.checkBox_fill_black_color.IsChecked = false;
                myPath.Fill = Brushes.Green;
            }
            else if (dlg.checkBox_fill_red_color.IsChecked == true)
            {
                dlg.checkBox_fill_green_color.IsChecked = false;
                dlg.checkBox_fill_black_color.IsChecked = false;
                myPath.Fill = Brushes.Red;
            }
            else if (dlg.checkBox_fill_black_color.IsChecked == true)
            {
                dlg.checkBox_fill_green_color.IsChecked = false;
                dlg.checkBox_fill_red_color.IsChecked = false;
                myPath.Fill = Brushes.Black;
            }

            //цвет линии
            if (dlg.checkBox_stroke_green_color.IsChecked == true)
            {
                dlg.checkBox_fill_red_color.IsChecked = false;
                dlg.checkBox_fill_black_color.IsChecked = false;
                myPath.Stroke = Brushes.Green;
            }
            else if (dlg.checkBox_stroke_red_color.IsChecked == true)
            {
                dlg.checkBox_fill_green_color.IsChecked = false;
                dlg.checkBox_fill_black_color.IsChecked = false;
                myPath.Stroke = Brushes.Red;
            }
            else if (dlg.checkBox_stroke_black_color.IsChecked == true)
            {
                dlg.checkBox_fill_green_color.IsChecked = false;
                dlg.checkBox_fill_red_color.IsChecked = false;
                myPath.Stroke = Brushes.Black;
            }
            myPath.StrokeThickness = 1;
        }
    }
}
