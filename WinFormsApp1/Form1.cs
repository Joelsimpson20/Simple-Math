using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number1 = double.Parse(textBox1.Text);
            double number2 = double.Parse(textBox2.Text);
            double answer = number1 + number2;
            label2.Text = answer.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double number3 = double.Parse(textBox3.Text);
            double number4 = double.Parse(textBox4.Text);
            double answer2 = number3 - number4;
            label10.Text = answer2.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double number5 = double.Parse(textBox6.Text);
            double number6 = double.Parse(textBox5.Text);
            double answer3 = number5 * number6;
            label23.Text = answer3.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double number7 = double.Parse(textBox8.Text);
            double number8 = double.Parse(textBox7.Text);
            double answer4 = number7 / number8;
            label24.Text = answer4.ToString();
        }
    }
}
