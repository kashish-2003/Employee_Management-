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

namespace FirstEmployeeDesktop
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        public static class UserSession
        {
            public static string username { get; set; } 
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String admin = txtAdmin.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(admin) && string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Missing Information");
            }
            else if (admin == "admin" && password == "password")
            {
                Home H = new Home();
                H.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Please Enter Correct Username And Password");
        }


        private void button3_Click(object sender, EventArgs e)
        {
            txtAdmin.Text = " ";
            txtPassword.Text = " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UserLogin user = new UserLogin();
            user.Show();
            this.Hide();
        }

       
    }
}
         
           
    


