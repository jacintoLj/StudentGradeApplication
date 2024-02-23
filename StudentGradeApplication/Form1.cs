using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double English, Filipino, Math, History, Science;
            string name = textBox1.Text;

            English = Convert.ToDouble(textBox2.Text);
            Filipino = Convert.ToDouble(textBox4.Text);
            Math = Convert.ToDouble(textBox6.Text);
            History = Convert.ToDouble(textBox3.Text);
            Science = Convert.ToDouble(textBox5.Text);

            double total = English + Filipino + Math + History + Science;  
            double average = total /5;

            label9.Text = (average >= 75.00) ? "The student passed." : "The student failed";
            label10.Text = "The general average of " + name + " is " + average;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
