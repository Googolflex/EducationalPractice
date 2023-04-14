using System;
using System.Windows;

namespace pract9
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

        private void resultButton_Click(object sender, RoutedEventArgs e)
        {
            double reslt = 0;
            if (numBox.Text == "")
            {
                MessageBox.Show("err");
            }
            else
            {
                if (sqrtRB.IsChecked == true)
                {
                    reslt = Math.Sqrt(Convert.ToDouble(numBox.Text));
                }
                else if (sinRB.IsChecked == true)
                {
                    reslt = Math.Sin(Convert.ToDouble(numBox.Text));
                }
                else if (xButton.IsChecked == true)
                {
                    reslt = Convert.ToDouble(numBox.Text) + 1;
                }
                if (roundingCB.IsChecked == true)
                {
                    resultBox.Text = Convert.ToString(Math.Round(reslt, 2));
                }
                else
                {
                    resultBox.Text = Convert.ToString(reslt);
                }
            }
        }

        private void sqrtRB_Checked(object sender, RoutedEventArgs e)
        {
            if(sinRB.IsChecked == true || xButton.IsChecked == true)
            {
                sinRB.IsChecked = false;
                xButton.IsChecked = false;
            }
        }

        private void sinRB_Checked(object sender, RoutedEventArgs e)
        {
            if(sqrtRB.IsChecked == true || xButton.IsChecked == true)
            {
                sqrtRB.IsChecked= false;
                xButton.IsChecked= false;
            }
        }

        private void xButton_Checked(object sender, RoutedEventArgs e)
        {
            if(sinRB.IsChecked == true || sqrtRB.IsChecked == true)
            {
                sinRB.IsChecked= false;
                sqrtRB.IsChecked = false;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
