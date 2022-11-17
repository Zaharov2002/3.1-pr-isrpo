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

namespace _3._1_pr_isrpo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int summ;
        private void Button1(object sender, RoutedEventArgs e)
        {
            int s1;
            s1 = Convert.ToInt32(TextBox1.Text);
            summ = s1 + 3;
            TextBox1.Text = summ.ToString();
        }

        private void Button2(object sender, RoutedEventArgs e)
        {
            int s1;
            s1 = Convert.ToInt32(TextBox1.Text);
            summ = s1 + 2;
            TextBox1.Text = summ.ToString();
        }

        private void Button3(object sender, RoutedEventArgs e)
        {
            int s1;
            s1 = Convert.ToInt32(TextBox1.Text);
            summ = s1 + 1;
            TextBox1.Text = summ.ToString();
        }

        private void Button4(object sender, RoutedEventArgs e)
        {
            int s1;
            s1 = Convert.ToInt32(TextBox1.Text);
            summ = s1 - 1;
            TextBox1.Text = summ.ToString();
        }

        private void Button5(object sender, RoutedEventArgs e)
        {
            int s1;
            s1 = Convert.ToInt32(TextBox1.Text);
            summ = s1 - 2;
            TextBox1.Text = summ.ToString();
        }

        private void Button6(object sender, RoutedEventArgs e)
        {
            int s1;
            s1 = Convert.ToInt32(TextBox1.Text);
            summ = s1 - 3;
            TextBox1.Text = summ.ToString();
        }

        private void Button7(object sender, RoutedEventArgs e)
        {
            int s1;
            s1 = Convert.ToInt32(TextBox2.Text);
            summ = s1 + 3;
            TextBox2.Text = summ.ToString();
        }

        private void Button8(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(TextBox2.Text);
            summ = cvn1 + 2;
            TextBox2.Text = summ.ToString();

        }

        private void Button9(object sender, RoutedEventArgs e)
        {
            int s1;
            s1 = Convert.ToInt32(TextBox2.Text);
            summ = s1 + 1;
            TextBox2.Text = summ.ToString();

        }

        private void Button10(object sender, RoutedEventArgs e)
        {
            int s1;
            s1 = Convert.ToInt32(TextBox2.Text);
            summ = s1 - 1;
            TextBox2.Text = summ.ToString();

        }

        private void Button11(object sender, RoutedEventArgs e)
        {
            int s1;
            s1 = Convert.ToInt32(TextBox2.Text);
            summ = s1 - 2;
            TextBox2.Text = summ.ToString();

        }

        private void Button12(object sender, RoutedEventArgs e)
        {
            int s1;
            s1 = Convert.ToInt32(TextBox2.Text);
            summ = s1 - 3;
            TextBox2.Text = summ.ToString();

        }

        private void Button13(object sender, RoutedEventArgs e)
        {
            int s1;
            s1 = Convert.ToInt32(TextBox3.Text);
            summ = s1 + 3;
            TextBox3.Text = summ.ToString();

        }

        private void Button14(object sender, RoutedEventArgs e)
        {
            int s1;
            s1 = Convert.ToInt32(TextBox3.Text);
            summ = s1 + 2;
            TextBox3.Text = summ.ToString();

        }

        private void Button15(object sender, RoutedEventArgs e)
        {
            int s1;
            s1 = Convert.ToInt32(TextBox3.Text);
            summ = s1 + 1;
            TextBox3.Text = summ.ToString();

        }

        private void Button16(object sender, RoutedEventArgs e)
        {
            int s1;
            s1 = Convert.ToInt32(TextBox3.Text);
            summ = s1 - 1;
            TextBox3.Text = summ.ToString();

        }

        private void Button17(object sender, RoutedEventArgs e)
        {
            int s1;
            s1 = Convert.ToInt32(TextBox3.Text);
            summ = s1 - 2;
            TextBox3.Text = summ.ToString();

        }

        private void Button18(object sender, RoutedEventArgs e)
        {
            int s1;
            s1 = Convert.ToInt32(TextBox3.Text);
            summ = s1 - 3;
            TextBox3.Text = summ.ToString();
        }
    }
}

