using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Net;
using Fiddler;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace AndromedaV1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.CenterToScreen();
            this.Text = Utils.RandomChar(25);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void FiddlerApplication_BeforeRequest(Session oSession)
        {
            oSession.bBufferResponse = true;

        }

        private void FiddlerApplication_BeforeResponse(Session oSession)
        {
            if (oSession.fullUrl.Equals("https://grdk.live.bhvrdbd.com/api/v1/inventories") || oSession.fullUrl.Equals("https://brill.live.bhvrdbd.com/api/v1/inventories"))
            {

                oSession.utilDecodeResponse();
                WebClient wc = new WebClient();
                string allcosm = wc.DownloadString("https://gateway.luny.cc/api/v1/luny/dbd/market.json");
        
                
                oSession.utilSetResponseBody(allcosm);
                




            }
        }


        private void siticonePictureBox2_Click(object sender, EventArgs e)
        {
            CertMaker.createRootCert();
            CertMaker.trustRootCert();
            FiddlerCoreStartupSettings startupSettings = new FiddlerCoreStartupSettingsBuilder().ListenOnPort(50244).RegisterAsSystemProxy().DecryptSSL().Build();

            FiddlerApplication.Startup(startupSettings);

            FiddlerApplication.BeforeRequest += FiddlerApplication_BeforeRequest;
            FiddlerApplication.BeforeResponse += FiddlerApplication_BeforeResponse;
            MessageBox.Show("You can launch the game, Enjoy :)", "Enjoy :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void siticonePictureBox1_Click(object sender, EventArgs e)
        {
            FiddlerApplication.Shutdown();
            Environment.Exit(1);
        }

        private void siticonePictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The game will be launched..", "Andromeda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Form3 form = new Form3();
            form.Show();
            
        }
    }
}
