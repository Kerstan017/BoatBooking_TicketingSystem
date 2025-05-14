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

namespace BoatBooking_TicketingSystem
{
    public partial class UserDashboard : Form
    {
        private string loggedInUserName;

        public UserDashboard()
        {
            InitializeComponent();
        }

        private void Sedit_Click(object sender, EventArgs e)
        {
            // Validate that the logged-in username is available
            if (string.IsNullOrEmpty(loggedInUserName))
            {
                MessageBox.Show("No user is currently logged in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Database connection string
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\KLAIRE DAVIDE\Documents\BoatBTSystemDb.mdf"";Integrated Security=True;Connect Timeout=30";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // SQL query to fetch the logged-in user's data
                    string query = "SELECT UName, UPass, UPhone, UAdd FROM AdminDashboardTbl WHERE UName = @UName";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@UName", loggedInUserName);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Populate the textboxes with the user's data
                                Suser.Text = reader["UName"].ToString();
                                Spass.Text = reader["UPass"].ToString();
                                Sphone.Text = reader["UPhone"].ToString();
                                Sadd.Text = reader["UAdd"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("User data not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the database operation
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Sreq_Click(object sender, EventArgs e)
        {
            // Trim all inputs to remove unnecessary whitespace
            string user = Suser.Text.Trim();
            string phone = Sphone.Text.Trim();
            string address = Sadd.Text.Trim();
            string password = Spass.Text.Trim();
            string request = Sreqq.Text.Trim();

            // Assign default values if any textbox is empty
            user = string.IsNullOrEmpty(user) ? "" : user;
            phone = string.IsNullOrEmpty(phone) ? "" : phone;
            address = string.IsNullOrEmpty(address) ? "" : address;
            password = string.IsNullOrEmpty(password) ? "" : password;
            request = string.IsNullOrEmpty(request) ? "" : request;

            // Database connection string
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\KLAIRE DAVIDE\Documents\BoatBTSystemDb.mdf"";Integrated Security=True;Connect Timeout=30";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // SQL query to insert data into UserReq table
                    string query = "INSERT INTO UserReq (USuser, USphone, USadd, USpass, USreq) " +
                                   "VALUES (@USuser, @USphone, @USadd, @USpass, @USreq)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@USuser", user);
                        cmd.Parameters.AddWithValue("@USphone", phone);
                        cmd.Parameters.AddWithValue("@USadd", address);
                        cmd.Parameters.AddWithValue("@USpass", password);
                        cmd.Parameters.AddWithValue("@USreq", request);

                        // Execute the query
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Request submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Optionally, clear the textboxes after saving
                        Suser.Clear();
                        Sphone.Clear();
                        Sadd.Clear();
                        Spass.Clear();
                        Sreqq.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the database operation
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BookLb3_Click(object sender, EventArgs e)
        {
            Book bookForm = new Book();
            bookForm.Show();
            this.Hide();
        }

        private void LogoutLb3_Click(object sender, EventArgs e)
        {
            LoginPg loginForm = new LoginPg();

            // Show the LoginPg form
            loginForm.Show();

            // Hide the current AdminDashboard form
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            UserDashboard userDashboard = new UserDashboard();
            userDashboard.Show();
            this.Hide();
        }
    }
}
