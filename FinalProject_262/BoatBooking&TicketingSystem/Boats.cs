using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BoatBooking_TicketingSystem
{
    public partial class Boats : Form
    {
        public Boats()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\KLAIRE DAVIDE\Documents\BoatBTSystemDb.mdf"";Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select * from BoatTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BoatDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void BSave_Click(object sender, EventArgs e)
        {
            if (BoatName.Text == "" || BoatRoute.SelectedIndex == -1 || BoatSeat.Text == "" || BoatSched.SelectedIndex == -1 || BoatPrice.Text == "")
            {
                MessageBox.Show("Please fill in all fields");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into BoatTbl values(' " + BoatName.Text + "', '" + BoatRoute.SelectedItem.ToString() + "', " + BoatSeat.Text + ", '" + BoatSched.SelectedItem.ToString() + "', " + BoatPrice.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Boat Added Successfully");
                    Con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Con.Close();
                }
            }
        }

        private void BSearchBr_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BSearchBr.Text))
            {
                populate(); // Reload all data if the search box is empty
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "select * from BoatTbl where BName like @SearchTerm or BRoute like @SearchTerm";
                    SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                    sda.SelectCommand.Parameters.AddWithValue("@SearchTerm", "%" + BSearchBr.Text + "%");
                    var ds = new DataSet();
                    sda.Fill(ds);
                    BoatDGV.DataSource = ds.Tables[0];
                    Con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Con.Close();
                }
            }
        }

        private void BRefresh_Click(object sender, EventArgs e)
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

        private void BDelete_Click(object sender, EventArgs e)
        {
            if (BoatDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            try
            {
                // Get the ID of the selected row
                int selectedRowIndex = BoatDGV.SelectedRows[0].Index;
                string boatId = BoatDGV.Rows[selectedRowIndex].Cells[0].Value.ToString();

                // Confirm deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Con.Open();
                    string query = "DELETE FROM BoatTbl WHERE BId = @BId";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@BId", boatId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Boat deleted successfully.");
                    Con.Close();

                    // Refresh the data grid view
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the record: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void BClear_Click(object sender, EventArgs e)
        {
            // Clear all textboxes
            BoatName.Text = string.Empty;
            BoatSeat.Text = string.Empty;
            BoatPrice.Text = string.Empty;

            // Reset combo boxes
            BoatRoute.SelectedIndex = -1;
            BoatSched.SelectedIndex = -1;

            MessageBox.Show("Fields cleared successfully.");
        }

        private void BEdit_Click(object sender, EventArgs e)
        {
            if (BoatDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to edit.");
                return;
            }

            if (BoatName.Text == "" || BoatRoute.SelectedIndex == -1 || BoatSeat.Text == "" || BoatSched.SelectedIndex == -1 || BoatPrice.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                // Get the ID of the selected row
                int selectedRowIndex = BoatDGV.SelectedRows[0].Index;
                string boatId = BoatDGV.Rows[selectedRowIndex].Cells[0].Value.ToString();

                // Update the database
                Con.Open();
                string query = "UPDATE BoatTbl SET BName = @BoatName, BRoute = @BoatRoute, BSeatCap = @BoatSeat, BSchedule = @BoatSched, BPriceT = @BoatPrice WHERE BId = @BId";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@BoatName", BoatName.Text);
                cmd.Parameters.AddWithValue("@BoatRoute", BoatRoute.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@BoatSeat", BoatSeat.Text);
                cmd.Parameters.AddWithValue("@BoatSched", BoatSched.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@BoatPrice", BoatPrice.Text);
                cmd.Parameters.AddWithValue("@BId", boatId);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Boat updated successfully.");
                Con.Close();

                // Refresh the data grid view
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the record: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
        int key = 0;
        private void BoatDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row is clicked
            {
                DataGridViewRow row = BoatDGV.Rows[e.RowIndex];

                // Fill the textboxes and combo boxes with the selected row's data
                BoatName.Text = row.Cells[1].Value?.ToString();
                BoatRoute.SelectedItem = row.Cells[2].Value?.ToString();
                BoatSeat.Text = row.Cells[3].Value?.ToString();
                BoatSched.SelectedItem = row.Cells[4].Value?.ToString();
                BoatPrice.Text = row.Cells[5].Value?.ToString();

                // Set the key for the selected row
                key = row.Cells[0].Value != null ? Convert.ToInt32(row.Cells[0].Value) : 0;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UserLb_Click(object sender, EventArgs e)
        {
            AdminDashboard admin = new AdminDashboard();
            admin.Show();
            this.Hide();
        }

        private void AnalyticsLb_Click(object sender, EventArgs e)
        {
            Analytics analytics = new Analytics();
            analytics.Show();
            this.Hide();
        }

        private void LogoutLb_Click(object sender, EventArgs e)
        {
            LoginPg loginForm = new LoginPg();

            // Show the LoginPg form
            loginForm.Show();

            // Hide the current AdminDashboard form
            this.Hide();
        }
    }
}
