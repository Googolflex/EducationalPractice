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

namespace pract19._3._1
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

        private void aboutProg_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Задание 19.3.1");
        }

        private void aboutDev_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Головин, Ведерников");
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult res = MessageBox.Show("Вы точно хотите выйти?", "Выход",MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (res == MessageBoxResult.Yes)
            {
                Close();
            }
        }
    }
}
