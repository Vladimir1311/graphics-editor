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
using System.Windows.Navigation;


namespace graphics_editor
{
    /// <summary>
    /// Логика взаимодействия для Stroke_Thickness.xaml
    /// </summary>
    public partial class Stroke_Thickness : Window
    {
        /*public Dictionary<string, Path> stroke_thinkness = 
            new Dictionary<string, Path>();
        public Path SelectedStrokeThinkness { get; private set; }*/
        public Stroke_Thickness()
        {
            InitializeComponent();
            //Толщина линии
            /*stroke_thinkness.Add("Красный", Colors.Red);
            stroke_thinkness.Add("Зеленый", Colors.Green);
            stroke_thinkness.Add("Чёрный", Colors.Black);
            stroke_thinkness.Add("Синий", Colors.Blue);
            stroke_thinkness.Add("Коричневый", Colors.Brown);
            stroke_thinkness.Add("Оранжевый", Colors.Orange);
            stroke_thinkness.Add("Белый", Colors.White);
            stroke_thinkness.Add("Жёлтый", Colors.Yellow);*/
        }

        /*
        * Checked
        */
        public void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            MessageBox.Show(pressed.Content.ToString());
            //SelectedStrokeThinkness = stroke_thinkness[pressed.Content.ToString()];
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
