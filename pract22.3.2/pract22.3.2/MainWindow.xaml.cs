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

namespace pract22._3._2
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
        private void timer_Tick(object sender, EventArgs e)
        {
            var x = Canvas.GetLeft(startStop);
            x += 4;
            Canvas.SetLeft(startStop, x);
        }

        private void startStop_Click(object sender, RoutedEventArgs e)
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 2);
            if (startStop.Content.ToString() == "Start")
            {
                Canvas.SetLeft(startStop, 0);
                timer.Start();
                startStop.Content = "Stop";
            }
            else
            {
                timer.Stop();
                Canvas.SetLeft(startStop, 0);
                startStop.Content = "Start";
            }
        }
    }
}
