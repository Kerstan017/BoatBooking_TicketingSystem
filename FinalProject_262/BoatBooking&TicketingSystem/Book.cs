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
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
            populateBookDGV();
        }
        private void populateBookDGV()
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

                    // Bind the data to the BookDGV DataGridView
                    BookDGV.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message);
            }
        }
        private void BookPay_Click(object sender, EventArgs e)
        {
            // Validate that all textboxes are filled
            if (string.IsNullOrWhiteSpace(BookBoat.Text) || string.IsNullOrWhiteSpace(BookRoute.Text) ||
                string.IsNullOrWhiteSpace(BookSched.Text) || string.IsNullOrWhiteSpace(BookSeat.Text) ||
                string.IsNullOrWhiteSpace(BookPrice.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Validate that BookSeat contains a valid number
            if (!int.TryParse(BookSeat.Text, out int seatCount) || seatCount <= 0)
            {
                MessageBox.Show("Please enter a valid number of seats.");
                return;
            }

            // Calculate the total price
            if (!decimal.TryParse(BookPrice.Text, out decimal pricePerSeat))
            {
                MessageBox.Show("Invalid price format.");
                return;
            }
            decimal totalPrice = seatCount * pricePerSeat;

            // Database connection string
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\KLAIRE DAVIDE\Documents\BoatBTSystemDb.mdf"";Integrated Security=True;Connect Timeout=30";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // SQL query to insert data into Bookings table
                    string query = "INSERT INTO Bookings (BookBoat1, BookRoute1, BookSched1, BookSeat1, BookPrice1) " +
                                   "VALUES (@BookBoat, @BookRoute, @BookSched, @BookSeat, @BookPrice)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@BookBoat", BookBoat.Text);
                        cmd.Parameters.AddWithValue("@BookRoute", BookRoute.Text);
                        cmd.Parameters.AddWithValue("@BookSched", BookSched.Text);
                        cmd.Parameters.AddWithValue("@BookSeat", seatCount);
                        cmd.Parameters.AddWithValue("@BookPrice", totalPrice);

                        // Execute the query
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Booking saved successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            Payment pay = new Payment();
            pay.Show();
            this.Hide();
        }

        private void BookSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BookSearch.Text))
            {
                populateBookDGV(); // Reload all data if the search box is empty
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
                        sda.SelectCommand.Parameters.AddWithValue("@SearchTerm", "%" + BookSearch.Text + "%");
                        DataSet ds = new DataSet();
                        sda.Fill(ds);

                        // Bind the filtered data to the BookDGV DataGridView
                        BookDGV.DataSource = ds.Tables[0];
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while searching: " + ex.Message);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BookSett_Click(object sender, EventArgs e)
        {
            UserDashboard userDashboard = new UserDashboard();
            userDashboard.Show();
            this.Hide();
        }

        private void BookLogOut_Click(object sender, EventArgs e)
        {
            LoginPg loginForm = new LoginPg();

            // Show the LoginPg form
            loginForm.Show();

            // Hide the current AdminDashboard form
            this.Hide();
        }
        private void BookDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row is clicked
            {
                DataGridViewRow row = BookDGV.Rows[e.RowIndex];

                // Fill the textboxes with the selected row's data
                BookBoat.Text = row.Cells["BName"].Value?.ToString();
                BookRoute.Text = row.Cells["BRoute"].Value?.ToString();
                BookSched.Text = row.Cells["BSchedule"].Value?.ToString();
                BookPrice.Text = row.Cells["BPrice"].Value?.ToString();
            }
        }

        private void BookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row is clicked
            {
                DataGridViewRow row = BookDGV.Rows[e.RowIndex];

                // Fill the textboxes with the selected row's data
                BookBoat.Text = row.Cells["BName"].Value?.ToString();
                BookRoute.Text = row.Cells["BRoute"].Value?.ToString();
                BookSched.Text = row.Cells["BSchedule"].Value?.ToString();
                BookPrice.Text = row.Cells["BPriceT"].Value?.ToString();
            }
        }
    }
}
