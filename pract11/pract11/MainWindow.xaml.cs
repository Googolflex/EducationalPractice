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

namespace pract11
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

        private void showMatrix_Click(object sender, RoutedEventArgs e)
        {
            int m = int.Parse(rowsBox.Text);
            int n = int.Parse(columnsBox.Text);
            Random rnd = new Random();
            int[,] a = new int[m, n];

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    a[i, j] = rnd.Next(-50, 51);

            matrixBox.Text = "";
            string s = "";
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    s = s + string.Format("{0,5}", a[i,j]);
                }
                    matrixBox.Text += "\r\n" + s;
                s = "";
            }
        }
    }
}
