using System;
using System.Windows;

namespace pract10
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
            if (numBox.Text == "")
            {
                MessageBox.Show("err");
            }
            else
            {
                if (((moreTh0.IsChecked == true && lessTh100.IsChecked == true && dividedBy3CH.IsChecked == true && evenCH.IsChecked == true) && (Convert.ToDouble(numBox.Text) > 0 && Convert.ToDouble(numBox.Text) < 100 && Convert.ToDouble(numBox.Text) % 2 == 0 && Convert.ToDouble(numBox.Text) % 3 == 0)))
                {
                    resultText.Text = "условия выполняются";
                }
                else if ((moreTh0.IsChecked == true && lessTh100.IsChecked == true && evenCH.IsChecked == true && dividedBy3CH.IsChecked == false) && (Convert.ToDouble(numBox.Text) > 0 && Convert.ToDouble(numBox.Text) < 100 && Convert.ToDouble(numBox.Text) % 2 == 0))
                {
                    resultText.Text = "условия выполняются";

                }
                else if (moreTh0.IsChecked == true && lessTh100.IsChecked == true && dividedBy3CH.IsChecked == true && evenCH.IsChecked == false && Convert.ToDouble(numBox.Text) > 0 && Convert.ToDouble(numBox.Text) < 100 && Convert.ToDouble(numBox.Text) % 3 == 0)
                {
                    resultText.Text = "условия выполняются";
                }
                else if (moreTh0.IsChecked == true && dividedBy3CH.IsChecked == true && evenCH.IsChecked == true && lessTh100.IsChecked == false && Convert.ToDouble(numBox.Text) > 0 && Convert.ToDouble(numBox.Text) % 3 == 0 && Convert.ToDouble(numBox.Text) % 2 == 0)
                {
                    resultText.Text = "условия выполняются";
                }
                else if (lessTh100.IsChecked == true && dividedBy3CH.IsChecked == true && evenCH.IsChecked == true && moreTh0.IsChecked == false && Convert.ToDouble(numBox.Text) < 100 && Convert.ToDouble(numBox.Text) % 3 == 0 && Convert.ToDouble(numBox.Text) % 2 == 0)
                {
                    resultText.Text = "условия выполняются";
                }
                else if (lessTh100.IsChecked == true && moreTh0.IsChecked == true && dividedBy3CH.IsChecked == false && evenCH.IsChecked == false && Convert.ToDouble(numBox.Text) > 0 && Convert.ToDouble(numBox.Text) < 100)
                {
                    resultText.Text = "условия выполняются";
                }
                else if (dividedBy3CH.IsChecked == true && evenCH.IsChecked == true && lessTh100.IsChecked == false && moreTh0.IsChecked == false && (Convert.ToDouble(numBox.Text) % 2 == 0 && Convert.ToDouble(numBox.Text) % 3 == 0))
                {
                    resultText.Text = "условия выполняются";
                }
                else if (moreTh0.IsChecked == true && dividedBy3CH.IsChecked == true && lessTh100.IsChecked == false && evenCH.IsChecked == false && Convert.ToDouble(numBox.Text) > 0 && Convert.ToDouble(numBox.Text) % 3 == 0)
                {
                    resultText.Text = "условия выполняются";
                }
                else if ((moreTh0.IsChecked == true && evenCH.IsChecked == true && lessTh100.IsChecked == false && dividedBy3CH.IsChecked == false) && (Convert.ToDouble(numBox.Text) % 2 == 0 && Convert.ToDouble(numBox.Text) > 0))
                {
                    resultText.Text = "условия выполняются";
                }
                else if (lessTh100.IsChecked == true && evenCH.IsChecked == true && moreTh0.IsChecked == false && dividedBy3CH.IsChecked == false && Convert.ToDouble(numBox.Text) < 100 && Convert.ToDouble(numBox.Text) % 2 == 0)
                {
                    resultText.Text = "условия выполняются";
                }
                else if (lessTh100.IsChecked == true && dividedBy3CH.IsChecked == true && moreTh0.IsChecked == false && evenCH.IsChecked == false && Convert.ToDouble(numBox.Text) < 100 && Convert.ToDouble(numBox.Text) % 3 == 0)
                {
                    resultText.Text = "условия выполняются";
                }
                else if (moreTh0.IsChecked == true && lessTh100.IsChecked == false && dividedBy3CH.IsChecked == false && evenCH.IsChecked == false && Convert.ToDouble(numBox.Text) > 0)
                {
                    resultText.Text = "условия выполняются";

                }
                else if (moreTh0.IsChecked == false && lessTh100.IsChecked == true && dividedBy3CH.IsChecked == false && evenCH.IsChecked == false && Convert.ToDouble(numBox.Text) < 100)
                {
                    resultText.Text = "условия выполняются";
                }
                else if (moreTh0.IsChecked == false && lessTh100.IsChecked == false && dividedBy3CH.IsChecked == true && evenCH.IsChecked == false && Convert.ToDouble(numBox.Text) % 3 == 0)
                {
                    resultText.Text = "условия выполняются";
                }
                else if (moreTh0.IsChecked == false && lessTh100.IsChecked == false && dividedBy3CH.IsChecked == false && evenCH.IsChecked == true && Convert.ToDouble(numBox.Text) % 2 == 0)
                {
                    resultText.Text = "условия выполняются";
                }
                else
                {
                    resultText.Text = "условия не выполняются";
                }
            }
        }

        private void moreTh0_Checked(object sender, RoutedEventArgs e)
        {
        }

        private void CloseProg_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
        }
