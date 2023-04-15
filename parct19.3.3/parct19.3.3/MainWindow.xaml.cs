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

namespace parct19._3._3
{
    
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
            if (oneNum.IsChecked) { x = 1; } else  if(twoNums.IsChecked){ x = 2; } else if (threeNums.IsChecked) { x = 3; } else if(fourNums.IsChecked) { x = 4; }
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
