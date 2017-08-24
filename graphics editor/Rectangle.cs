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
    public class Rectangle : Figure
    {
        /*public void get_fill_color():base
        {
            RectangleGeometry rectangle = new RectangleGeometry();
            Window_Draw_rectangle dlg = new Window_Draw_rectangle();
            if (dlg.ShowDialog() == true)
            {
                rectangle.Rect = new Rect(Convert.ToInt32(dlg.x_begin.Text),
                    Convert.ToInt32(dlg.y_begin.Text),
                    Convert.ToInt32(dlg.width_textbox.Text),
                    Convert.ToInt32(dlg.height_textbox.Text));
            }
            myPath.StrokeThickness = 1;
        }*/
    }
}
