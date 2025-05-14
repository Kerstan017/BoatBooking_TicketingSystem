namespace BoatBooking_TicketingSystem
{
    partial class Guest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guest));
            panel2 = new Panel();
            GPrice = new TextBox();
            label1 = new Label();
            GSched = new ComboBox();
            GRoute = new ComboBox();
            GuestDGV = new DataGridView();
            label8 = new Label();
            label7 = new Label();
            GSeat = new TextBox();
            label3 = new Label();
            panel6 = new Panel();
            GSearch = new TextBox();
            label2 = new Label();
            pictureBox5 = new PictureBox();
            GPay = new Button();
            GBoat = new TextBox();
            label6 = new Label();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            Gback = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GuestDGV).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(Gback);
            panel2.Controls.Add(GPrice);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(GSched);
            panel2.Controls.Add(GRoute);
            panel2.Controls.Add(GuestDGV);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(GSeat);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(GPay);
            panel2.Controls.Add(GBoat);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(779, 624);
            panel2.TabIndex = 4;
            // 
            // GPrice
            // 
            GPrice.Location = new Point(287, 337);
            GPrice.Name = "GPrice";
            GPrice.Size = new Size(164, 27);
            GPrice.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(291, 304);
            label1.Name = "label1";
            label1.Size = new Size(115, 23);
            label1.TabIndex = 25;
            label1.Text = "Seat Price";
            // 
            // GSched
            // 
            GSched.FormattingEnabled = true;
            GSched.Items.AddRange(new object[] { "6:00  AM - 6:30 AM", "7:30 AM - 8:00 AM", "11:30 AM - 12:00 PM", "12:30 PM - 1:00 PM", "5:30 PM - 6:00 PM", "7:30 PM - 8:00PM" });
            GSched.Location = new Point(287, 232);
            GSched.Name = "GSched";
            GSched.Size = new Size(198, 28);
            GSched.TabIndex = 24;
            // 
            // GRoute
            // 
            GRoute.FormattingEnabled = true;
            GRoute.Items.AddRange(new object[] { "Lapu-lapu Ferry Boat Dock - Pier 1", "Lapu-lapu Ferry Boat Dock - Pier 2", "Lapu-lapu Ferry Boat Dock - Pier 3", "Passenger Terminal 1 (Pier 1) - Ferry Boat", "Passenger Terminal 1 (Pier 1) - Pier 2", "Passenger Terminal 1 (Pier 1) - Pier 3", "Passenger Terminal 2 (Pier 2) - Pier 1", "Passenger Terminal 2 (Pier 2) - Pier 3", "Passenger Terminal 2 (Pier 2) - Ferry Boat", "Passenger Terminal 3 (Pier 3) - Pier 1", "Passenger Terminal 3 (Pier 3) - Pier 2", "Passenger Terminal 3 (Pier 3) - Ferry Boat" });
            GRoute.Location = new Point(39, 232);
            GRoute.Name = "GRoute";
            GRoute.Size = new Size(198, 28);
            GRoute.TabIndex = 23;
            // 
            // GuestDGV
            // 
            GuestDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GuestDGV.Location = new Point(39, 385);
            GuestDGV.Name = "GuestDGV";
            GuestDGV.RowHeadersWidth = 51;
            GuestDGV.Size = new Size(689, 148);
            GuestDGV.TabIndex = 22;
            GuestDGV.CellContentClick += GuestDGV_CellClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(39, 201);
            label8.Name = "label8";
            label8.Size = new Size(69, 23);
            label8.TabIndex = 20;
            label8.Text = "Route";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(287, 201);
            label7.Name = "label7";
            label7.Size = new Size(101, 23);
            label7.TabIndex = 18;
            label7.Text = "Schedule";
            // 
            // GSeat
            // 
            GSeat.Location = new Point(552, 232);
            GSeat.Name = "GSeat";
            GSeat.Size = new Size(164, 27);
            GSeat.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(552, 201);
            label3.Name = "label3";
            label3.Size = new Size(134, 23);
            label3.TabIndex = 16;
            label3.Text = "No. of Seats";
            // 
            // panel6
            // 
            panel6.Controls.Add(GSearch);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(pictureBox5);
            panel6.Location = new Point(233, 88);
            panel6.Name = "panel6";
            panel6.Size = new Size(406, 54);
            panel6.TabIndex = 15;
            // 
            // GSearch
            // 
            GSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GSearch.Location = new Point(168, 6);
            GSearch.Name = "GSearch";
            GSearch.Size = new Size(232, 38);
            GSearch.TabIndex = 2;
            GSearch.TextChanged += GSearch_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(70, 15);
            label2.Name = "label2";
            label2.Size = new Size(92, 23);
            label2.TabIndex = 1;
            label2.Text = "Search...";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(64, 54);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // GPay
            // 
            GPay.BackColor = Color.FromArgb(128, 128, 255);
            GPay.FlatStyle = FlatStyle.Flat;
            GPay.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GPay.Location = new Point(568, 578);
            GPay.Name = "GPay";
            GPay.Size = new Size(193, 30);
            GPay.TabIndex = 14;
            GPay.Text = "Proceed to Payment";
            GPay.UseVisualStyleBackColor = false;
            GPay.Click += GPay_Click;
            // 
            // GBoat
            // 
            GBoat.Location = new Point(39, 335);
            GBoat.Name = "GBoat";
            GBoat.Size = new Size(164, 27);
            GBoat.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(39, 304);
            label6.Name = "label6";
            label6.Size = new Size(57, 23);
            label6.TabIndex = 3;
            label6.Text = "Boat";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(152, 90);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(761, 0);
            label5.Name = "label5";
            label5.Size = new Size(19, 20);
            label5.TabIndex = 1;
            label5.Text = "X";
            label5.Click += label5_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(291, 14);
            label4.Name = "label4";
            label4.Size = new Size(265, 35);
            label4.TabIndex = 0;
            label4.Text = "Buy Tickets Now";
            label4.Click += label4_Click;
            // 
            // Gback
            // 
            Gback.BackColor = Color.IndianRed;
            Gback.FlatStyle = FlatStyle.Flat;
            Gback.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Gback.Location = new Point(3, 578);
            Gback.Name = "Gback";
            Gback.Size = new Size(105, 30);
            Gback.TabIndex = 27;
            Gback.Text = "Go Back";
            Gback.UseVisualStyleBackColor = false;
            Gback.Click += Gback_Click;
            // 
            // Guest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(803, 648);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Guest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Guest";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GuestDGV).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TextBox GPrice;
        private Label label1;
        private ComboBox GSched;
        private ComboBox GRoute;
        private DataGridView GuestDGV;
        private Label label8;
        private Label label7;
        private TextBox GSeat;
        private Label label3;
        private Panel panel6;
        private TextBox GSearch;
        private Label label2;
        private PictureBox pictureBox5;
        private Button GPay;
        private TextBox GBoat;
        private Label label6;
        private PictureBox pictureBox4;
        private Label label5;
        private Label label4;
        private Button Gback;
    }
}