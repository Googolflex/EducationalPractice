using System;
using System.Collections.Generic;
using System.Windows;


namespace pract12
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void showMatrix_Click(object sender, RoutedEventArgs e)
        {
            List<string> chars = new List<string>();
            int m = Convert.ToInt32(numberOfRows.Text);
            int row = 1, vertMainEl = 0, horMainEl = 0;
            Random rnd = new Random();
            int[,] a = new int[m, m];
            char[,] b = new char[m, m];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    b[i, j] = symbols[rnd.Next(symbols.Length)];
                    a[i, j] = rnd.Next(0, 10);
                }
            }

            row = 0;
            matrix.Text = "";
            mainDiagonal.Content = "";
            string s = "";
            string mainDiag = "";
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (row % 2 != 0)
                    {
                        s = s + string.Format("{0,5}", a[i, j]);
                        if (vertMainEl == i && horMainEl == j)
                        {
                            mainDiag = mainDiag + string.Format("{0,5}", a[i, j]);
                        }
                    }
                    else
                    {
                        s = s + string.Format("{0,5}", b[i, j]);
                        if (vertMainEl == i && horMainEl == j)
                        {
                            mainDiag = mainDiag + string.Format("{0,5}", b[i, j]);
                        }
                    }
                }
                row++;
                vertMainEl++;
                horMainEl++;
                mainDiagonal.Content += "" + mainDiag;
                matrix.Text += "\r\n" + s;
                s = "";
                mainDiag = "";
            }
        }
    }
}
