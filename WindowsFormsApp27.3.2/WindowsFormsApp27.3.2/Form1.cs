using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace WindowsFormsApp27._3._2
{
    public partial class Form1 : Form
    {
        public List<DateTime> dates = new List<DateTime>();
        public List<string> names = new List<string>();
        public List<bool> flags = new List<bool>();

        public bool dinnerShowed = false;
        public bool endShowed = false;
        public Form1()
        {
            InitializeComponent();

            this.ShowInTaskbar = false;

            Timer tm = new Timer();
            tm.Tick += new EventHandler(tm_Tick);
            tm.Interval = 1;
            tm.Start();
        }
        public void tm_Tick(object sender, EventArgs e)
        {
           label1.Text = $"Время: {DateTime.Now.ToLongTimeString()}";
           for(int i = 0; i<dates.Count; i++)
            {
                if (dates[i] <= DateTime.Now && flags[i] == false)
                {
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                    notifyIcon1.BalloonTipText = names[i];
                    notifyIcon1.BalloonTipTitle = names[i];
                    flags[i] = true;
                    notifyIcon1.ShowBalloonTip(100);
                }
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

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime newTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
            names.Add(textBox1.Text);
            dates.Add(newTime);
            flags.Add(false);
        }
    }
}
