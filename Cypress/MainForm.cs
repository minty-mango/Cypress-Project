using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Cypress
{
    public partial class MainForm : Form
    {
        private int reportNumber;
        private PostDriver poster;
        private SqlConnection connection;

        
        public MainForm()
        {
            InitializeComponent();
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = false;
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
        }

        /*
         * Report Button
         */
        private void button2_Click_1(object sender, EventArgs e)
        {
            poster = new PostDriver();
            if (checkIfSelected() == true && AddressBox.Text != "")
            {
                poster.post_report(reportNumber, AddressBox.Text);
                MessageBox.Show("Report Sent");
                resetRadioButton();
                MainPanel.Visible = true;
            }
            else
                MessageBox.Show("Missing Information");
        }

        private bool checkIfSelected()
        {
            if (radioButton1.Checked)
            {
                reportNumber = 1;
                return true;
            }
            if (radioButton2.Checked)
            {
                reportNumber = 2;
                return true;
            }
            if (radioButton3.Checked)
            {
                reportNumber = 3;
                return true;
            }
            if (radioButton4.Checked)
            {
                reportNumber = 4;
                return true;
            }
            if (radioButton5.Checked)
            {
                reportNumber = 5;
                return true;
            }
            if (radioButton6.Checked)
            {
                reportNumber = 6;
                return true;
            }
            if (radioButton7.Checked)
            {
                reportNumber = 7;
                return true;
            }
            if (radioButton8.Checked)
            {
                reportNumber = 8;
                return true;
            }
            return false;
        }

        // Resets all the radio buttons
        private void resetRadioButton()
        {
            AddressBox.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
        }

        private void populateList()
        {
            string connStr = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\FRANCIS\Desktop\Projects\C#\Cypress\Cypress\Database.mdf;Integrated Security=True";
            string sqlStr = "SELECT * FROM Report";

            using (connection = new SqlConnection(connStr))
            using (SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, connection))
            {
                DataTable reportTable = new DataTable();
                adapter.Fill(reportTable);

                listBox1.DisplayMember = "Report";
                listBox1.ValueMember = "Address";
                listBox1.DataSource = reportTable;
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            populateList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            populateList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReportViewer.Clear();
            ReportViewer.AppendText(listBox1.SelectedValue.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm LF = new LoginForm();
            LF.Show();
        }
    }
}
