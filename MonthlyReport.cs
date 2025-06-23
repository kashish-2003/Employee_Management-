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
    public partial class MonthlyReport : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\priya\OneDrive\Documents\EmployeeMS.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

        public MonthlyReport()
        {
            InitializeComponent();
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textEmployeeId.Text))
            {
                MessageBox.Show("Please enter an Employee ID.");
                return;
            }

            if (!int.TryParse(textEmployeeId.Text.Trim(), out int empId))
            {
                MessageBox.Show("Employee ID must be a number.");
                return;
            }

            DateTime fromDate = dateFrom.Value.Date;
            DateTime toDate = dateTo.Value.Date;

            if (fromDate > toDate)
            {
                MessageBox.Show("From date cannot be greater than To date.");
                return;
            }

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\priya\OneDrive\Documents\EmployeeMS.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            string query = @"SELECT [Date], [Check in], [Check out], [Duration]
                     FROM Attendance
                     WHERE Id = @EmpId AND [Date] BETWEEN @FromDate AND @ToDate
                     ORDER BY [Date]";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@EmpId", empId);
                cmd.Parameters.AddWithValue("@FromDate", fromDate);
                cmd.Parameters.AddWithValue("@ToDate", toDate);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridView.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No attendance records found for the selected date range.");
                    dataGridView.DataSource = null;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ViewAttendance viewAttendance = new ViewAttendance();
            viewAttendance.Show();
            this.Hide();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}