using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace semafor1
{
    public partial class Form1 : Form
    {
        private int stav = 0;
        private readonly Timer timer;

        public Form1()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Stop();
                button4.Text = "start";
            }
            else
            {
                timer.Start();
                button4.Text = "stop";
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            switch (stav)
            
            {
                case 0:
                    button1.Visible = true;
                    button2.Visible = false;
                    button3.Visible = false;
                    timer.Interval = 1000;
                    stav = 1;
                    break;

                case 1:
                    button1.Visible = false;
                    button2.Visible = true;
                    button3.Visible = false;
                    timer.Interval = 1000;
                    stav = 2;
                    break;

                case 2:
                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = true;
                    timer.Interval = 1000;
                    stav = 3;
                    break;
                case 3:
                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = false;
                    timer.Interval = 300;
                    stav = 4;
                    break;
                case 4:
                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = true;
                    timer.Interval = 300;
                    stav = 5;
                    break;
                case 5:
                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = false;
                    timer.Interval = 300;
                    stav = 6;
                    break;
                case 6:
                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = true;
                    timer.Interval = 300;
                    stav = 0;
                    break;
            }
            

        }
    }
}
