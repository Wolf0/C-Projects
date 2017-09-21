using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.Net_Demo
{
    public partial class WalkingDead : Form
    {
        public WalkingDead()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void WalkingDead_Load(object sender, EventArgs e)
        {
            axShockwaveFlash1.Movie =
    @"https://www.youtube.com/v/MWSF9RZiUos";
        }
    }
}
