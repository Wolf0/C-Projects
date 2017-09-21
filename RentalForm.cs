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
    public partial class RentalForm : Form
    {
        public RentalForm()
        {
            InitializeComponent();
        }

        private void RentalForm_Load(object sender, EventArgs e)
        {

           // this.reportViewer1.RefreshReport();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            WalkingDead pbform = new WalkingDead();
            pbform.ShowDialog();
        }
    }
}
