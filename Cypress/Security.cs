using System;
using System.Data.SqlClient;

namespace Cypress
{
    class Security 
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private SqlCommand cmd;
        private string connectionString;

        public Security()
        {
            connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\FRANCIS\Desktop\Projects\C#\Cypress\Cypress\Database.mdf;Integrated Security=True";
        }


        public bool ValidateUser(string username, string password)
        {
            bool valid = false;

            using (connection = new SqlConnection(connectionString))
            using (adapter = new SqlDataAdapter("SELECT * FROM Login", connection))
            {
                connection.Open();
                using (cmd = new SqlCommand("Select count(*) from [Login] where userName = @username and password = @password", connection))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);
                    valid = (int)cmd.ExecuteScalar() > 0;
                }
                if (valid)
                    return valid;
            }
            return valid;
        }

        // @TODO Add in administation validation
        public bool isAdmin()
        {
            throw new NotImplementedException();
        }

        public void changePassword(String password)
        {
            throw new NotImplementedException();
        }
    }
}
