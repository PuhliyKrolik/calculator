using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Калькулятор : Form
    {
        public Калькулятор()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void n1_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        

        private void n228_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox1.Text);
            switch (znak)
            {
                case '+': c = a + b;
                        break;
                case '-': c = a - b;
                        break;
                case '*': c = a * b;
                        break;
                case '/': c = a / b;
                        break;

            }
            textBox1.Text = c.ToString();
        }
        

        private void n85_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
        double a = 0, b = 0, c = 0;
        char znak = '+';

        private void n13_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            znak = (sender as Button).Text[0];
            textBox1.Clear();
        }

        
        
        }
    }

