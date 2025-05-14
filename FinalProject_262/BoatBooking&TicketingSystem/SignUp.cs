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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close the application when the exit label is clicked
        }

        private void SUsave_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SUname.Text) || string.IsNullOrWhiteSpace(SUadd.Text) ||
               string.IsNullOrWhiteSpace(SUpass.Text) || string.IsNullOrWhiteSpace(SUphone.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate that SUphone contains a valid number
            if (!long.TryParse(SUphone.Text, out _))
            {
                MessageBox.Show("Please enter a valid phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Database connection string
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\KLAIRE DAVIDE\Documents\BoatBTSystemDb.mdf"";Integrated Security=True;Connect Timeout=30";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // SQL query to insert data into AdminDashboardTbl
                    string query = "INSERT INTO AdminDashboardTbl (UName, UAdd, UPass, UPhone) " +
                                   "VALUES (@UName, @UAdd, @UPass, @UPhone)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@UName", SUname.Text);
                        cmd.Parameters.AddWithValue("@UAdd", SUadd.Text);
                        cmd.Parameters.AddWithValue("@UPass", SUpass.Text);
                        cmd.Parameters.AddWithValue("@UPhone", SUphone.Text);

                        // Execute the query
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Optionally, clear the textboxes after saving
                        SUname.Clear();
                        SUadd.Clear();
                        SUpass.Clear();
                        SUphone.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the database operation
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SULogin_Click(object sender, EventArgs e)
        {
            LoginPg loginForm = new LoginPg();
            loginForm.Show();
            this.Hide(); // Hide the current form
        }
    }
}
