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

namespace pract19._3._2
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

        private void backgroundColor_Click(object sender, RoutedEventArgs e)
        {
            if (backWhite.IsChecked)
            {
                exit.Background = new SolidColorBrush(Colors.White);
                userLastname.Background = new SolidColorBrush(Colors.White);
            }
            else if (backBlack.IsChecked)
            {
                exit.Background = new SolidColorBrush(Colors.Black);
                userLastname.Background = new SolidColorBrush(Colors.Black);
            }
            else if(backYellow.IsChecked)
            {
                exit.Background = new SolidColorBrush(Colors.Yellow);
                userLastname.Background = new SolidColorBrush(Colors.Yellow);
            }
            else if (backRed.IsChecked)
            {
                exit.Background = new SolidColorBrush(Colors.Red);
                userLastname.Background = new SolidColorBrush(Colors.Red);
            }
            else if (backBlue.IsChecked)
            {
                exit.Background = new SolidColorBrush(Colors.Blue);
                userLastname.Background = new SolidColorBrush(Colors.Blue);
            }
            else if (backGreen.IsChecked)
            {
                exit.Background = new SolidColorBrush(Colors.LimeGreen);
                userLastname.Background = new SolidColorBrush(Colors.LimeGreen);
            }
        }

        private void fontColor_Click(object sender, RoutedEventArgs e)
        {
            if (fontWhite.IsChecked)
            {
                userLastname.Foreground = new SolidColorBrush(Colors.White);
                exit.Foreground= new SolidColorBrush(Colors.White);
            }
            else if (fontBlack.IsChecked)
            {
                userLastname.Foreground = new SolidColorBrush(Colors.Black);
                exit.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (fontYellow.IsChecked)
            {
                userLastname.Foreground = new SolidColorBrush(Colors.Yellow);
                exit.Foreground = new SolidColorBrush(Colors.Yellow);
            }
            else if (fontRed.IsChecked)
            {
                userLastname.Foreground = new SolidColorBrush(Colors.Red);
                exit.Foreground = new SolidColorBrush(Colors.Red);
            }
            else if (fontBlue.IsChecked)
            {
                userLastname.Foreground = new SolidColorBrush(Colors.Blue);
                exit.Foreground = new SolidColorBrush(Colors.Blue);
            }
            else if (fontGreen.IsChecked)
            {
                userLastname.Foreground = new SolidColorBrush(Colors.LimeGreen);
                exit.Foreground = new SolidColorBrush(Colors.LimeGreen);
            }
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult res = MessageBox.Show("Вы точно хотите выйти?", "Выход", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (res == MessageBoxResult.Yes)
            {
                Close();
            }
        }

        private void backWhite_Checked(object sender, RoutedEventArgs e)
        {
            backBlack.IsChecked = false;
            backYellow.IsChecked = false;
            backRed.IsChecked = false;
            backBlue.IsChecked = false;
            backGreen.IsChecked = false;
        }

        private void backBlack_Checked(object sender, RoutedEventArgs e)
        {
            backWhite.IsChecked = false;
            backYellow.IsChecked = false;
            backRed.IsChecked = false;
            backBlue.IsChecked = false;
            backGreen.IsChecked = false;
        }

        private void backYellow_Checked(object sender, RoutedEventArgs e)
        {
            backWhite.IsChecked = false;
            backBlack.IsChecked = false;
            backRed.IsChecked = false;
            backBlue.IsChecked = false;
            backGreen.IsChecked = false;
        }

        private void backRed_Checked(object sender, RoutedEventArgs e)
        {
            backWhite.IsChecked = false;
            backBlack.IsChecked = false;
            backYellow.IsChecked = false;
            backBlue.IsChecked = false;
            backGreen.IsChecked = false;
        }

        private void backBlue_Checked(object sender, RoutedEventArgs e)
        {
            backWhite.IsChecked = false;
            backBlack.IsChecked = false;
            backYellow.IsChecked = false;
            backRed.IsChecked = false;
            backGreen.IsChecked = false;
        }

        private void backGreen_Checked(object sender, RoutedEventArgs e)
        {
            backWhite.IsChecked = false;
            backBlack.IsChecked = false;
            backYellow.IsChecked = false;
            backRed.IsChecked = false;
            backBlue.IsChecked = false;
        }

        private void fontWhite_Checked(object sender, RoutedEventArgs e)
        {
            fontBlack.IsChecked = false;
            fontYellow.IsChecked = false;
            fontRed.IsChecked = false;
            fontBlue.IsChecked = false;
            fontGreen.IsChecked = false;
        }

        private void fontBlack_Checked(object sender, RoutedEventArgs e)
        {
            fontWhite.IsChecked = false;
            fontYellow.IsChecked = false;
            fontRed.IsChecked = false;
            fontBlue.IsChecked = false;
            fontGreen.IsChecked = false;
        }

        private void fontYellow_Checked(object sender, RoutedEventArgs e)
        {
            fontWhite.IsChecked = false;
            fontBlack.IsChecked = false;
            fontRed.IsChecked = false;
            fontBlue.IsChecked = false;
            fontGreen.IsChecked = false;
        }

        private void fontRed_Checked(object sender, RoutedEventArgs e)
        {
            fontWhite.IsChecked = false;
            fontBlack.IsChecked = false;
            fontYellow.IsChecked = false;
            fontBlue.IsChecked = false;
            fontGreen.IsChecked = false;
        }

        private void fontBlue_Checked(object sender, RoutedEventArgs e)
        {
            fontWhite.IsChecked = false;
            fontBlack.IsChecked = false;
            fontYellow.IsChecked = false;
            fontRed.IsChecked = false;
            fontGreen.IsChecked = false;
        }

        private void fontGreen_Checked(object sender, RoutedEventArgs e)
        {
            fontWhite.IsChecked = false;
            fontBlack.IsChecked = false;
            fontYellow.IsChecked = false;
            fontRed.IsChecked = false;
            fontBlue.IsChecked = false;
        }
    }
}
