using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp37._3._1
{
    public partial class Form1 : Form
    {

        public DateTime dinnerTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 13, 00, 00);
        public DateTime endDinnerTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 13, 30, 00);
        public DateTime endTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 18, 00, 00);
        public bool dinnerShowed = false;
        public bool endShowed = false;
        public Form1()
        {
            InitializeComponent();

            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;

            Timer tm = new Timer();
            tm.Tick += new EventHandler(tm_Tick);
            tm.Interval = 100;
            tm.Start();

            /*notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = "Нажмите, чтобы отобразить окно";
            notifyIcon1.BalloonTipTitle = "Подсказка";
            notifyIcon1.ShowBalloonTip(12);*/
        }
        public void tm_Tick(object sender, EventArgs e)
        {
            label1.Text = $"Время: {DateTime.Now.ToLongTimeString()}";
            if (DateTime.Now >= dinnerTime && dinnerShowed == false && DateTime.Now < endDinnerTime)
            {
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.BalloonTipText = "Время обеда";
                notifyIcon1.BalloonTipTitle = "Обед";
                notifyIcon1.ShowBalloonTip(100);
                dinnerShowed = true;
                label2.Text = "Активность: обед";
            }

            if((DateTime.Now < dinnerTime || DateTime.Now > endDinnerTime) && DateTime.Now < endTime)
                label2.Text = "Активность: работа";

            if (DateTime.Now >= endTime && endShowed == false)
            {
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.BalloonTipText = "Конец рабочего дня";
                notifyIcon1.BalloonTipTitle = "My work is done here";
                notifyIcon1.ShowBalloonTip(100);
                endShowed = true;
                label2.Text = "Активность: нет";
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void notifyIcon1_DoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}