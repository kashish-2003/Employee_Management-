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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace FirstEmployeeDesktop
{
    public partial class Employee : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\priya\OneDrive\Documents\EmployeeMS.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

        public Employee()
        {
            InitializeComponent();
            DisplayEmployee();
        }

        private void DisplayEmployee()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM EmployeeTable";
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtId.Text) ||
                    string.IsNullOrWhiteSpace(txtName.Text) ||
                    comboBoxGender.SelectedItem == null ||
                    comboBoxDept.SelectedItem == null)
                {
                    MessageBox.Show("Please fill all the fields.");
                    return;
                }

                char[] specialChars = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '=', '+', '{', '}', '[', ']', ':', ';', '"', '\'', '<', '>', ',', '.', '?', '/' };
                if (txtId.Text.Any(c => specialChars.Contains(c)) || txtName.Text.Any(c => specialChars.Contains(c)))
                {
                    MessageBox.Show("ID and Name cannot contain special characters.");
                    return;
                }

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string checkQuery = "SELECT COUNT(*) FROM EmployeeTable WHERE EmpId = @Id";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue("@Id", txtId.Text);

                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("This employeeID already exists.");
                        return;
                    }

                    string query = "INSERT INTO EmployeeTable (EmpId, EmpName, EmpGender, EmpDepartment) " +
                                   "VALUES (@Id, @Name, @Gender, @Department)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", txtId.Text);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Gender", comboBoxGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Department", comboBoxDept.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Employee added successfully!");
                }

                DisplayEmployee();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtId.Text) ||
                    string.IsNullOrWhiteSpace(txtName.Text) ||
                    comboBoxGender.SelectedItem == null ||
                    comboBoxDept.SelectedItem == null)
                {
                    MessageBox.Show("Please fill all the fields.");
                    return;
                }

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = "UPDATE EmployeeTable SET EmpName = @Name, EmpGender = @Gender, EmpDepartment = @Department WHERE EmpId = @Id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", txtId.Text);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Gender", comboBoxGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Department", comboBoxDept.SelectedItem.ToString());

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Employee updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Employee not found. Please check the Employee ID.");
                    }
                }

                DisplayEmployee();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Please enter Employee ID to delete.");
                    return;
                }

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = "DELETE FROM EmployeeTable WHERE EmpId = @Id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", txtId.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Employee deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Employee not found. Please check the Employee ID.");
                    }
                }

                DisplayEmployee();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            comboBoxGender.SelectedIndex = -1;
            comboBoxDept.SelectedIndex = -1;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home empForm = new Home();
            empForm.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
        private void label2_Click(object sender, EventArgs e)
        {
           
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void labelEmpGen_Click(object sender, EventArgs e)
        {

        }
    }
}








