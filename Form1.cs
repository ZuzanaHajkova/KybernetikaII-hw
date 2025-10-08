using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int stav = 0;

        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
                int stav = 0;
                while (true) {

                    if (stav == 0)
                    {
                        button1.Visible = true;
                        button2.Visible = false;
                        button3.Visible = false;
                    }
                    else if (stav == 1) {
                        button1.Visible = false;
                        button2.Visible = true;
                        button3.Visible = false;
                    }
                    else {
                        button1.Visible = false;
                        button2.Visible = false;
                        button3.Visible = true;
                    }
                    stav = (stav + 1) % 3;
                    



            }
}
    }
}
