using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace AndromedaV1
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
            Opacity = 0;  

            t1.Interval = 10;  
            t1.Tick += new EventHandler(fadeIn); 
            t1.Start();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Text = Utils.RandomChar(25);
            this.CenterToScreen();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   
            else
                Opacity += 0.05;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            Form2 fm = new Form2();
            fm.Show();
        }
    }
}
