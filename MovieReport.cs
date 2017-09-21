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
    public partial class MovieReport : Form
    {
        public MovieReport()
        {
            InitializeComponent();
        }

        private void MovieReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bevineauDataSet.MOVIE' table. You can move, or remove it, as needed.
            this.MOVIETableAdapter.Fill(this.netflixDataSet.MOVIE);

            this.reportViewer1.RefreshReport();
        }
    }
}
