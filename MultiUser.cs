using static FirstEmployeeDesktop.LoginPage;
using System.Data.SqlClient;
using System.Windows.Forms;
using System;


namespace FirstEmployeeDesktop
{
    public partial class MultiUser : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\priya\OneDrive\Documents\EmployeeMS.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

        public MultiUser()
        {
            InitializeComponent();
        }
        private void btncheckin_Click(object sender, EventArgs e)
        {
            int userId = int.Parse(UserSession.username);
            DateTime checkInTime = DateTime.Now;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // Check if the user has already checked in today (even if he also checked out)
                    string checkQuery = @"
                SELECT COUNT(*) FROM Attendance 
                WHERE Id = @userId AND CAST([Check in] AS DATE) = @todayDate";

                    SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue("@userId", userId);
                    checkCmd.Parameters.AddWithValue("@todayDate", checkInTime.Date);

                    int openCount = (int)checkCmd.ExecuteScalar();

                    if (openCount == 0)
                    {
                        // Insert new check-in record
                        string insertQuery = "INSERT INTO Attendance (Id, [Check in], Date) VALUES (@userId, @checkInTime, @date)";
                        SqlCommand insertCmd = new SqlCommand(insertQuery, con);
                        insertCmd.Parameters.AddWithValue("@userId", userId);
                        insertCmd.Parameters.AddWithValue("@checkInTime", checkInTime);
                        insertCmd.Parameters.AddWithValue("@date", checkInTime.Date);

                        int rowsAffected = insertCmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Checked in at " + checkInTime.ToString("dd-MM-yyyy HH:mm:ss"));
                            LoadAttendanceData(userId);
                        }
                        else
                        {
                            MessageBox.Show("Check-in failed.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("You have already checked in today. Only one check-in allowed per day.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        //private void btncheckin_Click(object sender, EventArgs e)
        //{
        //    int userId = int.Parse(UserSession.username);
        //    DateTime checkInTime = DateTime.Now;

        //    using (SqlConnection con = new SqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            con.Open();

        //            //string checkQuery = "SELECT COUNT(*) FROM Attendance WHERE Id = @userId AND [Check out] IS NULL";
        //            string checkQuery = @"
        //            SELECT COUNT(*) FROM Attendance 
        //            WHERE Id = @userId AND CAST([Check in] AS DATE) = @todayDate";

        //            SqlCommand checkCmd = new SqlCommand(checkQuery, con);
        //            checkCmd.Parameters.AddWithValue("@userId", userId);
        //            checkCmd.Parameters.AddWithValue("@todayDate", checkInTime.Date);

        //            int openCount = (int)checkCmd.ExecuteScalar();

        //            if (openCount == 0)
        //            {
        //                // string insertQuery = "INSERT INTO Attendance (Id, [Check in], Date) VALUES (@userId, @checkInTime, @date)";
        //                string insertQuery = "INSERT INTO Attendance (Id, [Check in], Date) VALUES (@userId, @checkInTime, @date)";

        //                SqlCommand insertCmd = new SqlCommand(insertQuery, con);
        //                insertCmd.Parameters.AddWithValue("@userId", userId);
        //                insertCmd.Parameters.AddWithValue("@checkInTime", checkInTime);
        //                insertCmd.Parameters.AddWithValue("@date", checkInTime.Date);



        //                int rowsAffected = insertCmd.ExecuteNonQuery();
        //                if (rowsAffected > 0)
        //                {
        //                    MessageBox.Show("Checked in at " + checkInTime.ToString("dd-MM-yyyy HH:mm:ss"));
        //                    LoadAttendanceData(userId);
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Check-in failed.");
        //                }
        //            }
        //            else
        //            {
        //                MessageBox.Show("You are already checked in. Please check out before checking in again.");
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error: " + ex.Message);
        //        }
        //    }
        //}

        private void btncheckout_Click(object sender, EventArgs e)

        {


            int userId = int.Parse(UserSession.username);
            DateTime checkOutTime = DateTime.Now;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string selectQuery = @"
                            SELECT TOP 1 [Check in]
                            FROM Attendance
                            WHERE Id = @userId AND [Check out] IS NULL
                            ORDER BY [Check in] DESC";

                    SqlCommand selectCmd = new SqlCommand(selectQuery, con);
                    selectCmd.Parameters.AddWithValue("@userId", userId);

                    SqlDataReader reader = selectCmd.ExecuteReader();

                    if (reader.Read())
                    {
                        DateTime checkInTime = Convert.ToDateTime(reader["Check in"]);
                        reader.Close();

                        TimeSpan duration = checkOutTime - checkInTime;
                        string durationStr = duration.ToString(@"hh\:mm\:ss");
                        // string updateQuery = @"
                        // UPDATE Attendance
                        // SET [Check out] = @checkOutTime, [Duration] = @duration
                        // WHERE Id = @userId AND [Check out] IS NULL";
                        string updateQuery = @"
                            UPDATE Attendance
                            SET [Check out] = @checkOutTime, [Duration] = @duration, Date = @date
                            WHERE Id = @userId AND [Check out] IS NULL";


                        SqlCommand updateCmd = new SqlCommand(updateQuery, con);
                        updateCmd.Parameters.AddWithValue("@checkOutTime", checkOutTime);
                        updateCmd.Parameters.AddWithValue("@duration", durationStr);
                        updateCmd.Parameters.AddWithValue("@userId", userId);
                        updateCmd.Parameters.AddWithValue("@checkInTime", checkInTime);
                        updateCmd.Parameters.AddWithValue("@date", checkOutTime.Date);



                        int rowsAffected = updateCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Checked out at " + checkOutTime.ToString("dd-MM-yyyy HH:mm:ss") +
                                "\nDuration: " + durationStr);
                            UpdateCheckoutFields(checkOutTime, durationStr);
                            LoadAttendanceData(userId);
                        }
                        else
                        {
                            MessageBox.Show("Failed to update checkout.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No open check-in record found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void UpdateCheckoutFields(DateTime checkOut, string duration)
        {
            textcheckout.Text = checkOut.ToString("dd-MM-yyyy HH:mm:ss");
            textduration.Text = duration;
            textdate.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        public void LoadAttendanceData(long userId)
        {
            string query = @"
                SELECT TOP 1 e.EmpName, a.Id, a.[Check in], a.[Check out], a.Duration
                FROM EmployeeTable e
                JOIN Attendance a ON e.EmpId = a.Id
                WHERE a.Id = @Id
                ORDER BY a.[Check in] DESC";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", userId);

                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtName.Text = reader["EmpName"].ToString();
                        textId.Text = reader["Id"].ToString();
                        textCheckin.Text = reader["Check in"].ToString();
                        textcheckout.Text = reader["Check out"].ToString();
                        textduration.Text = reader["Duration"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No attendance record found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnCross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textduration_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCheckin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UserLogin h = new UserLogin();
            h.Show();
            this.Hide();
        }
    }
}
