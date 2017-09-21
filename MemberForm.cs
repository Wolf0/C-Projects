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
    public partial class MemberForm : Form
    {
        public MemberForm()
        {
            InitializeComponent();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            try
            {
                List<Member> memberList = new List<Member>();
                memberList = MemberDB.GetMembers();
                MessageBox.Show("You have " + memberList.Count.ToString() + " members");
                dataGridView1.DataSource = memberList;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Member objMember = new Member();
            objMember.number = numtb.Text.Trim();
            objMember.joindate = jdtb.Text.Trim();
            objMember.firstname = firsttb.Text.Trim();
            objMember.lastname = lasttb.Text.Trim();
            objMember.Address = addtb.Text.Trim();
            objMember.City = citytb.Text.Trim();
            objMember.State = statetb.Text.Trim();
            objMember.Zipcode = ziptb.Text.Trim();
            objMember.phone = phonetb.Text.Trim();
            objMember.member_status = membtb.Text.Trim();
            objMember.password = passtb.Text.Trim();


            try
            {
                bool status = MemberDB.AddMember(objMember);
                if (status) //You can use this syntax as well..if (status ==true)
                {
                    MessageBox.Show("Member added to database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Member was not added to database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Member objMember = new Member();
            objMember.number = numtb.Text.Trim();
            objMember.joindate = jdtb.Text.Trim();
            objMember.firstname = firsttb.Text.Trim();
            objMember.lastname = lasttb.Text.Trim();
            objMember.Address = addtb.Text.Trim();
            objMember.City = citytb.Text.Trim();
            objMember.State = statetb.Text.Trim();
            objMember.Zipcode = ziptb.Text.Trim();
            objMember.phone = phonetb.Text.Trim();
            objMember.member_status = membtb.Text.Trim();
            objMember.password = passtb.Text.Trim();

            try
            {
                bool status = MemberDB.DeleteMember(objMember);
                if (status) //You can use this syntax as well..if (status ==true)
                {
                    MessageBox.Show("Member deleted from database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Member was not found in database to delete.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Member objMember = new Member();
            objMember.number = numtb.Text.Trim();
            objMember.joindate = jdtb.Text.Trim();
            objMember.firstname = firsttb.Text.Trim();
            objMember.lastname = lasttb.Text.Trim();
            objMember.Address = addtb.Text.Trim();
            objMember.City = citytb.Text.Trim();
            objMember.State = statetb.Text.Trim();
            objMember.Zipcode = ziptb.Text.Trim();
            objMember.phone = phonetb.Text.Trim();
            objMember.member_status = membtb.Text.Trim();
            objMember.password = passtb.Text.Trim();

            try
            {
                bool status = MemberDB.UpdateMember(objMember);
                if (status) //You can use this syntax as well..if (status ==true)
                {
                    MessageBox.Show("Member information updated in the database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Member was not updated in the database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            numtb.Clear();
            jdtb.Clear();
            firsttb.Clear();
            lasttb.Clear();
            addtb.Clear();
            citytb.Clear();
            statetb.Clear();
            ziptb.Clear();
            phonetb.Clear();
            membtb.Clear();
            passtb.Clear();
            numtb.ReadOnly = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (numtb.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Please enter a Member Number to find.");
                numtb.Focus();
                return;
            }

            Member objMember = MemberDB.GetMember(Convert.ToInt32(numtb.Text.Trim()));
            //Step 2: Validate to make sure the Customer object is not null.
            if (objMember != null)
            {
                //Populate the UI with the object values
                jdtb.Text = objMember.joindate;
                firsttb.Text = objMember.firstname;
                lasttb.Text = objMember.lastname;
                addtb.Text = objMember.Address;
                citytb.Text = objMember.City;
                statetb.Text = objMember.State;
                ziptb.Text = objMember.Zipcode;
                phonetb.Text = objMember.phone;
                membtb.Text = objMember.member_status;
                passtb.Text = objMember.password;
                //make Customer ID field read-only to be used for updating and deleting records demo
                numtb.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Member Number " + numtb.Text.Trim() + " not found in database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'netflixDataSet.MEMBER' table. You can move, or remove it, as needed.
            this.mEMBERTableAdapter.Fill(this.netflixDataSet.MEMBER);

        }

        
        //////////////////////////////////////////////////////////////////////////////////////////////////
        //Movie List//

    }
}

    
