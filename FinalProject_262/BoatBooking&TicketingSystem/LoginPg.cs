using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BoatBooking_TicketingSystem
{
    
    public partial class LoginPg : Form
    {
        public LoginPg()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }
        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
{
    // Retrieve the entered username and password
    string username = textBox1.Text.Trim();
    string password = textBox2.Text.Trim();


    // Validate input
    if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
    {
        MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }
    if(username == "admin" && password == "admin")
            {
                // Admin credentials are hardcoded for demonstration purposes
                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.Show();
                this.Hide(); // Hide the current form
                return;
            }

            // Database connection string
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\KLAIRE DAVIDE\Documents\BoatBTSystemDb.mdf"";Integrated Security=True;Connect Timeout=30";

    // Query to check credentials
    string query = "SELECT COUNT(1) FROM AdminDashboardTbl WHERE UName = @UName AND UPass = @UPass";

    try
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Add parameters to prevent SQL injection
                command.Parameters.AddWithValue("@UName", username);
                command.Parameters.AddWithValue("@UPass", password);

                // Execute the query
                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count == 1)
                {
                    // Credentials are valid, navigate to UserDashboard
                    UserDashboard userDashboard = new UserDashboard(); // Pass the username
                    userDashboard.Show();
                    this.Hide(); // Hide the current form
                }
                else
                {
                    // Invalid credentials
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
    catch (Exception ex)
    {
        // Handle any errors
        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}

        private void button1_Click(object sender, EventArgs e)
        {
            SignUp signUpForm = new SignUp();
            signUpForm.Show();
            this.Hide(); // Hide the current form
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Guest guest = new Guest();
            guest.Show();
            this.Hide(); // Hide the current form
        }
    }
    }





