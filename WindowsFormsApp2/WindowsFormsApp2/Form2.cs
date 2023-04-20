using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            System.IO.File.WriteAllText(filename, textBox1.Text);
            MessageBox.Show("Файл сохранен");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = ofd.FileName;
            string fileText = System.IO.File.ReadAllText(filename);
            textBox1.Text = fileText;
            MessageBox.Show("Файл открыт");
        }
    }
}
