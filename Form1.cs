using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculation
{
    public partial class Form1 : Form
    {
        delegate void Delete();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label3.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Delete del;
            del = buttonDelete;
            double firstNumber, secondNumber;
            firstNumber = Convert.ToDouble(textBox1.Text);
            secondNumber = Convert.ToDouble(textBox2.Text);
            switch (comboBox1.Text)
            {
                case "+":
                    textBox3.Text = Convert.ToString(firstNumber + secondNumber);
                    break;
                case "-":
                    textBox3.Text = Convert.ToString(firstNumber - secondNumber);
                    break;
                case "*":
                    textBox3.Text = Convert.ToString(firstNumber * secondNumber);
                    break;
                case "/":
                    if (secondNumber == 0)
                    {
                        MessageBox.Show("Нельзя делить на 0");
                        del();
                    }
                    else
                    {
                        textBox3.Text = Convert.ToString(firstNumber / secondNumber);
                    }
                    break;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = ""; 
            textBox3.Text = "";
            comboBox1.Text = "";
        }
        private void buttonDelete()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e, KeyEventArgs a)
        {
            if (a.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }

    }
}
