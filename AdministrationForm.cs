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
    public partial class AdministrationForm : Form
    {
        public AdministrationForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void manageMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberForm mmform = new MemberForm();
            mmform.ShowDialog();
        }

        private void manageMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MovieForm pbform = new MovieForm();
            pbform.ShowDialog();
        }

        private void memberReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberReport pbform = new MemberReport();
            pbform.ShowDialog();
        }

        private void movieReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MovieReport pbform = new MovieReport();
            pbform.ShowDialog();
        }

        private void manageVendorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VendorForm mmform = new VendorForm();
            mmform.ShowDialog();
        }
    }
}
