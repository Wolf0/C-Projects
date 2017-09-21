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
    public static class GenreDB
    {


        public static List<Genre> GetGenre()
        {
            //Uncomment either Example #1 or #2 to use appropriate connection string
            //Example #1 for connecting to a remote SQL Server instance via IP address and SQL Server authenication..For Meramec
            //string connectionString = "Server=198.209.220.125;Database=bevineau;User Id=chris;Password=chris;";

            //Example #2 for connecting to SQL Server locally with Windows Authenication. Change accordingly to your environment.
            string connectionString = @"Data Source=netflixDataSet;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";

            List<Genre> genreList = new List<Genre>();
            //string connectionString = @"Data Source=STEVIE-LAPTOP\MSSQLSERVER1;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
            string sqlString = "Select ID, name from GENRE";

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
                                Genre objGenre = new Genre();
                                objGenre.ID = custReader["ID"].ToString();
                                objGenre.name = custReader["name"].ToString();


                                //Add customer to collection
                                genreList.Add(objGenre);
                            }
                        }
                    }

                    return genreList;
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

        public static Genre GetGenre(int ID)
        {
            //Uncomment either Example #1 or #2 to use appropriate connection string
            //Example #1 for connecting to a remote SQL Server instance via IP address and SQL Server authenication..For Meramec
            //string connectionString = "Server=198.209.220.125;Database=bevineau;User Id=chris;Password=chris;";

            //Example #2 for connecting to SQL Server locally with Windows Authenication. Change accordingly to your environment.
            string connectionString = @"Data Source=netflixDataSet;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";

            string sqlString = "Select ID " +
                                " name from GENRE" +
                               " where ID = @ID";

            SqlCommand objCommand = null;
            SqlConnection objConn = null;
            SqlDataReader custReader = null;
            Genre objGenre = null;
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
                        objCommand.Parameters.AddWithValue("@ID", ID);
                        //Execute the SQL and return a DataReader
                        using ((custReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection)))
                        {
                            while (custReader.Read())
                            {
                                objGenre = new Genre();
                                //Fill the customer object if found
                                objGenre.ID = custReader["ID"].ToString();
                                objGenre.name = custReader["name"].ToString();

                            }
                        }
                    }
                    return objGenre;
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

        public static bool AddGenre(Genre objGenre)
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
                    sqlString = "INSERT into GENRE values ("
                             + "@ID, @name)";


                    //Create a command object with the SQL statement
                    using (objCommand = new SqlCommand(sqlString, objConn))
                    {
                        //Use the command parameters method to set the paramater values of the SQL Insert statement
                        objCommand.Parameters.AddWithValue("@ID", objGenre.ID);
                        objCommand.Parameters.AddWithValue("@name", objGenre.name);
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

        public static bool UpdateGenre(Genre objGenre)
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
                    sqlString = "UPDATE GENRE " + Environment.NewLine +
                                "set name = @name, " + Environment.NewLine +
                                "where ID = @ID ";

                    //Create a command object with the SQL statement
                    using (objCommand = new SqlCommand(sqlString, objConn))
                    {
                        //Use the command parameters method to set the paramater values of the SQL Insert statement
                        objCommand.Parameters.AddWithValue("@VendorID", objGenre.ID);
                        objCommand.Parameters.AddWithValue("@VendorName", objGenre.name);

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
        public static bool DeleteGenre(Genre objGenre)
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
                    sqlString = "DELETE GENRE where ID = @ID";

                    //Create a command object with the SQL statement
                    using (objCommand = new SqlCommand(sqlString, objConn))
                    {
                        //Use the command parameters method to set the paramater values of the SQL Insert statement
                        objCommand.Parameters.AddWithValue("@ID", objGenre.ID);
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
