using Resturaunt_web.Models;
using System;
using System.Data.SqlClient;
namespace Resturaunt_web.Services.Data
{ 

    public class SecurityDAO
    {
        //connect to database
        string connectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=aspnet-Resturaunt_web-5FC66A80-BE30-4304-B89D-62E966931DCB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        internal bool FindByUser(Login user)
        {
            bool success = false;

            //write sql
            string queryString = "SELECT * FROM dbo.Registered_Customers where CustomerEmail = @Email AND CustomerPassword = @Password";

            // create and open the connection to the database inside a using block.

            // this ensures that all resources are closed properly when the query is complete.
            //
            // protects against sql injection attacks/extra memory leaks/connections to database that is no longer in use.

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                // create the command and parameter object
                SqlCommand command = new SqlCommand(queryString, connection);
                // associate @xxxx with user.xxxx
                command.Parameters.Add("@Email", System.Data.SqlDbType.VarChar, 50).Value = user.Email;
                command.Parameters.Add("@Password", System.Data.SqlDbType.VarChar, 50).Value = user.Password;

                // open the database and run command.
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        success = true;
                    }
                    else
                    {
                        success = false;
                    }
                    reader.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
            }
            return success;
        }
    }
}
