using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hans_Super_Calculator_No._0001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = 0;
            if (comboBox1.Text == "Addition(+)")
            {
                c = a + b;
            }
            else if(comboBox1.Text == "Subtraction(-)")
            {
                c = a - b;
            }
            else if(comboBox1.Text == "Multiplication(*)")
            {
                c = a * b;
            }
            else if(comboBox1.Text == "Division(/)")
            {
                if(b==0)
                {
                    c = double.PositiveInfinity;
                }
                else
                {
                    c = a / b;
                }
            }
            else if(comboBox1.Text == "Power(a^n)")
            {
                c = Math.Pow(a, b);
            }
            else if(comboBox1.Text == "Evolution(v-)")
            {
                c = Math.Pow(b, 1/a);
            }
            else if(comboBox1.Text == "Logarithm(log_a-N)")
            {
                c = Math.Log(b) / Math.Log(a);
            }
            textBox3.Text = c.ToString();
        }
    }
}
