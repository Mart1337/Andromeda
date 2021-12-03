
namespace AndromedaV1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.siticoneProgressBar1 = new Siticone.UI.WinForms.SiticoneProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AndromedaV1.Properties.Resources.Rose_et_Bordeaux_Lumière_noire__Action_Vaporwave__Aventure_Logo_animé__835_x_515_px___3_;
            this.pictureBox1.Location = new System.Drawing.Point(-25, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(835, 515);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // siticoneProgressBar1
            // 
            this.siticoneProgressBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.siticoneProgressBar1.Location = new System.Drawing.Point(164, 342);
            this.siticoneProgressBar1.Name = "siticoneProgressBar1";
            this.siticoneProgressBar1.ShadowDecoration.Parent = this.siticoneProgressBar1;
            this.siticoneProgressBar1.Size = new System.Drawing.Size(483, 40);
            this.siticoneProgressBar1.TabIndex = 1;
            this.siticoneProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.siticoneProgressBar1.ValueChanged += new System.EventHandler(this.siticoneProgressBar1_ValueChanged);
            // 
            // timer
            // 
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 6000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 502);
            this.Controls.Add(this.siticoneProgressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Siticone.UI.WinForms.SiticoneProgressBar siticoneProgressBar1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timer1;
    }
}