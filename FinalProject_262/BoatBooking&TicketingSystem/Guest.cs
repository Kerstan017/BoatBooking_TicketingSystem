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
    public partial class Guest : Form
    {
        public Guest()
        {
            InitializeComponent();
            populateGuestDGV(); // Populate the DataGridView when the form loads
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close the application when the exit label is clicked
        }
        private void populateGuestDGV()
        {
            try
            {
                // Connection string to the database
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\KLAIRE DAVIDE\Documents\BoatBTSystemDb.mdf"";Integrated Security=True;Connect Timeout=30";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // SQL query to fetch data from BoatTbl
                    string query = "SELECT * FROM BoatTbl";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);

                    // Bind the data to the GuestDGV DataGridView
                    GuestDGV.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message);
            }
        }

        private void GuestDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Ensure the user clicked a valid row
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = GuestDGV.Rows[e.RowIndex];

                    // Assign the values from the selected row to the respective textboxes
                    GRoute.Text = row.Cells["BRoute"].Value.ToString();
                    GBoat.Text = row.Cells["BName"].Value.ToString();
                    GSched.Text = row.Cells["BSchedule"].Value.ToString();
                    GPrice.Text = row.Cells["BPriceT"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while selecting data: " + ex.Message);
            }
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(GSearch.Text))
            {
                populateGuestDGV(); // Reload all data if the search box is empty
            }
            else
            {
                try
                {
                    string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\KLAIRE DAVIDE\Documents\BoatBTSystemDb.mdf"";Integrated Security=True;Connect Timeout=30";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string query = "SELECT * FROM BoatTbl WHERE BName LIKE @SearchTerm OR BRoute LIKE @SearchTerm";
                        SqlDataAdapter sda = new SqlDataAdapter(query, con);
                        sda.SelectCommand.Parameters.AddWithValue("@SearchTerm", "%" + GSearch.Text + "%");
                        DataSet ds = new DataSet();
                        sda.Fill(ds);

                        // Bind the filtered data to the GuestDGV DataGridView
                        GuestDGV.DataSource = ds.Tables[0];
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while searching: " + ex.Message);
                }
            }
        }

        private void GPay_Click(object sender, EventArgs e)
        {
            // Validate that all textboxes are filled
            if (string.IsNullOrWhiteSpace(GRoute.Text) || string.IsNullOrWhiteSpace(GSched.Text) ||
                string.IsNullOrWhiteSpace(GBoat.Text) || string.IsNullOrWhiteSpace(GSeat.Text) ||
                string.IsNullOrWhiteSpace(GPrice.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate that GSeat contains a valid number
            if (!int.TryParse(GSeat.Text, out int seatCount) || seatCount <= 0)
            {
                MessageBox.Show("Please enter a valid number of seats.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate that GPrice contains a valid decimal number
            if (!decimal.TryParse(GPrice.Text, out decimal pricePerSeat))
            {
                MessageBox.Show("Invalid price format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Calculate the total fare
            decimal totalFare = seatCount * pricePerSeat;

            // Database connection string
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\KLAIRE DAVIDE\Documents\BoatBTSystemDb.mdf"";Integrated Security=True;Connect Timeout=30";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // SQL query to insert data into the Guest table
                    string query = "INSERT INTO Guest (GuestRoute, GuestSchedule, GuestBoat, GuestSeat, GuestFare) " +
                                   "VALUES (@GuestRoute, @GuestSchedule, @GuestBoat, @GuestSeat, @GuestFare)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@GuestRoute", GRoute.Text);
                        cmd.Parameters.AddWithValue("@GuestSchedule", GSched.Text);
                        cmd.Parameters.AddWithValue("@GuestBoat", GBoat.Text);
                        cmd.Parameters.AddWithValue("@GuestSeat", seatCount);
                        cmd.Parameters.AddWithValue("@GuestFare", totalFare);

                        // Execute the query
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the database operation
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Payment pay = new Payment();
            pay.Show();
            this.Hide();
        }

        private void Gback_Click(object sender, EventArgs e)
        {
            LoginPg loginPg = new LoginPg();
            loginPg.Show();
            this.Hide();
        }
    }
}
