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

            var st = new ScaleTransform();
            canvas.RenderTransform = st;
            canvas.MouseWheel += (sender, e) =>
            {
                if (e.Delta > 0)
                {
                    st.ScaleX *= 1.05;
                    st.ScaleY *= 1.05;
                }
                else
                {
                    st.ScaleX /= 1.05;
                    st.ScaleY /= 1.05;
                }
            };
        }


        /*
         * Отрисовка линии
         */
        private void Draw_line(object sender, RoutedEventArgs e)
        {
            LineGeometry MyLine = new LineGeometry();
            Window_draw_line dlg = new Window_draw_line();
            if (dlg.ShowDialog() == true)
            {
                Path myPath = new Path();

                //цвет линии
                if (checkBox_stroke_green_color.IsChecked == true)
                {
                    checkBox_fill_red_color.IsChecked = false;
                    checkBox_fill_black_color.IsChecked = false;
                    myPath.Stroke = Brushes.Green;
                }
                else if (checkBox_stroke_red_color.IsChecked == true)
                {
                    checkBox_fill_green_color.IsChecked = false;
                    checkBox_fill_black_color.IsChecked = false;
                    myPath.Stroke = Brushes.Red;
                }
                else if (checkBox_stroke_black_color.IsChecked == true)
                {
                    checkBox_fill_green_color.IsChecked = false;
                    checkBox_fill_red_color.IsChecked = false;
                    myPath.Stroke = Brushes.Black;
                }

                //толщина линии
                if(checkBox_StrokeThickness_0.IsChecked == true)
                {
                    myPath.StrokeThickness = 0;
                }
                else if (checkBox_StrokeThickness_1.IsChecked == true)
                {
                    myPath.StrokeThickness = 1;
                }
                else if (checkBox_StrokeThickness_2.IsChecked == true)
                {
                    myPath.StrokeThickness = 2;
                }
                else if (checkBox_StrokeThickness_3.IsChecked == true)
                {
                    myPath.StrokeThickness = 3;
                }
                else if (checkBox_StrokeThickness_4.IsChecked == true)
                {
                    myPath.StrokeThickness = 4;
                }
                else if (checkBox_StrokeThickness_5.IsChecked == true)
                {
                    myPath.StrokeThickness = 5;
                }
                MyLine.StartPoint = new Point(Convert.ToInt32(dlg.ittem_x1.Text), 
                    Convert.ToInt32(dlg.ittem_y1.Text));
                MyLine.EndPoint = new Point(Convert.ToInt32(dlg.ittem_x2.Text), 
                    Convert.ToInt32(dlg.ittem_y2.Text));
                myPath.Data = MyLine;
                canvas.Children.Add(myPath);
            }
        }


        /*
         * Отрисовка прямоугольника
         */
        private void Draw_rectangle(object sender, RoutedEventArgs e)
        {
            RectangleGeometry rectangle = new RectangleGeometry();
            Window_Draw_rectangle dlg = new Window_Draw_rectangle();
            if (dlg.ShowDialog() == true)
            {
                rectangle.Rect = new Rect(Convert.ToInt32(dlg.x_begin.Text),
                    Convert.ToInt32(dlg.y_begin.Text),
                    Convert.ToInt32(dlg.width_textbox.Text),
                    Convert.ToInt32(dlg.height_textbox.Text));
                Path myPath = new Path();

                //цвет заливки
                if(checkBox_fill_green_color.IsChecked == true)
                {
                    checkBox_fill_red_color.IsChecked = false;
                    checkBox_fill_black_color.IsChecked = false;
                    myPath.Fill = Brushes.Green;
                }
                else if(checkBox_fill_red_color.IsChecked == true)
                {
                    checkBox_fill_green_color.IsChecked = false;
                    checkBox_fill_black_color.IsChecked = false;
                    myPath.Fill = Brushes.Red;
                }
                else if(checkBox_fill_black_color.IsChecked == true)
                {
                    checkBox_fill_green_color.IsChecked = false;
                    checkBox_fill_red_color.IsChecked = false;
                    myPath.Fill = Brushes.Black;
                }

                //цвет линии
                if (checkBox_stroke_green_color.IsChecked == true)
                {
                    checkBox_fill_red_color.IsChecked = false;
                    checkBox_fill_black_color.IsChecked = false;
                    myPath.Stroke = Brushes.Green;
                }
                else if (checkBox_stroke_red_color.IsChecked == true)
                {
                    checkBox_fill_green_color.IsChecked = false;
                    checkBox_fill_black_color.IsChecked = false;
                    myPath.Stroke = Brushes.Red;
                }
                else if (checkBox_stroke_black_color.IsChecked == true)
                {
                    checkBox_fill_green_color.IsChecked = false;
                    checkBox_fill_red_color.IsChecked = false;
                    myPath.Stroke = Brushes.Black;
                }

                //толщина линии
                if (checkBox_StrokeThickness_0.IsChecked == true)
                {
                    myPath.StrokeThickness = 0;
                }
                else if (checkBox_StrokeThickness_1.IsChecked == true)
                {
                    myPath.StrokeThickness = 1;
                }
                else if (checkBox_StrokeThickness_2.IsChecked == true)
                {
                    myPath.StrokeThickness = 2;
                }
                else if (checkBox_StrokeThickness_3.IsChecked == true)
                {
                    myPath.StrokeThickness = 3;
                }
                else if (checkBox_StrokeThickness_4.IsChecked == true)
                {
                    myPath.StrokeThickness = 4;
                }
                else if (checkBox_StrokeThickness_5.IsChecked == true)
                {
                    myPath.StrokeThickness = 5;
                }
                myPath.Data = rectangle;
                canvas.Children.Add(myPath);
            }
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
                myEllipseGeometry.Center = new Point(Convert.ToInt32
                (dlg.x1_begin.Text), Convert.ToInt32(dlg.y1_begin.Text));
                myEllipseGeometry.RadiusX = Convert.ToInt32(dlg.x1_center.Text);
                myEllipseGeometry.RadiusY = Convert.ToInt32(dlg.y1_center.Text);
                Path myPath = new Path();

                //цвет заливки
                if(checkBox_fill_green_color.IsChecked == true)
                {
                    checkBox_fill_red_color.IsChecked = false;
                    checkBox_fill_black_color.IsChecked = false;
                    myPath.Fill = Brushes.Green;
                }
                else if (checkBox_fill_red_color.IsChecked == true)
                {
                    checkBox_fill_green_color.IsChecked = false;
                    checkBox_fill_black_color.IsChecked = false;
                    myPath.Fill = Brushes.Red;
                }
                else if (checkBox_fill_black_color.IsChecked == true)
                {
                    checkBox_fill_green_color.IsChecked = false;
                    checkBox_fill_red_color.IsChecked = false;
                    myPath.Fill = Brushes.Black;
                }

                //цвет линии
                if (checkBox_stroke_green_color.IsChecked == true)
                {
                    checkBox_fill_red_color.IsChecked = false;
                    checkBox_fill_black_color.IsChecked = false;
                    myPath.Stroke = Brushes.Green;
                }
                else if (checkBox_stroke_red_color.IsChecked == true)
                {
                    checkBox_fill_green_color.IsChecked = false;
                    checkBox_fill_black_color.IsChecked = false;
                    myPath.Stroke = Brushes.Red;
                }
                else if (checkBox_stroke_black_color.IsChecked == true)
                {
                    checkBox_fill_green_color.IsChecked = false;
                    checkBox_fill_red_color.IsChecked = false;
                    myPath.Stroke = Brushes.Black;
                }

                //толщина линии
                if (checkBox_StrokeThickness_0.IsChecked == true)
                {
                    myPath.StrokeThickness = 0;
                }
                else if (checkBox_StrokeThickness_1.IsChecked == true)
                {
                    myPath.StrokeThickness = 1;
                }
                else if (checkBox_StrokeThickness_2.IsChecked == true)
                {
                    myPath.StrokeThickness = 2;
                }
                else if (checkBox_StrokeThickness_3.IsChecked == true)
                {
                    myPath.StrokeThickness = 3;
                }
                else if (checkBox_StrokeThickness_4.IsChecked == true)
                {
                    myPath.StrokeThickness = 4;
                }
                else if (checkBox_StrokeThickness_5.IsChecked == true)
                {
                    myPath.StrokeThickness = 5;
                }
                myPath.Data = myEllipseGeometry;
                canvas.Children.Add(myPath);
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
                "геометрических фигур.");
        }


        /*
         * Очистить canvas
         */
        private void Clear_canvas(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
        }


        /*
         * Canvas
         */
        private void Canvas_Click(object sender, MouseButtonEventArgs e)
        {
            /*
             * Ластик через нажатие кнопки мыши
             */
            if (checkBox_erase.IsChecked == true)
            {
                EllipseGeometry myEllipseGeometry = new EllipseGeometry();
                myEllipseGeometry.RadiusX = Slider_erase.Value;
                myEllipseGeometry.RadiusY = Slider_erase.Value;
                Path myPath = new Path();
                Point p = e.GetPosition(this);
                myEllipseGeometry.Center = new Point(p.X, p.Y);
                myPath.Fill = this.canvas.Background;
                myPath.Data = myEllipseGeometry;
                canvas.Children.Add(myPath);
            }
        }


        /*
         * Создать
         */
        private void MenuItem_ClickNew(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Здесь будет реализовано создание нового файла");
            using (System.IO.FileStream fs = System.IO.File.Create(
                @"C:\Users\gd\Desktop\JPG\new.jpg"))
            {
                canvas.Children.Clear();
            }
        }


        /*
         * Открыть
         */
        private void MenuItem_ClickOpen(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Здесь буде реализовано открытие файла!!");
            System.Windows.Forms.OpenFileDialog open_dialog = new
                System.Windows.Forms.OpenFileDialog();
            open_dialog.Filter = "bmp рисунок (*.bmp)|*.bmp|" +
                "Jpg рисунок (*.jpg, *.jpeg)|*.jpg; *.jpeg|" + 
                "Png рисунок (*.png)|*.png";
            MessageBox.Show("Здесь будет реализовано открытие файла");
            if (open_dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string file_name = open_dialog.FileName;
                string path = System.IO.Path.GetFullPath(file_name);
                MessageBox.Show("Имя файла: "+ file_name +
                    "\nПуть файла: "+path);
                //ImageBrush img = new ImageBrush(path);
                /*BitmapImage myBitmapImage1 = new BitmapImage();
                myBitmapImage1.BeginInit();
                myBitmapImage1.UriSource = new Uri(path, UriKind.Absolute);
                myBitmapImage1.EndInit();
                Image1.Source = myBitmapImage1;*/
            }
        }


        /*
         * Сохранить
         */
        private void MenuItem_ClickSave(object sender, RoutedEventArgs e)
        {
            string path_save = @"C:\Users\gd\Desktop\new.jpg";
            RenderTargetBitmap bmpSource = new RenderTargetBitmap
                ((int)canvas.ActualWidth, (int)canvas.ActualHeight, 
                96, 96, PixelFormats.Pbgra32);
            bmpSource.Render(canvas);
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.QualityLevel = 100;
            encoder.Frames.Add(BitmapFrame.Create(bmpSource));
            using (System.IO.Stream stream = System.IO.File.Create(path_save))
            {
                encoder.Save(stream);
                MessageBox.Show("Файл успешно сохранен!");
            }
        }


        /*
         * Сохранить как
         */
        private void MenuItem_ClickSavaAs(object sender, RoutedEventArgs e)
        {
            RenderTargetBitmap bmpSource = new RenderTargetBitmap
                ((int)canvas.ActualWidth, (int)canvas.ActualHeight,
                96, 96, PixelFormats.Pbgra32);
            bmpSource.Render(canvas);
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.QualityLevel = 100;
            encoder.Frames.Add(BitmapFrame.Create(bmpSource));
            System.Windows.Forms.SaveFileDialog saveFileDialog1 
                = new System.Windows.Forms.SaveFileDialog();
            saveFileDialog1.Filter = "bmp рисунок (*.bmp)|*.bmp|" +
                "Jpg рисунок (*.jpg, *.jpeg)|*.jpg; *.jpeg|" +
                "Png рисунок (*.png)|*.png";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path_save = saveFileDialog1.FileName;
                using (System.IO.Stream stream = System.IO.File.Create(
                    path_save))
                {
                    encoder.Save(stream);
                    MessageBox.Show("Файл успешно сохранен!");
                }
            }
        }
    }
}