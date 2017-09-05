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
    /// Логика взаимодействия для Cololrs.xaml
    /// </summary>
    public partial class Cololrs : Window
    {
        public Dictionary<string, Color> map = new Dictionary<string, Color>();
        public Color SelectedColor { get; private set; }
        public Cololrs()
        {
            InitializeComponent();
            //цвета
            map.Add("Красный", Colors.Red);
            map.Add("Зеленый", Colors.Green);
            map.Add("Черный", Colors.Black);
            map.Add("Синий", Colors.Blue);
            map.Add("Коричневый", Colors.Brown);
            map.Add("Оранжевый", Colors.Orange);
            map.Add("Белый", Colors.White);
            map.Add("Жёлтый", Colors.Yellow);
        }


        /*
         * Checked
         */
        public void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            MessageBox.Show(pressed.Content.ToString());
            SelectedColor = map[pressed.Content.ToString()];
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
