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
        public double starttime = 0;
        public double secago = 0;
        public int howManyTimes = 0;
        public int whichLetter = 0;
        Random rd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer1.Stop();
        }

        public int DiffRanInt(int a, int b)
        {
            int c = rd.Next(a, b);
            if (c == whichLetter)
	        {
		        c = DiffRanInt(a,b);
	        }
            return c;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            secago = 0;
            starttime = GetTime();
            label.ForeColor = Color.Black;
            howManyTimes = 0;
            this.timer1.Start();
            whichLetter = rd.Next(0,25);
            label.Text = Convert.ToString(Convert.ToChar( Convert.ToInt32('A') + whichLetter ));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double nowTime = GetTime();
            secago = nowTime - starttime;
            time_text.Text = secago.ToString("0.00");
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar( Convert.ToInt32(Convert.ToChar(label.Text))+32 ))
            {
                label.ForeColor = Color.Black;
                howManyTimes += 1;
                whichLetter = DiffRanInt(0, 25);
                label.Text = Convert.ToString(Convert.ToChar(Convert.ToInt32('A') + whichLetter));
            }
            else
            {
                label.ForeColor = Color.Red;
            }
            if (howManyTimes == 100)
            {
                this.timer1.Stop();
                double time = Convert.ToDouble(time_text.Text);
                double speed = 100 / (time / 60);
                speed_text.Text = speed.ToString("0.00");
                if (speed <= 40)
                {
                    label.Text = "😥";
                    label.ForeColor = Color.Red;
                }
                else
                {
                    if (speed <= 70)
                    {
                        label.Text = "😐";
                        label.ForeColor = Color.Yellow;
                    }
                    else
                    {
                        label.Text = "😀";
                        label.ForeColor = Color.Green;
                    }
                }
            }
        }
        public double GetTime()
        {
            long hr = DateTime.Now.Hour;
            long min = DateTime.Now.Minute;
            long sec = DateTime.Now.Second;
            long ms = DateTime.Now.Millisecond;
            long iresult = hr * 3600000 + min * 60000 + sec * 1000 + ms;
            double result = Convert.ToDouble(iresult) / 1000;
            return result;
        }
    }
}
