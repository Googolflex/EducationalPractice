using System;
using System.Windows;
using System.Windows.Threading;

namespace pract22._3._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            date.Content = DateTime.Now.ToLongDateString();
            time.Content = DateTime.Now.ToLongTimeString();
        }
    }
}
