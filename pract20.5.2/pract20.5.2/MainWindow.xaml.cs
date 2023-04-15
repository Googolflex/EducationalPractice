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

namespace pract20._5._2
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
            exit.Background = new SolidColorBrush(Colors.White);
            userLastname.Background = new SolidColorBrush(Colors.White);
            backBlack.IsChecked = false;
            backYellow.IsChecked = false;
            backRed.IsChecked = false;
            backBlue.IsChecked = false;
            backGreen.IsChecked = false;
        }

        private void backBlack_Checked(object sender, RoutedEventArgs e)
        {
            exit.Background = new SolidColorBrush(Colors.Black);
            userLastname.Background = new SolidColorBrush(Colors.Black);
            backWhite.IsChecked = false;
            backYellow.IsChecked = false;
            backRed.IsChecked = false;
            backBlue.IsChecked = false;
            backGreen.IsChecked = false;
        }

        private void backYellow_Checked(object sender, RoutedEventArgs e)
        {
            exit.Background = new SolidColorBrush(Colors.Yellow);
            userLastname.Background = new SolidColorBrush(Colors.Yellow);
            backWhite.IsChecked = false;
            backBlack.IsChecked = false;
            backRed.IsChecked = false;
            backBlue.IsChecked = false;
            backGreen.IsChecked = false;
        }

        private void backRed_Checked(object sender, RoutedEventArgs e)
        {
            exit.Background = new SolidColorBrush(Colors.Red);
            userLastname.Background = new SolidColorBrush(Colors.Red);
            backWhite.IsChecked = false;
            backBlack.IsChecked = false;
            backYellow.IsChecked = false;
            backBlue.IsChecked = false;
            backGreen.IsChecked = false;
        }

        private void backBlue_Checked(object sender, RoutedEventArgs e)
        {
            exit.Background = new SolidColorBrush(Colors.Blue);
            userLastname.Background = new SolidColorBrush(Colors.Blue);
            backWhite.IsChecked = false;
            backBlack.IsChecked = false;
            backYellow.IsChecked = false;
            backRed.IsChecked = false;
            backGreen.IsChecked = false;
        }

        private void backGreen_Checked(object sender, RoutedEventArgs e)
        {
            exit.Background = new SolidColorBrush(Colors.LimeGreen);
            userLastname.Background = new SolidColorBrush(Colors.LimeGreen);
            backWhite.IsChecked = false;
            backBlack.IsChecked = false;
            backYellow.IsChecked = false;
            backRed.IsChecked = false;
            backBlue.IsChecked = false;
        }

        private void fontWhite_Checked(object sender, RoutedEventArgs e)
        {
            userLastname.Foreground = new SolidColorBrush(Colors.White);
            exit.Foreground = new SolidColorBrush(Colors.White);
            fontBlack.IsChecked = false;
            fontYellow.IsChecked = false;
            fontRed.IsChecked = false;
            fontBlue.IsChecked = false;
            fontGreen.IsChecked = false;
        }

        private void fontBlack_Checked(object sender, RoutedEventArgs e)
        {
            userLastname.Foreground = new SolidColorBrush(Colors.Black);
            exit.Foreground = new SolidColorBrush(Colors.Black);
            fontWhite.IsChecked = false;
            fontYellow.IsChecked = false;
            fontRed.IsChecked = false;
            fontBlue.IsChecked = false;
            fontGreen.IsChecked = false;
        }

        private void fontYellow_Checked(object sender, RoutedEventArgs e)
        {
            userLastname.Foreground = new SolidColorBrush(Colors.Yellow);
            exit.Foreground = new SolidColorBrush(Colors.Yellow);
            fontWhite.IsChecked = false;
            fontBlack.IsChecked = false;
            fontRed.IsChecked = false;
            fontBlue.IsChecked = false;
            fontGreen.IsChecked = false;
        }

        private void fontRed_Checked(object sender, RoutedEventArgs e)
        {
            userLastname.Foreground = new SolidColorBrush(Colors.Red);
            exit.Foreground = new SolidColorBrush(Colors.Red);
            fontWhite.IsChecked = false;
            fontBlack.IsChecked = false;
            fontYellow.IsChecked = false;
            fontBlue.IsChecked = false;
            fontGreen.IsChecked = false;
        }

        private void fontBlue_Checked(object sender, RoutedEventArgs e)
        {
            userLastname.Foreground = new SolidColorBrush(Colors.Blue);
            exit.Foreground = new SolidColorBrush(Colors.Blue);
            fontWhite.IsChecked = false;
            fontBlack.IsChecked = false;
            fontYellow.IsChecked = false;
            fontRed.IsChecked = false;
            fontGreen.IsChecked = false;
        }

        private void fontGreen_Checked(object sender, RoutedEventArgs e)
        {
            userLastname.Foreground = new SolidColorBrush(Colors.LimeGreen);
            exit.Foreground = new SolidColorBrush(Colors.LimeGreen);
            fontWhite.IsChecked = false;
            fontBlack.IsChecked = false;
            fontYellow.IsChecked = false;
            fontRed.IsChecked = false;
            fontBlue.IsChecked = false;
        }

        private void backColor_Checked(object sender, RoutedEventArgs e)
        {
            backColor.ContextMenu.IsOpen = true;
            backColor.IsChecked = false;
        }

        private void fontColor_Checked(object sender, RoutedEventArgs e)
        {
            fontColor.ContextMenu.IsOpen = true;
            fontColor.IsChecked = false;
        }
    }
}
