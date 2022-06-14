using Resturaunt_web.Models;
using System;
using System.Data.SqlClient;
namespace Resturaunt_web.Services.Data
{

    public class RegistrationDAO
    {
        //connect to database
        string connectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=aspnet-Resturaunt_web-5FC66A80-BE30-4304-B89D-62E966931DCB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public void newUser(SignUp user)
        {
            string queryString = "INSERT INTO dbo.Registered_Customers (CustomerName, CustomerEmail, CustomerPhone, CustomerPassword) VALUES (@Name, @ Email, @PhoneNumber, @Password)";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@Name", System.Data.SqlDbType.VarChar, 50).Value = user.Username;
                command.Parameters.Add("@Email", System.Data.SqlDbType.VarChar, 50).Value = user.Email;
                command.Parameters.Add("@PhoneNumber", System.Data.SqlDbType.VarChar, 50).Value = user.PhoneNO;
                command.Parameters.Add("@Password", System.Data.SqlDbType.VarChar, 50).Value = user.Pwd;

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Records Inserted Successfully");
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Error Generated. Details: " + e.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
            
        }
    }
}
