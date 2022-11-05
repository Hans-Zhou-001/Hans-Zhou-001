using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int which = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //which = 1;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char press = Convert.ToChar(Convert.ToInt16('a') + which);
            if (e.KeyChar == press)
            {
                char replace = Convert.ToChar( Convert.ToInt16(press)-(Convert.ToInt16('a')-Convert.ToInt16('A')) );
                label.Text = label.Text.Replace(replace, ' ');
                which++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            which = 0;
        }
    }
}
