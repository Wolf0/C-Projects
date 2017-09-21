using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO.Net_Demo
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = "chris";
            string password = "chris";


            if((textBox1.Text == username) && (textBox2.Text == password))
            {
                MessageBox.Show("You can now Rent a Movie");
                RentalForm ft = new RentalForm();
                ft.ShowDialog();
            }
            //}
            //else if (count == 1)
            //{
            //    MessageBox.Show("Duplicate username and password");
            //}
            else
            {
                MessageBox.Show("username or password not correct");
            }
            //else
            //{
            //    MessageBox.Show("username or password not correct");
            //}

            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SqlConnection cn = new SqlConnection(@"Data Source=netflixDataSet;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            //cn.Open();
            //SqlCommand cmd = new SqlCommand("select * from user1 where username = '" + textBox1.Text + "' and password = '" + textBox2.Text + "'", cn);
            //SqlDataReader dr;
            //dr = cmd.ExecuteReader();
            //int count = 0;
            //while (dr.Read())
            //{
            //    count += 1;
            //}

            //if (count > 0)
            //{
            string username = "chris";
            string password = "chris";


            if ((textBox1.Text == username) && (textBox2.Text == password))
            {
                MessageBox.Show("You can now Do Administrative Tasks");
                AdministrationForm ft = new AdministrationForm();
                ft.ShowDialog();
            }
            else
            {
                MessageBox.Show("username or password not correct");
            }
            //}
            //else if (count == 1)
            //{
            //    MessageBox.Show("Duplicate username and password");
            //}
            //else
            //{
            //    MessageBox.Show("username or password not correct");
            //}

            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
