using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public double x = 0, y, res = 0;
        public string operation = "";
        public bool secondNum = false, isEnabled = false;

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(-Convert.ToDouble(textBox1.Text));
        }

        private void nums_Click(object sender, EventArgs e)
        {
            Button clickedBut = (Button)sender;
            if (textBox1.Text == "0" || (secondNum && (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "X" || textBox1.Text == "/" || textBox1.Text == "%")) || isEnabled == true)
            {
                textBox1.Text = clickedBut.Text;
                isEnabled = false;
            }
            else
                textBox1.Text += clickedBut.Text;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            x = 0; y = 0; res = 0; operation = ""; secondNum = false;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                x = Convert.ToDouble(textBox1.Text);
                res = x;
            }
            else
            y = Convert.ToDouble(textBox1.Text);


            switch (operation)
            {
                case "+":
                    res = x + y;
                    break;
                case "-":
                    res = x - y;
                    break;
                    case "X":
                    res = x * y;
                    break;
                case "/":
                    res = x / y;
                    break;
                case "%":
                    res = x / (x + y) * 100;
                    break;
                case "1/x":
                    res = 1 / x;
                    break;
            }
            textBox1.Text = res.ToString();
            operation = "";
            isEnabled = true;
            secondNum = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            Button action = (Button)sender;
            switch (action.Text)
            {
                case "1/x":
                    res = Math.Round((1 / x), 6);
                    break;
                case "x^2":
                    res = Math.Pow(x, 2);
                    break;
                case "√":
                    res = Math.Sqrt(x);
                    break;
            }
            textBox1.Text = res.ToString();
            isEnabled = true; x = 0;  y = 0; operation = "";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
            textBox1.Text += ",";
        }

        private void button4_Click(object sender, EventArgs e)
        {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text == "")
                textBox1.Text = "0";
        }

        private void action_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                x = Convert.ToDouble(textBox1.Text);
            }
            Button action = (Button)sender;
            operation = action.Text;
            textBox1.Text = action.Text;
            secondNum = true;
        }
    }
}
