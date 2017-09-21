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
    public partial class VendorForm : Form
    {
        public VendorForm()
        {
            InitializeComponent();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            try
            {
                List<Vendor> vendorList = new List<Vendor>();
                vendorList = VendorDB.GetVendor();
                MessageBox.Show("You have " + vendorList.Count.ToString() + " vendors");
                dataGridView1.DataSource = vendorList;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


        private void button4_Click_1(object sender, EventArgs e)
        {
            Vendor objVendor = new Vendor();
            objVendor.VendorID = textBox1.Text.Trim();
            objVendor.VendorName = textBox2.Text.Trim();

            try
            {
                bool status = VendorDB.DeleteVendor(objVendor);
                if (status) //You can use this syntax as well..if (status ==true)
                {
                    MessageBox.Show("Vendor deleted from database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vendor was not found in database to delete.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Vendor objVendor = new Vendor();
            objVendor.VendorID = textBox1.Text.Trim();
            objVendor.VendorName = textBox2.Text.Trim();
            try
            {
                bool status = VendorDB.UpdateVendor(objVendor);
                if (status) //You can use this syntax as well..if (status ==true)
                {
                    MessageBox.Show("Vendor information updated in the database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vendor was not updated in the database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.ReadOnly = false;
        }

        private void button2_Click_2(object sender, EventArgs e)
        {

            if (textBox1.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Please enter a Vendor ID to find.");
                textBox2.Focus();
                return;
            }

            Vendor objVendor = VendorDB.GetVendor(Convert.ToInt32(textBox1.Text.Trim()));
            //Step 2: Validate to make sure the Customer object is not null.
            if (objVendor != null)
            {
                //Populate the UI with the object values
                textBox2.Text = objVendor.VendorName;
                //make Customer ID field read-only to be used for updating and deleting records demo
                textBox1.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Vendor ID " + textBox1.Text.Trim() + " not found in database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vendor objVendor = new Vendor();
            objVendor.VendorID = textBox1.Text.Trim();
            objVendor.VendorName = textBox2.Text.Trim();


            try
            {
                bool status = VendorDB.AddVendor(objVendor);
                if (status) //You can use this syntax as well..if (status ==true)
                {
                    MessageBox.Show("Vendor added to database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vendor was not added to database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////
        //Movie List//

    }
}

    

