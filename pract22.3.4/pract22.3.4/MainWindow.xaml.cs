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
using System.Windows.Threading;

namespace pract22._3._4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string symbols = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";
        Random rnd = new Random();
        public MainWindow()
        {
            InitializeComponent();

            randomText.Text = "";
            int lenght = rnd.Next(20, 40);
            for (int i = 0; i < lenght; i++)
            {
                randomText.Text += symbols[rnd.Next(symbols.Length)];
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
        }

        int x = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            if (x == 0)
            {
                randomText.Opacity = 0;
                x = 1;
            }
            else
            {
                randomText.Opacity = 100;
                x = 0;
            }
        }
    }
}
