using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndromedaV1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Text = Utils.RandomChar(25);
            this.CenterToScreen();
            siticoneProgressBar1.Hide();
 
            siticoneProgressBar1.Show();
  
            SBW();

        
        
        
        }

        private void SBW()
        {
 

            siticoneProgressBar1.Maximum = 100;
            siticoneProgressBar1.Value = 0;
            timer.Enabled = true;
        }
  

        private void Form3_Load(object sender, EventArgs e)
        {
            
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public static void wait(int milliseconds)
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };
            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void siticoneProgressBar1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (siticoneProgressBar1.Value < siticoneProgressBar1.Maximum)
                siticoneProgressBar1.Increment(1);
            else
                siticoneProgressBar1.Value = siticoneProgressBar1.Minimum;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Process.Start("shell:appsFolder\\BehaviourInteractive.DeadbyDaylightWindows_b1gz2xhdanwfm!AppDeadByDaylightShipping");
            this.Hide();
        }
    }
}
