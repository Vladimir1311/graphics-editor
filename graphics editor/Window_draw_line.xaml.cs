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
    public partial class Window_draw_line : Window
    {
        /*
         * Инициализация
         */ 
        public Window_draw_line()
        {
            InitializeComponent();
        }

        /*
         * textbox ittem_x1
         */ 
        private void TextBox_PreviewTextInput_x1(object sender, 
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
         * for ittem_x1
         */ 
        private void TextBox_PreviewKeyDown_x1(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
        }

        /*
         * textbox ittem_y1
         */
        private void TextBox_PreviewTextInput_y1(object sender,
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
         * for ittem_y1
         */
        private void TextBox_PreviewKeyDown_y1(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
        }

        /*
        * textbox ittem_x2
        */
        private void TextBox_PreviewTextInput_x2(object sender,
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
         * for ittem_x2
         */
        private void TextBox_PreviewKeyDown_x2(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
        }

        /*
         * textbox ittem_y2
         */
        private void TextBox_PreviewTextInput_y2(object sender,
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
         * for ittem_y2
         */
        private void TextBox_PreviewKeyDown_y2(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
        }

        /*
         * Ок
         */
        void okButton_Click(object sender, RoutedEventArgs e)
        {
            int x1, x2, y1, y2;
            x1 = Convert.ToInt32(ittem_x1.Text);
            x2 = Convert.ToInt32(ittem_x2.Text);
            y1 = Convert.ToInt32(ittem_y1.Text);
            y2 = Convert.ToInt32(ittem_y2.Text);
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