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
    public static class VendorDB
    {


        public static List<Vendor> GetVendor()
        {
            //Uncomment either Example #1 or #2 to use appropriate connection string
            //Example #1 for connecting to a remote SQL Server instance via IP address and SQL Server authenication..For Meramec
            //string connectionString = "Server=198.209.220.125;Database=bevineau;User Id=chris;Password=chris;";

            //Example #2 for connecting to SQL Server locally with Windows Authenication. Change accordingly to your environment.
            string connectionString = @"Data Source=netflixDataSet;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";

            List<Vendor> vendorList = new List<Vendor>();
            //string connectionString = @"Data Source=STEVIE-LAPTOP\MSSQLSERVER1;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
            string sqlString = "Select VendorID, VendorName from VENDORS";

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
                                Vendor objVendor = new Vendor();
                                objVendor.VendorID = custReader["VendorID"].ToString();
                                objVendor.VendorName = custReader["VendorName"].ToString();
                          

                                //Add customer to collection
                                vendorList.Add(objVendor);
                            }
                        }
                    }

                    return vendorList;
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

        public static Vendor GetVendor(int VendorID)
        {
            //Uncomment either Example #1 or #2 to use appropriate connection string
            //Example #1 for connecting to a remote SQL Server instance via IP address and SQL Server authenication..For Meramec
            //string connectionString = "Server=198.209.220.125;Database=bevineau;User Id=chris;Password=chris;";

            //Example #2 for connecting to SQL Server locally with Windows Authenication. Change accordingly to your environment.
            string connectionString = @"Data Source=netflixDataSet;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";

            string sqlString = "Select VendorID " +
                                " VendorName from VENDORS" +
                               " where VendorID = @VendorID";

            SqlCommand objCommand = null;
            SqlConnection objConn = null;
            SqlDataReader custReader = null;
            Vendor objVendor = null;
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
                        objCommand.Parameters.AddWithValue("@VendorID", VendorID);
                        //Execute the SQL and return a DataReader
                        using ((custReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection)))
                        {
                            while (custReader.Read())
                            {
                                objVendor = new Vendor();
                                //Fill the customer object if found
                                objVendor.VendorID = custReader["VendorID"].ToString();
                                objVendor.VendorName = custReader["VendorName"].ToString();
                                
                            }
                        }
                    }
                    return objVendor;
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

        public static bool AddVendor(Vendor objVendor)
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
                    sqlString = "INSERT into VENDORS values ("
                             + "@VendorID, @VendorName)";


                    //Create a command object with the SQL statement
                    using (objCommand = new SqlCommand(sqlString, objConn))
                    {
                        //Use the command parameters method to set the paramater values of the SQL Insert statement
                        objCommand.Parameters.AddWithValue("@VendorID", objVendor.VendorID);
                        objCommand.Parameters.AddWithValue("@VendorName", objVendor.VendorName);
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

        public static bool UpdateVendor(Vendor objVendor)
        {
            //Uncomment either Example #1 or #2 to use appropriate connection string
            //Example #1 for connecting to a remote SQL Server instance via IP address and SQL Server authenication..For Meramec
            //string connectionString = "Server=198.209.220.125;Database=bevineau;User Id=chris;Password=chris;";

            //Example #2 for connecting to SQL Server locally with Windows Authenication. Change accordingly to your environment.
            string connectionString = @"Data Source=STnetflixDataSetEVIE-LAPTOP\MSSQLSERVER1;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";

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
                    sqlString = "UPDATE VENDORS " + Environment.NewLine +
                                "set VendorName = @VendorName, " + Environment.NewLine +
                                "where VendorID = @VendorID ";

                    //Create a command object with the SQL statement
                    using (objCommand = new SqlCommand(sqlString, objConn))
                    {
                        //Use the command parameters method to set the paramater values of the SQL Insert statement
                        objCommand.Parameters.AddWithValue("@VendorID", objVendor.VendorID);
                        objCommand.Parameters.AddWithValue("@VendorName", objVendor.VendorName);

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
        public static bool DeleteVendor(Vendor objVendor)
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
                    sqlString = "DELETE VENDORS where VendorID = @VendorID";

                    //Create a command object with the SQL statement
                    using (objCommand = new SqlCommand(sqlString, objConn))
                    {
                        //Use the command parameters method to set the paramater values of the SQL Insert statement
                        objCommand.Parameters.AddWithValue("@VendorID", objVendor.VendorID);
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
