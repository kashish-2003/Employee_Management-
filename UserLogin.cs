using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FirstEmployeeDesktop.LoginPage;

namespace FirstEmployeeDesktop
{
    public partial class UserLogin : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\priya\OneDrive\Documents\EmployeeMS.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

        public UserLogin()
        {
            InitializeComponent();
        }

        private void BtnClr_Click(object sender, EventArgs e)
        {
            textuseriduser.Clear();
            txtUseridpassword.Clear();
        }

      
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textuseriduser.Text.Trim();
            string password = txtUseridpassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Missing Information");
                return;
            }

            if (VerifyCredentials(username, password))
            {
                UserSession.username = username;

                MultiUser mu = new MultiUser();
                mu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Enter Correct Username and Password");
            }
        }

        private bool VerifyCredentials(string userId, string password)
        {
            string query = "SELECT COUNT(1) FROM Userlogin WHERE username = @userId AND Password = @password";

            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, Con);
                    command.Parameters.AddWithValue("@userId", userId);
                    command.Parameters.AddWithValue("@password", password);

                    Con.Open();
                    int result = (int)command.ExecuteScalar();
                    return result == 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
        private void btnClr_Click(object sender, EventArgs e)
        {
            textuseriduser.Text = "";
            txtUseridpassword.Text = "";
        }

        private void AdminLoginBtn_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            login.Show();

            this.Hide();

        }

        private void btnCross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
