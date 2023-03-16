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
            result_x1.IsReadOnly = true;
            result_x2.IsReadOnly = true;
            a.MaxLength = 3;
            b.MaxLength = 3;
            c.MaxLength = 3;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (a.Text != "" && b.Text != "" && c.Text != "")
            {
                int a1 = Convert.ToInt32(a.Text);
                int b1 = Convert.ToInt32(b.Text);
                int c1 = Convert.ToInt32(c.Text);
                int d = (b1 * b1) - (4 * a1 * c1);

                if (d > 0)
                {
                    double x1 = (-b1 + Math.Sqrt(d)) / (2 * a1);
                    double x2 = (-b1 - Math.Sqrt(d)) / (2 * a1);
                    result_x1.Text = x1.ToString();
                    result_x2.Text = x2.ToString();
                }
                else
                {
                    MessageBox.Show("Нет решений D < 0");
                }
            }
            else
            {
                MessageBox.Show("Error write");
            }
        }

        private void a_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0)) e.Handled = true;
        }

        private void b_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0)) e.Handled = true;
        }

        private void c_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0)) e.Handled = true;
        }
    }
}
