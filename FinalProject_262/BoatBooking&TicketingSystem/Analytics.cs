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
    public partial class Analytics : Form
    {
        public Analytics()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide(); // Hide the current form
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Boats boats = new Boats();
            boats.Show();
            this.Hide(); // Hide the current form

        }

        private void label5_Click(object sender, EventArgs e)
        {
            LoginPg loginPg = new LoginPg();
            loginPg.Show();
            this.Hide(); // Hide the current form
        }

        private void AGPay_Click(object sender, EventArgs e)
        {
            ShowGuestTable();
        }
        private void ShowGuestTable()
        {
            // Database connection string
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\KLAIRE DAVIDE\Documents\BoatBTSystemDb.mdf"";Integrated Security=True;Connect Timeout=30";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // SQL query to fetch all data from the Guest table
                    string query = "SELECT * FROM Guest";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    // Bind the data to the BADGV DataGridView
                    BADGV.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the database operation
                MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AUPay_Click(object sender, EventArgs e)
        {
            ShowBoatTable();
        }
        private void ShowBoatTable()
        {
            // Database connection string
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\KLAIRE DAVIDE\Documents\BoatBTSystemDb.mdf"";Integrated Security=True;Connect Timeout=30";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // SQL query to fetch all data from the BoatTbl table
                    string query = "SELECT * FROM BoatTbl";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    // Bind the data to the BADGV DataGridView
                    BADGV.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the database operation
                MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AMS_Click(object sender, EventArgs e)
        {
            ShowEarnings();
        }
        private void ShowEarnings()
        {
            // Database connection string
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\KLAIRE DAVIDE\Documents\BoatBTSystemDb.mdf"";Integrated Security=True;Connect Timeout=30";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // SQL query to calculate GuestEarnings from Guest table and UserEarnings from Bookings table
                    string guestQuery = "SELECT SUM(CAST(GuestFare AS DECIMAL(18, 2))) AS GuestEarnings FROM Guest";
                    string userQuery = "SELECT SUM(CAST(BookPrice1 AS DECIMAL(18, 2))) AS UserEarnings FROM Bookings";

                    decimal guestEarnings = 0;
                    decimal userEarnings = 0;

                    // Calculate GuestEarnings
                    using (SqlCommand guestCmd = new SqlCommand(guestQuery, con))
                    {
                        object guestResult = guestCmd.ExecuteScalar();
                        guestEarnings = guestResult != DBNull.Value ? Convert.ToDecimal(guestResult) : 0;
                    }

                    // Calculate UserEarnings
                    using (SqlCommand userCmd = new SqlCommand(userQuery, con))
                    {
                        object userResult = userCmd.ExecuteScalar();
                        userEarnings = userResult != DBNull.Value ? Convert.ToDecimal(userResult) : 0;
                    }

                    // Create a DataTable to hold the earnings
                    DataTable earningsTable = new DataTable();
                    earningsTable.Columns.Add("EarningsType", typeof(string));
                    earningsTable.Columns.Add("Amount", typeof(decimal));

                    // Add rows for GuestEarnings and UserEarnings
                    earningsTable.Rows.Add("Guest Earnings", guestEarnings);
                    earningsTable.Rows.Add("User Earnings", userEarnings);

                    // Bind the DataTable to the BADGV DataGridView
                    BADGV.DataSource = earningsTable;
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the database operation
                MessageBox.Show($"An error occurred while loading earnings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
