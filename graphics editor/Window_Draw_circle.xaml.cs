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
using System.Windows.Shapes;
using Xceed.Wpf.Toolkit;

namespace graphics_editor
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window_Draw_circle : Window
    {
        public Window_Draw_circle()
        {
            InitializeComponent();
        }

        /*
         * Ок
         */
        void okButton_Click(object sender, RoutedEventArgs e)
        {
            int x1, x2, y1, y2;
            x1 = Convert.ToInt32(x1_begin.Text);
            x2 = Convert.ToInt32(x1_center.Text);
            y1 = Convert.ToInt32(y1_begin.Text);
            y2 = Convert.ToInt32(y1_center.Text);
            this.DialogResult = true;
        }

        /*
         * Cancel
         */
        public void Cancel_click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        /*
         * textbox x_begin
         */ 
        private void TextBox_PreviewTextInput_x1_begin(object sender, 
            TextCompositionEventArgs e)
        {
            foreach (char ch in e.Text)
                if (!char.IsDigit(ch))
                {
                    e.Handled = true;
                    return;
                }
        }

        /*
         * for x_begin
         */ 
        private void TextBox_PreviewKeyDown_x1_begin(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
        }

        /*
         * textbox y_begin
         */
        private void TextBox_PreviewTextInput_y1_begin(object sender,
            TextCompositionEventArgs e)
        {
            foreach (char ch in e.Text)
                if (!char.IsDigit(ch))
                {
                    e.Handled = true;
                    return;
                }
        }

        /*
         * for y_begin
         */
        private void TextBox_PreviewKeyDown_y1_begin(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
        }

        /*
         * textbox x_center
         */
        private void TextBox_PreviewTextInput_x1_center(object sender,
            TextCompositionEventArgs e)
        {
            foreach (char ch in e.Text)
                if (!char.IsDigit(ch))
                {
                    e.Handled = true;
                    return;
                }
        }

        /*
         * for x_center
         */
        private void TextBox_PreviewKeyDown_x1_center(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
        }

        /*
         * textbox y_center
         */
        private void TextBox_PreviewTextInput_y1_center(object sender,
            TextCompositionEventArgs e)
        {
            foreach (char ch in e.Text)
                if (!char.IsDigit(ch))
                {
                    e.Handled = true;
                    return;
                }
        }

        /*
         * for y_center
         */
        private void TextBox_PreviewKeyDown_y1_center(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
        }
    }
}
