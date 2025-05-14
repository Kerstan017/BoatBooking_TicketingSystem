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
using Xceed.Words.NET;


namespace BoatBooking_TicketingSystem
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
            populateBookDGV();
        }

        private void BookSett_Click(object sender, EventArgs e)
        {
            UserDashboard userDashboard = new UserDashboard();
            userDashboard.Show();
            this.Hide();
        }

        private void BookLogOut_Click(object sender, EventArgs e)
        {
            LoginPg loginPg = new LoginPg();
            loginPg.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BookPay_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("A4", 827, 1169);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                // Connection string to the database
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\KLAIRE DAVIDE\Documents\BoatBTSystemDb.mdf"";Integrated Security=True;Connect Timeout=30";

                // Query the Bookings table to get the latest transaction
                string query = "SELECT TOP 1 * FROM Bookings ORDER BY BookId DESC"; // Assuming BookingId is the primary key

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Retrieve data from the Bookings table
                                string boatName = reader["BookBoat1"].ToString();
                                string route = reader["BookRoute1"].ToString();
                                string schedule = reader["BookSched1"].ToString();
                                string seats = reader["BookSeat1"].ToString();
                                string totalPrice = reader["BookPrice1"].ToString();

                                // File path for the receipt
                                string filePath = @"D:\2vs\FinalProject_262\receipt\Receipt.docx";

                                // Create a new document
                                using (var document = Xceed.Words.NET.DocX.Create(filePath))
                                {
                                    // Add a title
                                    document.InsertParagraph("Boat Booking Receipt")
                                            .FontSize(24)
                                            .Bold()
                                            .Alignment = Xceed.Document.NET.Alignment.center;

                                    // Add a line break
                                    document.InsertParagraph(Environment.NewLine);

                                    // Add booking details
                                    document.InsertParagraph("Booking Details:")
                                            .FontSize(14)
                                            .Bold();

                                    document.InsertParagraph($"Boat Name: {boatName}")
                                            .FontSize(14);
                                    document.InsertParagraph($"Route: {route}")
                                            .FontSize(14);
                                    document.InsertParagraph($"Schedule: {schedule}")
                                            .FontSize(14);
                                    document.InsertParagraph($"Seats: {seats}")
                                            .FontSize(14);
                                    document.InsertParagraph($"Total Price: {totalPrice}")
                                            .FontSize(14);

                                    // Add a footer
                                    document.InsertParagraph(Environment.NewLine);
                                    document.InsertParagraph("Thank you for booking with us!")
                                            .FontSize(16)
                                            .Italic()
                                            .Bold()
                                            .Alignment = Xceed.Document.NET.Alignment.center;

                                    // Save the document
                                    document.Save();
                                }

                                // Notify the user
                                MessageBox.Show($"Receipt has been generated successfully at {filePath}");
                            }
                            else
                            {
                                MessageBox.Show("No booking data found for the receipt.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while generating the receipt: {ex.Message}");
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void BookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row is clicked
            {
                DataGridViewRow row = BookDGV.Rows[e.RowIndex];

                // Retrieve data from the selected row
                string boatName = row.Cells["BName"].Value?.ToString();
                string route = row.Cells["BRoute"].Value?.ToString();
                string schedule = row.Cells["BSchedule"].Value?.ToString();
                string seats = row.Cells["BSeat"].Value?.ToString();
                string price = row.Cells["BPrice"].Value?.ToString();

                // Display the content in a MessageBox
                string message = $"Boat Name: {boatName}\n" +
                                 $"Route: {route}\n" +
                                 $"Schedule: {schedule}\n" +
                                 $"Seats: {seats}\n" +
                                 $"Price: {price}\n\n" +
                                 "This is the content that will be printed.";
                MessageBox.Show(message, "Print Preview", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
    }
}
