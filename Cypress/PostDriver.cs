using System;
using System.Data.SqlClient;

namespace Cypress
{
    class PostDriver
    {
        private SqlConnection connection;
        private SqlCommand cmd;

        public void post_report(int report, string aAddress)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\FRANCIS\Desktop\Projects\C#\Cypress\Cypress\Database.mdf;Integrated Security=True";
            string information = "INSERT INTO Report VALUES (@Address, @Report, @Date)";
            string aReport ="";
            DateTime thisDate = DateTime.Now;
            string stringDate = thisDate.ToString();
            

            switch(report)
            {
                case 1:
                    aReport = "Utility Failure";
                    break;
                case 2:
                    aReport = "Potholes";
                    break;
                case 3:
                    aReport = "City Property Vandalism";
                    break;
                case 4:
                    aReport = "Eroded Streets";
                    break;
                case 5:
                    aReport = "Tree Colllapse";
                    break;
                case 6:
                    aReport = "Flodded Streets";
                    break;
                case 7:
                    aReport = "Mould and Spore Growth";
                    break;
                case 8:
                    aReport = "Garbage or any other Road Blocking Objects";
                    break;
                default:
                    break;
            }

            using (connection = new SqlConnection(connectionString))
            using (cmd = new SqlCommand(information, connection))
            {
                connection.Open();

                cmd.Parameters.AddWithValue("@Address", aAddress);
                cmd.Parameters.AddWithValue("@Report", aReport);
                cmd.Parameters.AddWithValue("@Date", stringDate);

                cmd.ExecuteNonQuery();
            }
        }
    
        public void editReport(int report, string address)
        {
            throw new NotImplementedException();
        }

        public void deleteReport(int report, string address)
        {
            throw new NotImplementedException();
        }
    }
}
