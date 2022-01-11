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

namespace Content
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rate.Text);
            double sumEuro = Convert.ToDouble(sum.Text);
            double result = rateEuro* sumEuro;
            ressum.Text = result.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rate1.Text);
            double sumEuro = Convert.ToDouble(sum1.Text);
            double result = rateEuro * sumEuro;
            ressum1.Text = result.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateGr = Convert.ToDouble(rate2.Text);
            double sumGr = Convert.ToDouble(sum2.Text);
            double result = rateGr * sumGr;
            ressum2.Text = result.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double ratePound = Convert.ToDouble(rate3.Text);
            double sumPound = Convert.ToDouble(sum3.Text);
            double result = ratePound * sumPound;
            ressum3.Text = result.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double rateD = Convert.ToDouble(rate4.Text);
            double result = rateD * 0.025;
            ressum4.Text = result.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double rateF = Convert.ToDouble(rate5.Text);
            double result = rateF * 0.3;
            ressum5.Text = result.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double rateM = Convert.ToDouble(rate6.Text);
            double result = rateM * 1609;
            ressum6.Text = result.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double rateV = Convert.ToDouble(rate7.Text);
            double result = rateV * 1067;
            ressum7.Text = result.ToString();
        }
    }
}
