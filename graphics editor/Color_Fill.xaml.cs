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
    /// Логика взаимодействия для Color_Fill.xaml
    /// </summary>
    public partial class Color_Fill : Window
    {
        public Dictionary<string, Color> fill_color = 
            new Dictionary<string, Color>();
        public Color SelectedColorFill { get; private set; }
        public Color_Fill()
        {
            InitializeComponent();
            //цвета
            fill_color.Add("Красный", Colors.Red);
            fill_color.Add("Зеленый", Colors.Green);
            fill_color.Add("Чёрный", Colors.Black);
            fill_color.Add("Синий", Colors.Blue);
            fill_color.Add("Коричневый", Colors.Brown);
            fill_color.Add("Оранжевый", Colors.Orange);
            fill_color.Add("Белый", Colors.White);
            fill_color.Add("Жёлтый", Colors.Yellow);
        }

        /*
         * Checked
         */
        public void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            MessageBox.Show(pressed.Content.ToString());
            SelectedColorFill = fill_color[pressed.Content.ToString()];
        }


        /*
         * Ок
         */
        void okButton_Click(object sender, RoutedEventArgs e)
        {
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
