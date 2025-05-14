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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            populate();
        }
        private void populate()
        {
            try
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\KLAIRE DAVIDE\Documents\BoatBTSystemDb.mdf"";Integrated Security=True;Connect Timeout=30";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM AdminDashboardTbl";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);

                    // Assuming you have a DataGridView named AuserDGV to display the data
                    AuserDGV.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message);
            }
        }
        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Asave_Click(object sender, EventArgs e)
        {
            // Validate that all textboxes are filled
            if (string.IsNullOrWhiteSpace(Auser.Text) || string.IsNullOrWhiteSpace(Aphone.Text) || string.IsNullOrWhiteSpace(Aadd.Text) || string.IsNullOrWhiteSpace(Apass.Text))
            {
                MessageBox.Show("Please fill in all fields.");
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
                    string query = "INSERT INTO AdminDashboardTbl (UName, UPhone, UAdd, UPass) VALUES (@AdminName, @AdminPhone, @AdminAddress, @AdminPassword)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@AdminName", Auser.Text);
                        cmd.Parameters.AddWithValue("@AdminPhone", Aphone.Text);
                        cmd.Parameters.AddWithValue("@AdminAddress", Aadd.Text);
                        cmd.Parameters.AddWithValue("@AdminPassword", Apass.Text);

                        // Execute the query
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Admin data saved successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void Asearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Asearch.Text))
            {
                populate(); // Reload all data if the search box is empty
            }
            else
            {
                try
                {
                    string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\KLAIRE DAVIDE\Documents\BoatBTSystemDb.mdf"";Integrated Security=True;Connect Timeout=30";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string query = "SELECT * FROM AdminDashboardTbl WHERE UName LIKE @SearchTerm OR UPhone LIKE @SearchTerm OR UAdd LIKE @SearchTerm";
                        SqlDataAdapter sda = new SqlDataAdapter(query, con);
                        sda.SelectCommand.Parameters.AddWithValue("@SearchTerm", "%" + Asearch.Text + "%");
                        DataSet ds = new DataSet();
                        sda.Fill(ds);

                        // Assuming you have a DataGridView named AdminDGV to display the data
                        AuserDGV.DataSource = ds.Tables[0];
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while searching: " + ex.Message);
                }
            }
        }

        private void Adelete_Click(object sender, EventArgs e)
        {
            if (AuserDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            try
            {
                // Get the ID of the selected row
                int selectedRowIndex = AuserDGV.SelectedRows[0].Index;
                string adminId = AuserDGV.Rows[selectedRowIndex].Cells[0].Value.ToString();

                // Confirm deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\KLAIRE DAVIDE\Documents\BoatBTSystemDb.mdf"";Integrated Security=True;Connect Timeout=30";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string query = "DELETE FROM AdminDashboardTbl WHERE UId = @AdminId";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@AdminId", adminId);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Admin record deleted successfully.");
                    }

                    // Refresh the data grid view
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the record: " + ex.Message);
            }
        }

        private void Aedit_Click(object sender, EventArgs e)
        {
            if (AuserDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to edit.");
                return;
            }

            if (string.IsNullOrWhiteSpace(Auser.Text) || string.IsNullOrWhiteSpace(Aphone.Text) || string.IsNullOrWhiteSpace(Aadd.Text) || string.IsNullOrWhiteSpace(Apass.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                // Get the ID of the selected row
                int selectedRowIndex = AuserDGV.SelectedRows[0].Index;
                string adminId = AuserDGV.Rows[selectedRowIndex].Cells[0].Value.ToString();

                // Update the database
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\KLAIRE DAVIDE\Documents\BoatBTSystemDb.mdf"";Integrated Security=True;Connect Timeout=30";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "UPDATE AdminDashboardTbl SET UName = @AdminName, UPhone = @AdminPhone, UAdd = @AdminAddress, UPass = @AdminPassword WHERE UId = @UId";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@AdminName", Auser.Text);
                        cmd.Parameters.AddWithValue("@AdminPhone", Aphone.Text);
                        cmd.Parameters.AddWithValue("@AdminAddress", Aadd.Text);
                        cmd.Parameters.AddWithValue("@AdminPassword", Apass.Text);
                        cmd.Parameters.AddWithValue("@UId", adminId);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Admin record updated successfully.");
                    }
                }

                // Refresh the data grid view
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the record: " + ex.Message);
            }
        }

        private void Arefresh_Click(object sender, EventArgs e)
        {
            try
            {
                populate(); // Reload the data from the database
                MessageBox.Show("Data refreshed successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while refreshing the data: " + ex.Message);
            }
        }

        private void AuserDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row is clicked
            {
                DataGridViewRow row = AuserDGV.Rows[e.RowIndex];

                // Fill the textboxes with the selected row's data
                Auser.Text = row.Cells[1].Value?.ToString();
                Aphone.Text = row.Cells[2].Value?.ToString();
                Aadd.Text = row.Cells[3].Value?.ToString();
                Apass.Text = row.Cells[4].Value?.ToString();
            }
        }

        private void Aclear_Click(object sender, EventArgs e)
        {
            // Clear all textboxes
            Auser.Text = string.Empty;
            Aphone.Text = string.Empty;
            Aadd.Text = string.Empty;
            Apass.Text = string.Empty;

            MessageBox.Show("Fields cleared successfully.");
        }

        private void BoatLb2_Click(object sender, EventArgs e)
        {
            // Create an instance of the Boats form
            Boats boatsForm = new Boats();

            // Show the Boats form
            boatsForm.Show();

            // Optionally hide the current AdminDashboard form
            this.Hide();
        }

        private void AnalyticLb2_Click(object sender, EventArgs e)
        {
            Analytics analytics = new Analytics();
            analytics.Show();
            this.Hide();
        }

        private void LogoutLb2_Click(object sender, EventArgs e)
        {
            LoginPg loginForm = new LoginPg();

            // Show the LoginPg form
            loginForm.Show();

            // Hide the current AdminDashboard form
            this.Hide();
        }
    }
}
