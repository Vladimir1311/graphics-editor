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

namespace graphics_editor
{
    /// <summary>
    /// Логика взаимодействия для Window_Draw_rectangle.xaml
    /// </summary>
    public partial class Window_Draw_rectangle : Window
    {
        public Window_Draw_rectangle()
        {
            InitializeComponent();
        }

        /*
         * textbox height_textbox
         */
        private void TextBox_PreviewTextInput_height_textbox(object sender,
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
         * for height_textbox
         */
        private void TextBox_PreviewKeyDown_height_textbox(object sender, 
            KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
        }

        /*
         * textbox width_textbox
         */
        private void TextBox_PreviewTextInput_width_textbox(object sender,
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
         * for width_textbox
         */
        private void TextBox_PreviewKeyDown_width_textbox(object sender, 
            KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
        }

        /*
        * textbox y_begin
        */
        private void TextBox_PreviewTextInput_y_begin(object sender,
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
        private void TextBox_PreviewKeyDown_y_begin(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
        }

        /*
         * textbox x_begin
         */
        private void TextBox_PreviewTextInput_x_begin(object sender,
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
        private void TextBox_PreviewKeyDown_x_begin(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
        }

        /*
         * Ок
         */
        void okButton_Click(object sender, RoutedEventArgs e)
        {
            int x1, height, y1, width;
            x1 = Convert.ToInt32(x_begin.Text);
            height = Convert.ToInt32(height_textbox.Text);
            y1 = Convert.ToInt32(y_begin.Text);
            width = Convert.ToInt32(width_textbox.Text);
            this.DialogResult = true;
        }

        /*
         * Cancel
         */
        public void Cancel_click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
