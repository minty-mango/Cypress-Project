using System;
using System.Windows.Forms;

namespace Cypress
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Security secUser = new Security();
            if (secUser.ValidateUser(UsernameField.Text, PasswordField.Text))
            {
                this.Hide();
                MainForm f2 = new MainForm();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Invalid Password or Username");
            }
        }

        private void accountCreation(object sender, MouseEventArgs e)
        {
            AccountCreation acf = new AccountCreation();
            acf.Show();
        }
    }
}
