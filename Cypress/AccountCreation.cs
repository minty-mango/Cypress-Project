using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cypress
{
    public partial class AccountCreation : Form
    {
        private SqlConnection connection;
        private SqlCommand cmd;

        public AccountCreation()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // Confirm button
        // Once clicked it sends the information into the SQL database
        private void button1_Click(object sender, EventArgs e)
        {
            createAccount(EmailBox.Text, FullNameBox.Text, AddressBox.Text, SinBox_01.Text + SinBox_02.Text + SinBox_03.Text, UsernameBox.Text, PasswordBox.Text, 1);
            this.Hide();
        }
        
        private void createAccount(string aEmail, string aName, string aAddress, string aSinNumber, string aUsername, string aPassword, int account_type)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\FRANCIS\Desktop\Projects\C#\Cypress\Cypress\Database.mdf;Integrated Security=True";
            string information = "INSERT INTO Information VALUES (@Email, @Name, @Address, @SinNumber)";
            string login = "INSERT INTO Login VALUES (@Username, @Password, @Account_Type)";

            using (connection = new SqlConnection(connectionString))
            using (cmd = new SqlCommand(information, connection))
             {
                connection.Open();

                cmd.Parameters.AddWithValue("@Email", aEmail);
                cmd.Parameters.AddWithValue("@Name", aName);
                cmd.Parameters.AddWithValue("@Address", aAddress);
                cmd.Parameters.AddWithValue("@SinNumber", aSinNumber);

             cmd.ExecuteNonQuery();
             }

            using (connection = new SqlConnection(connectionString))
            using (cmd = new SqlCommand(login, connection))
            {
                connection.Open();

                cmd.Parameters.AddWithValue("@Username", aUsername);
                cmd.Parameters.AddWithValue("@Password", aPassword);
                cmd.Parameters.AddWithValue("@Account_Type", account_type);

                cmd.ExecuteNonQuery();
            }

        }
    }
}
