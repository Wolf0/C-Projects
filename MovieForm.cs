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
    public partial class MovieForm : Form
    {
        public MovieForm()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Movie objMovie = new Movie();
            objMovie.movie_number = textBox1.Text.Trim();
            objMovie.movie_title = textBox2.Text.Trim();
            objMovie.Description = textBox3.Text.Trim();
            objMovie.movie_year_made = textBox4.Text.Trim();
            objMovie.genre_id = textBox5.Text.Trim();
            objMovie.movie_rating = textBox6.Text.Trim();
            objMovie.media_type = textBox7.Text.Trim();
            objMovie.movie_retail_cost = textBox8.Text.Trim();
            objMovie.tape_rental_cost = textBox9.Text.Trim();
            objMovie.copies_on_hand = textBox10.Text.Trim();
            objMovie.image = textBox11.Text.Trim();
            objMovie.trailer = textBox12.Text.Trim();


            try
            {
                bool status = MovieDB.AddMovie(objMovie);
                if (status) //You can use this syntax as well..if (status ==true)
                {
                    MessageBox.Show("Movie added to database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Movie was not added to database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }     

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Please enter a Movie Number to find.");
                textBox1.Focus();
                return;
            }

            Movie objMovie = MovieDB.GetMovie(Convert.ToInt32(textBox1.Text.Trim()));
            //Step 2: Validate to make sure the Customer object is not null.
            if (objMovie != null)
            {
                //Populate the UI with the object values
                textBox2.Text = objMovie.movie_title;
                textBox3.Text = objMovie.Description;
                textBox4.Text = objMovie.movie_year_made;
                textBox5.Text = objMovie.genre_id;
                textBox6.Text = objMovie.movie_rating;
                textBox7.Text = objMovie.media_type;
                textBox8.Text = objMovie.movie_retail_cost;
                textBox9.Text = objMovie.tape_rental_cost;
                textBox10.Text = objMovie.copies_on_hand;
                textBox11.Text = objMovie.image;
                textBox12.Text = objMovie.trailer;
                //make Customer ID field read-only to be used for updating and deleting records demo
                textBox1.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Movie Number " + textBox1.Text.Trim() + " not found in database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Movie objMovie = new Movie();
            objMovie.movie_number = textBox1.Text.Trim();
            objMovie.movie_title = textBox2.Text.Trim();
            objMovie.Description = textBox3.Text.Trim();
            objMovie.movie_year_made = textBox4.Text.Trim();
            objMovie.genre_id = textBox5.Text.Trim();
            objMovie.movie_rating = textBox6.Text.Trim();
            objMovie.media_type = textBox7.Text.Trim();
            objMovie.movie_retail_cost = textBox8.Text.Trim();
            objMovie.tape_rental_cost = textBox9.Text.Trim();
            objMovie.copies_on_hand = textBox10.Text.Trim();
            objMovie.image = textBox11.Text.Trim();
            objMovie.trailer = textBox12.Text.Trim();

            try
            {
                bool status = MovieDB.UpdateMovie(objMovie);
                if (status) //You can use this syntax as well..if (status ==true)
                {
                    MessageBox.Show("Movie information updated in the database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Movie was not updated in the database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Movie objMovie = new Movie();
            objMovie.movie_number = textBox1.Text.Trim();
            objMovie.movie_title = textBox2.Text.Trim();
            objMovie.Description = textBox3.Text.Trim();
            objMovie.movie_year_made = textBox4.Text.Trim();
            objMovie.genre_id = textBox5.Text.Trim();
            objMovie.movie_rating = textBox6.Text.Trim();
            objMovie.media_type = textBox7.Text.Trim();
            objMovie.movie_retail_cost = textBox8.Text.Trim();
            objMovie.tape_rental_cost = textBox9.Text.Trim();
            objMovie.copies_on_hand = textBox10.Text.Trim();
            objMovie.image = textBox11.Text.Trim();
            objMovie.trailer = textBox12.Text.Trim();


            try
            {
                bool status = MovieDB.DeleteMovie(objMovie);
                if (status) //You can use this syntax as well..if (status ==true)
                {
                    MessageBox.Show("Movie deleted from database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Movie was not found in database to delete.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox1.ReadOnly = false;
        }


        private void Moviebutton_click(object sender, EventArgs e)
        {
            try
            {
                List<Movie> movieList = new List<Movie>();
                movieList = MovieDB.GetMovie();
                MessageBox.Show("You have " + movieList.Count.ToString() + " Movies");
                dataGridView2.DataSource = movieList;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void MovieForm_Load(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.movieTableAdapter1.FillBy(this.netflixDataSet.MOVIE);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.movieTableAdapter1.FillBy1(this.netflixDataSet.MOVIE);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        }
    }

