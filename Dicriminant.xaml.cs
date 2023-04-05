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

namespace WpfApp5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            a.MaxLength = 3;
            b.MaxLength = 3;
            c.MaxLength = 3;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double searchA = double.Parse(a.Text);
            double searchB = double.Parse(b.Text);
            double searchC = double.Parse(c.Text);

            double D, x, x1, x2;

            D = Math.Pow(searchB, 2) - 4 * searchA * searchC;

            if (D < 0)
                MessageBox.Show("Корней нет");
            if (D > 0)
            {
                result_x2.Visibility = Visibility.Visible;
                x1 = (-searchB + Math.Sqrt(D)) / (2 * searchA);
                x2 = (-searchB - Math.Sqrt(D)) / (2 * searchA);
                result_x1.Text = x1.ToString();
                result_x2.Text = x2.ToString();
            }
            if (D == 0)
            {
                x = -searchB / 2 * searchA;
                result_x1.Text = x.ToString();
            }
        }
        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void a_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Space)
                e.Handled = true;
        }

        private void a_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if(!Char.IsDigit(e.Text, 0))
                e.Handled= true;
        }


        private void b_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
                e.Handled = true;
        }

        private void b_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
        }

        private void c_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
                e.Handled = true;
        }

        private void c_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
        }
    }
}
