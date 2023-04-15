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

namespace pract20._5._3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DivisionOfNumbers calc = new DivisionOfNumbers();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void resultButton_Click(object sender, RoutedEventArgs e)
        {
            int x = 0;
            if (oneNum.IsChecked == true) { x = 1; } else if (twoNums.IsChecked == true) { x = 2; } else if (threeNums.IsChecked == true) { x = 3; } else if (fourNums.IsChecked == true) { x = 4; }
            if (firstNum.Text == "" || secondNum.Text == "")
            {
                MessageBox.Show("Error");
            }
            else
            result.Content = Convert.ToString(calc.Quotient(Convert.ToDouble(firstNum.Text), Convert.ToDouble(secondNum.Text), x));
        }

        private void oneNum_Checked(object sender, RoutedEventArgs e)
        {
            twoNums.IsChecked = false;
            threeNums.IsChecked = false;
            fourNums.IsChecked = false;
        }

        private void twoNums_Checked(object sender, RoutedEventArgs e)
        {
            oneNum.IsChecked = false;
            threeNums.IsChecked = false;
            fourNums.IsChecked = false;
        }

        private void threeNums_Checked(object sender, RoutedEventArgs e)
        {
            oneNum.IsChecked = false;
            twoNums.IsChecked = false;
            fourNums.IsChecked = false;
        }

        private void fourNums_Checked(object sender, RoutedEventArgs e)
        {
            oneNum.IsChecked = false;
            twoNums.IsChecked = false;
            threeNums.IsChecked = false;
        }
    }
}
