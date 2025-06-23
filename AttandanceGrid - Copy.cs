using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FirstEmployeeDesktop
{
    public partial class AttandanceGrid : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\priya\OneDrive\Documents\EmployeeMS.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";
        public AttandanceGrid()
        {
            InitializeComponent();
            DisplayAttandance();
        }
        public void DisplayAttandance()
        {
            try
            {
               // string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\priya\OneDrive\Documents\EmployeeMS.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Attendance";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    // Set DataGridView colors here:
                    dataGridView1.BackgroundColor = Color.LightGray;
                    dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
                    dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
                    dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
                    dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
                    dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkOrange;
                    dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void btnCross_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
