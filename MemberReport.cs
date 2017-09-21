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
    public partial class MemberReport : Form
    {
        public MemberReport()
        {
            InitializeComponent();
        }

        private void MemberReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bevineauDataSet.MEMBER' table. You can move, or remove it, as needed.
            this.MEMBERTableAdapter.Fill(this.netflixDataSet.MEMBER);

            this.reportViewer1.RefreshReport();
        }
    }
}
