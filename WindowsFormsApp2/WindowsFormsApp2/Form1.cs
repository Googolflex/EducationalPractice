using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openInNewWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form[] form = MdiChildren;
            foreach (Form f in form)
            {
                f.Close();
            }
        }
    }
}
