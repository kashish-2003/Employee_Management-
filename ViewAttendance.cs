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
    public partial class ViewAttendance : Form
    {
        public ViewAttendance()
        {
            InitializeComponent();
        }
        readonly SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\priya\OneDrive\Documents\EmployeeMS.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            String attId = textEmployeeId.Text.Trim();
            if (string.IsNullOrEmpty(attId))
            {
                MessageBox.Show("Please enter an Attendance Id to search.");
                return;
            }

            // Query with today's date filter
            String query = "SELECT TOP 1 Id, [Check in], [Check out], Duration, [Date] FROM Attendance WHERE [Id]=@Id AND [Date]=@TodayDate";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", attId);
            cmd.Parameters.AddWithValue("@TodayDate", DateTime.Today.Date);  // filters to today's date

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textId.Text = reader["Id"].ToString();
                    textCheckin.Text = reader["Check in"].ToString();
                    textcheckout.Text = reader["Check out"].ToString();
                    textduration.Text = reader["Duration"].ToString();
                    textdate.Text = reader["Date"].ToString();
                }
                else
                {
                    MessageBox.Show("No attendance found for today.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            View Form = new View();
            Form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MonthlyReport monthlyReport = new MonthlyReport();
            monthlyReport.Show();
            this.Hide();
        }
    }
}