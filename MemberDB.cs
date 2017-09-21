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
    public static class MemberDB
    {


        public static List<Member> GetMembers()
        {
            //Uncomment either Example #1 or #2 to use appropriate connection string
            //Example #1 for connecting to a remote SQL Server instance via IP address and SQL Server authenication..For Meramec
            //string connectionString = "Server=198.209.220.125;Database=bevineau;User Id=chris;Password=chris;";

            //Example #2 for connecting to SQL Server locally with Windows Authenication. Change accordingly to your environment.
            string connectionString = @"Data Source=netflixDataSet;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";

            List<Member> memberList = new List<Member>();
            //string connectionString = @"Data Source=STEVIE-LAPTOP\MSSQLSERVER1;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
            string sqlString = "Select number, joindate, firstname, lastname, address, " +
                                " city, state, zipcode, phone, member_status, password from MEMBER";

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
                                Member objMember = new Member();
                                objMember.number = custReader["number"].ToString();
                                objMember.joindate = custReader["joindate"].ToString();
                                objMember.firstname = custReader["firstname"].ToString();
                                objMember.lastname = custReader["lastname"].ToString();
                                objMember.Address = custReader["address"].ToString();
                                objMember.City = custReader["city"].ToString();
                                objMember.State = custReader["state"].ToString();
                                objMember.Zipcode = custReader["zipcode"].ToString();
                                objMember.phone = custReader["phone"].ToString();
                                objMember.member_status = custReader["member_status"].ToString();
                                objMember.password = custReader["password"].ToString();

                                //Add customer to collection
                                memberList.Add(objMember);
                            }
                        }
                    }

                    return memberList;
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

        public static Member GetMember(int number)
        {
            //Uncomment either Example #1 or #2 to use appropriate connection string
            //Example #1 for connecting to a remote SQL Server instance via IP address and SQL Server authenication..For Meramec
            //string connectionString = "Server=198.209.220.125;Database=bevineau;User Id=chris;Password=chris;";

            //Example #2 for connecting to SQL Server locally with Windows Authenication. Change accordingly to your environment.
            string connectionString = @"Data Source=netflixDataSet;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";

            string sqlString = "Select number, joindate, firstname, lastname, address, " +
                                " city, state, zipcode, phone, member_status, password from MEMBER" +
                               " where number = @number";

            SqlCommand objCommand = null;
            SqlConnection objConn = null;
            SqlDataReader custReader = null;
            Member objMember = null;
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
                        objCommand.Parameters.AddWithValue("@number", number);
                        //Execute the SQL and return a DataReader
                        using ((custReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection)))
                        {
                            while (custReader.Read())
                            {
                                objMember = new Member();
                                //Fill the customer object if found
                                objMember.number = custReader["number"].ToString();
                                objMember.joindate = custReader["joindate"].ToString();
                                objMember.firstname = custReader["firstname"].ToString();
                                objMember.lastname = custReader["lastname"].ToString();
                                objMember.Address = custReader["address"].ToString();
                                objMember.City = custReader["city"].ToString();
                                objMember.State = custReader["state"].ToString();
                                objMember.Zipcode = custReader["zipcode"].ToString();
                                objMember.phone = custReader["phone"].ToString();
                                objMember.member_status = custReader["member_status"].ToString();
                                objMember.password = custReader["password"].ToString();
                            }
                        }
                    }
                    return objMember;
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

        public static bool AddMember(Member objMember)
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
                    sqlString = "INSERT into MEMBER values ("
                             + "@number, @joindate, @firstname, @lastname, @address, @city, @state, @zipcode, @phone, @member_status, @password)";

                    //Create a command object with the SQL statement
                    using (objCommand = new SqlCommand(sqlString, objConn))
                    {
                        //Use the command parameters method to set the paramater values of the SQL Insert statement
                        objCommand.Parameters.AddWithValue("@number", objMember.number);
                        objCommand.Parameters.AddWithValue("@joindate", objMember.joindate);
                        objCommand.Parameters.AddWithValue("@firstname", objMember.firstname);
                        objCommand.Parameters.AddWithValue("@lastname", objMember.lastname);
                        objCommand.Parameters.AddWithValue("@address", objMember.Address);
                        objCommand.Parameters.AddWithValue("@city", objMember.City);
                        objCommand.Parameters.AddWithValue("@state", objMember.State);
                        objCommand.Parameters.AddWithValue("@zipcode", objMember.Zipcode);
                        objCommand.Parameters.AddWithValue("@phone", objMember.phone);
                        objCommand.Parameters.AddWithValue("@member_status", objMember.member_status);
                        objCommand.Parameters.AddWithValue("@password", objMember.password);
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

        public static bool UpdateMember(Member objMember)
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
                    sqlString = "UPDATE MEMBER " + Environment.NewLine +
                                "set joindate = @joindate, " + Environment.NewLine +
                                "    firstname = @firstname, " + Environment.NewLine +
                                "    lastname = @lastname, " + Environment.NewLine +
                                "    address = @address, " + Environment.NewLine +
                                "    city = @city, " + Environment.NewLine +
                                "    state = @state, " + Environment.NewLine +
                                "    zipcode = @zipcode, " + Environment.NewLine +
                                "    phone = @phone, " + Environment.NewLine +
                                "    member_status = @member_status, " + Environment.NewLine +
                                "    password = @password " + Environment.NewLine +
                                "where number = @number ";

                    //Create a command object with the SQL statement
                    using (objCommand = new SqlCommand(sqlString, objConn))
                    {
                        //Use the command parameters method to set the paramater values of the SQL Insert statement
                        objCommand.Parameters.AddWithValue("@number", objMember.number);
                        objCommand.Parameters.AddWithValue("@joindate", objMember.joindate);
                        objCommand.Parameters.AddWithValue("@firstname", objMember.firstname);
                        objCommand.Parameters.AddWithValue("@lastname", objMember.lastname);
                        objCommand.Parameters.AddWithValue("@address", objMember.Address);
                        objCommand.Parameters.AddWithValue("@city", objMember.City);
                        objCommand.Parameters.AddWithValue("@state", objMember.State);
                        objCommand.Parameters.AddWithValue("@zipcode", objMember.Zipcode);
                        objCommand.Parameters.AddWithValue("@phone", objMember.phone);
                        objCommand.Parameters.AddWithValue("@member_status", objMember.member_status);
                        objCommand.Parameters.AddWithValue("@password", objMember.password);
                        
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
        public static bool DeleteMember(Member objMember)
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
                    sqlString = "DELETE MEMBER where number = @number";

                    //Create a command object with the SQL statement
                    using (objCommand = new SqlCommand(sqlString, objConn))
                    {
                        //Use the command parameters method to set the paramater values of the SQL Insert statement
                        objCommand.Parameters.AddWithValue("@number", objMember.number);
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
