using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace FirstEmployeeDesktop
{
    public partial class View : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\priya\OneDrive\Documents\EmployeeMS.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

        public View()
        {
            InitializeComponent();
        }

        readonly SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\priya\OneDrive\Documents\EmployeeMS.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String empId = textEmployeeId.Text.Trim();
            if (string.IsNullOrEmpty(empId))
            {
                MessageBox.Show("Please an Employee id to search.");
                return;
            }
            String query = "select EmpId, EmpName, EmpGender, EmpDepartment from EmployeeTable WHERE EmpId=@Id ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", empId);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textEmpId.Text = reader["EmpId"].ToString();
                    textEmpName.Text = reader["EmpName"].ToString();
                    comboBoxGender.Text = reader["EmpGender"].ToString();
                    comboBoxDept.Text = reader["EmpDepartment"].ToString();
                }
                else
                {
                    MessageBox.Show("Employee not found.");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void textEmpGen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // this.Hide(); // hide current (Home) form
            Home empForm = new Home();
            empForm.Show(); // opens home form modally
                            // show this form again when Employee form is closed
            this.Hide();
          
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textEmpId.Text) ||
                    string.IsNullOrWhiteSpace(textEmpName.Text) ||
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
                    cmd.Parameters.AddWithValue("@Id", textEmpId.Text);
                    cmd.Parameters.AddWithValue("@Name", textEmpName.Text);
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
                if (string.IsNullOrWhiteSpace(textEmpId.Text))
                {
                    MessageBox.Show("Please enter Employee ID to delete.");
                    return;
                }

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = "DELETE FROM EmployeeTable WHERE EmpId = @Id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", textEmpId.Text);

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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Show();
            this.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textEmpId.Text = "";
            textEmpName.Text = "";
            comboBoxGender.SelectedIndex = -1;
            comboBoxDept.SelectedIndex = -1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ViewAttendance at = new ViewAttendance();
            at.Show();
            this.Hide();
        }
    }
}

