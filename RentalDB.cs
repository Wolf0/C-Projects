using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Add SQL Server namespace
using System.Data;
using System.Data.SqlClient;

namespace ADO.Net_Demo
{
    public static class RentalDB
    {


        public static List<Rental> GetRental()
        {
            //Uncomment either Example #1 or #2 to use appropriate connection string
            //Example #1 for connecting to a remote SQL Server instance via IP address and SQL Server authenication..For Meramec
            //string connectionString = "Server=198.209.220.125;Database=bevineau;User Id=chris;Password=chris;";

            //Example #2 for connecting to SQL Server locally with Windows Authenication. Change accordingly to your environment.
            string connectionString = @"Data Source=netflixDataSet;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";

            List<Rental> rentalList = new List<Rental>();
            //string connectionString = @"Data Source=netflixDataSet;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
            string sqlString = "Select movie_number, member_number, media_checkout_date, mmedia_return_date, media_exp_return_date, " +
                                "  media_rental_cost from RENTAL";

            SqlCommand objCommand = null;
            SqlConnection objConn = null;
            SqlDataReader custReader = null;
            try
            {
                using (objConn = new SqlConnection(connectionString))
                {
                    //Open the connection to the datbase
                    objConn.Open();
                    //Create a command object with the SQL statement
                    using (objCommand = new SqlCommand(sqlString, objConn))
                    {
                        //Execute the SQL and return a DataReader
                        using ((custReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection)))
                        {
                            while (custReader.Read())
                            {
                                Rental objRental = new Rental();
                                objRental.movie_number = custReader["movie_number"].ToString();
                                objRental.member_number = custReader["member_number"].ToString();
                                objRental.media_checkout_date = custReader["media_checkout_date"].ToString();
                                objRental.media_return_date = custReader["media_return_date"].ToString();
                                objRental.media_exp_return_date = custReader["media_exp_return_date"].ToString();
                                objRental.media_rental_cost = custReader["media_rental_cost"].ToString();


                                //Add customer to collection
                                rentalList.Add(objRental);
                            }
                        }
                    }

                    return rentalList;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                //Finally will always be called in a try..catch..statem. You can use to to close the connection
                //especially if an error is thrown
                if (objConn != null)
                {
                    objConn.Close();
                }
            }

        }

        public static Movie GetMovie(int movie_number)
        {
            //Uncomment either Example #1 or #2 to use appropriate connection string
            //Example #1 for connecting to a remote SQL Server instance via IP address and SQL Server authenication..For Meramec
            //string connectionString = "Server=198.209.220.125;Database=bevineau;User Id=chris;Password=chris;";

            //Example #2 for connecting to SQL Server locally with Windows Authenication. Change accordingly to your environment.
            string connectionString = @"Data Source=netflixDataSet;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";

            string sqlString = "Select movie_number, movie_title, Description, movie_year_made, genre_id, " +
                                " movie_rating, media_type, movie_retail_cost, tape_rental_cost, copies_on_hand, image, trailer from MOVIE" +
                               " where movie_number = @movie_number";

            SqlCommand objCommand = null;
            SqlConnection objConn = null;
            SqlDataReader custReader = null;
            Movie objMovie = null;
            try
            {
                using (objConn = new SqlConnection(connectionString))
                {
                    //Open the connection to the datbase
                    objConn.Open();
                    //Create a command object with the SQL statement
                    using (objCommand = new SqlCommand(sqlString, objConn))
                    {
                        //Set command parameter
                        objCommand.Parameters.AddWithValue("@movie_number", movie_number);
                        //Execute the SQL and return a DataReader
                        using ((custReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection)))
                        {
                            while (custReader.Read())
                            {
                                objMovie = new Movie();
                                //Fill the customer object if found
                                objMovie.movie_number = custReader["movie_number"].ToString();
                                objMovie.movie_title = custReader["movie_title"].ToString();
                                objMovie.Description = custReader["Description"].ToString();
                                objMovie.movie_year_made = custReader["movie_year_made"].ToString();
                                objMovie.genre_id = custReader["genre_id"].ToString();
                                objMovie.movie_rating = custReader["movie_rating"].ToString();
                                objMovie.media_type = custReader["media_type"].ToString();
                                objMovie.movie_retail_cost = custReader["movie_retail_cost"].ToString();
                                objMovie.tape_rental_cost = custReader["tape_rental_cost"].ToString();
                                objMovie.copies_on_hand = custReader["copies_on_hand"].ToString();
                                objMovie.image = custReader["image"].ToString();
                                objMovie.trailer = custReader["trailer"].ToString();
                            }
                        }
                    }
                    return objMovie;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                //Finally will always be called in a try..catch..statem. You can use to to close the connection
                //especially if an error is thrown
                if (objConn != null)
                {
                    objConn.Close();
                }
            }


        }

        public static bool AddMovie(Movie objMovie)
        {
            //Uncomment either Example #1 or #2 to use appropriate connection string
            //Example #1 for connecting to a remote SQL Server instance via IP address and SQL Server authenication..For Meramec
            //string connectionString = "Server=198.209.220.125;Database=bevineau;User Id=chris;Password=chris;";

            //Example #2 for connecting to SQL Server locally with Windows Authenication. Change accordingly to your environment.
            string connectionString = @"Data Source=netflixDataSet;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";

            int rowsAffected = 0;

            SqlCommand objCommand = null;
            SqlConnection objConn = null;

            string sqlString;
            try
            {
                using (objConn = new SqlConnection(connectionString))
                {
                    //Open the connection to the datbase
                    objConn.Open();
                    sqlString = "INSERT into MOVIE values ("
                             + "@movie_number, @movie_title, @Description, @movie_year_made, @genre_id, @movie_rating, @media_type, @movie_retail_cost, @tape_rental_cost, @copies_on_hand, @image, @trailer)";


                    //Create a command object with the SQL statement
                    using (objCommand = new SqlCommand(sqlString, objConn))
                    {
                        //Use the command parameters method to set the paramater values of the SQL Insert statement
                        objCommand.Parameters.AddWithValue("@movie_number", objMovie.movie_number);
                        objCommand.Parameters.AddWithValue("@movie_title", objMovie.movie_title);
                        objCommand.Parameters.AddWithValue("@Description", objMovie.Description);
                        objCommand.Parameters.AddWithValue("@movie_year_made", objMovie.movie_year_made);
                        objCommand.Parameters.AddWithValue("@genre_id", objMovie.genre_id);
                        objCommand.Parameters.AddWithValue("@movie_rating", objMovie.movie_rating);
                        objCommand.Parameters.AddWithValue("@media_type", objMovie.media_type);
                        objCommand.Parameters.AddWithValue("@movie_retail_cost", objMovie.movie_retail_cost);
                        objCommand.Parameters.AddWithValue("@tape_rental_cost", objMovie.tape_rental_cost);
                        objCommand.Parameters.AddWithValue("@copies_on_hand", objMovie.copies_on_hand);
                        objCommand.Parameters.AddWithValue("@image", objMovie.image);
                        objCommand.Parameters.AddWithValue("@trailer", objMovie.trailer);
                        //Execute the SQL and return the number of rows affected
                        rowsAffected = objCommand.ExecuteNonQuery();
                    }
                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                //Finally will always be called in a try..catch..statem. You can use to to close the connection
                //especially if an error is thrown
                if (objConn != null)
                {
                    objConn.Close();
                }
            }

        }

        public static bool UpdateMovie(Movie objMovie)
        {
            //Uncomment either Example #1 or #2 to use appropriate connection string
            //Example #1 for connecting to a remote SQL Server instance via IP address and SQL Server authenication..For Meramec
            //string connectionString = "Server=198.209.220.125;Database=bevineau;User Id=chris;Password=chris;";

            //Example #2 for connecting to SQL Server locally with Windows Authenication. Change accordingly to your environment.
            string connectionString = @"Data Source=netflixDataSet;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";

            int rowsAffected = 0;

            SqlCommand objCommand = null;
            SqlConnection objConn = null;

            string sqlString;
            try
            {
                using (objConn = new SqlConnection(connectionString))
                {
                    //Open the connection to the datbase
                    objConn.Open();
                    sqlString = "UPDATE MOVIE " + Environment.NewLine +
                                "set movie_title = @movie_title, " + Environment.NewLine +
                                "    Description = @Description, " + Environment.NewLine +
                                "    movie_year_made = @movie_year_made, " + Environment.NewLine +
                                "    genre_id = @genre_id, " + Environment.NewLine +
                                "    movie_rating = @movie_rating, " + Environment.NewLine +
                                "    media_type = @media_type, " + Environment.NewLine +
                                "    movie_retail_cost = @movie_retail_cost, " + Environment.NewLine +
                                "    tape_rental_cost = @tape_rental_cost, " + Environment.NewLine +
                                "    copies_on_hand = @copies_on_hand, " + Environment.NewLine +
                                "    image = @image " + Environment.NewLine +
                                "    trailer = @trailer " + Environment.NewLine +
                                "where movie_number = @movie_number ";

                    //Create a command object with the SQL statement
                    using (objCommand = new SqlCommand(sqlString, objConn))
                    {
                        //Use the command parameters method to set the paramater values of the SQL Insert statement
                        objCommand.Parameters.AddWithValue("@movie_number", objMovie.movie_number);
                        objCommand.Parameters.AddWithValue("@movie_title", objMovie.movie_title);
                        objCommand.Parameters.AddWithValue("@Description", objMovie.Description);
                        objCommand.Parameters.AddWithValue("@movie_year_made", objMovie.movie_year_made);
                        objCommand.Parameters.AddWithValue("@genre_id", objMovie.genre_id);
                        objCommand.Parameters.AddWithValue("@movie_rating", objMovie.movie_rating);
                        objCommand.Parameters.AddWithValue("@media_type", objMovie.media_type);
                        objCommand.Parameters.AddWithValue("@movie_retail_cost", objMovie.movie_retail_cost);
                        objCommand.Parameters.AddWithValue("@tape_rental_cost", objMovie.tape_rental_cost);
                        objCommand.Parameters.AddWithValue("@copies_on_hand", objMovie.copies_on_hand);
                        objCommand.Parameters.AddWithValue("@image", objMovie.image);
                        objCommand.Parameters.AddWithValue("@trailer", objMovie.trailer);

                        //Execute the SQL and return the number of rows affected
                        rowsAffected = objCommand.ExecuteNonQuery();
                    }
                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                //Finally will always be called in a try..catch..statem. You can use to to close the connection
                //especially if an error is thrown
                if (objConn != null)
                {
                    objConn.Close();
                }

            }

        }
        public static bool DeleteMovie(Movie objMovie)
        {
            //Uncomment either Example #1 or #2 to use appropriate connection string
            //Example #1 for connecting to a remote SQL Server instance via IP address and SQL Server authenication..For Meramec
            //string connectionString = "Server=198.209.220.125;Database=bevineau;User Id=chris;Password=chris;";

            //Example #2 for connecting to SQL Server locally with Windows Authenication. Change accordingly to your environment.
            string connectionString = @"Data Source=netflixDataSet;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";

            int rowsAffected = 0;

            SqlConnection objConn = null;
            SqlCommand objCommand = null;

            string sqlString;
            try
            {
                using (objConn = new SqlConnection(connectionString))
                {
                    //Open the connection to the datbase
                    objConn.Open();
                    sqlString = "DELETE MOVIE where movie_number = @movie_number";

                    //Create a command object with the SQL statement
                    using (objCommand = new SqlCommand(sqlString, objConn))
                    {
                        //Use the command parameters method to set the paramater values of the SQL Insert statement
                        objCommand.Parameters.AddWithValue("@movie_number", objMovie.movie_number);
                        //Execute the SQL and return the number of rows affected
                        rowsAffected = objCommand.ExecuteNonQuery();
                        //Close the database connection
                        objConn.Close();

                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                //Finally will always be called in a try..catch..statem. You can use to to close the connection
                //especially if an error is thrown
                if (objConn != null)
                {
                    objConn.Close();
                }

            }
        }



    }
}

