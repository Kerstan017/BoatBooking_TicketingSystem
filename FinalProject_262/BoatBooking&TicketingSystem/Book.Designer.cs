namespace BoatBooking_TicketingSystem
{
    partial class Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book));
            panel2 = new Panel();
            BookPrice = new TextBox();
            label1 = new Label();
            BookSched = new ComboBox();
            BookRoute = new ComboBox();
            BookDGV = new DataGridView();
            label8 = new Label();
            label7 = new Label();
            BookSeat = new TextBox();
            label3 = new Label();
            panel6 = new Panel();
            BookSearch = new TextBox();
            label2 = new Label();
            pictureBox5 = new PictureBox();
            BookPay = new Button();
            BookBoat = new TextBox();
            label6 = new Label();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            panel5 = new Panel();
            BookLogOut = new Label();
            pictureBox3 = new PictureBox();
            panel4 = new Panel();
            BookLb3 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            BookSett = new Label();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BookDGV).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(BookPrice);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(BookSched);
            panel2.Controls.Add(BookRoute);
            panel2.Controls.Add(BookDGV);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(BookSeat);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(BookPay);
            panel2.Controls.Add(BookBoat);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(242, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(779, 624);
            panel2.TabIndex = 3;
            // 
            // BookPrice
            // 
            BookPrice.Location = new Point(287, 337);
            BookPrice.Name = "BookPrice";
            BookPrice.Size = new Size(164, 27);
            BookPrice.TabIndex = 26;
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
            // BookSched
            // 
            BookSched.FormattingEnabled = true;
            BookSched.Items.AddRange(new object[] { "6:00  AM - 6:30 AM", "7:30 AM - 8:00 AM", "11:30 AM - 12:00 PM", "12:30 PM - 1:00 PM", "5:30 PM - 6:00 PM", "7:30 PM - 8:00PM" });
            BookSched.Location = new Point(287, 232);
            BookSched.Name = "BookSched";
            BookSched.Size = new Size(198, 28);
            BookSched.TabIndex = 24;
            // 
            // BookRoute
            // 
            BookRoute.FormattingEnabled = true;
            BookRoute.Items.AddRange(new object[] { "Lapu-lapu Ferry Boat Dock - Pier 1", "Lapu-lapu Ferry Boat Dock - Pier 2", "Lapu-lapu Ferry Boat Dock - Pier 3", "Passenger Terminal 1 (Pier 1) - Ferry Boat", "Passenger Terminal 1 (Pier 1) - Pier 2", "Passenger Terminal 1 (Pier 1) - Pier 3", "Passenger Terminal 2 (Pier 2) - Pier 1", "Passenger Terminal 2 (Pier 2) - Pier 3", "Passenger Terminal 2 (Pier 2) - Ferry Boat", "Passenger Terminal 3 (Pier 3) - Pier 1", "Passenger Terminal 3 (Pier 3) - Pier 2", "Passenger Terminal 3 (Pier 3) - Ferry Boat" });
            BookRoute.Location = new Point(39, 232);
            BookRoute.Name = "BookRoute";
            BookRoute.Size = new Size(198, 28);
            BookRoute.TabIndex = 23;
            // 
            // BookDGV
            // 
            BookDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookDGV.Location = new Point(39, 385);
            BookDGV.Name = "BookDGV";
            BookDGV.RowHeadersWidth = 51;
            BookDGV.Size = new Size(689, 148);
            BookDGV.TabIndex = 22;
            BookDGV.CellContentClick += BookDGV_CellContentClick;
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
            // BookSeat
            // 
            BookSeat.Location = new Point(552, 232);
            BookSeat.Name = "BookSeat";
            BookSeat.Size = new Size(164, 27);
            BookSeat.TabIndex = 17;
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
            panel6.Controls.Add(BookSearch);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(pictureBox5);
            panel6.Location = new Point(233, 88);
            panel6.Name = "panel6";
            panel6.Size = new Size(406, 54);
            panel6.TabIndex = 15;
            // 
            // BookSearch
            // 
            BookSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BookSearch.Location = new Point(168, 6);
            BookSearch.Name = "BookSearch";
            BookSearch.Size = new Size(232, 38);
            BookSearch.TabIndex = 2;
            BookSearch.TextChanged += BookSearch_TextChanged;
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
            // BookPay
            // 
            BookPay.BackColor = Color.FromArgb(128, 128, 255);
            BookPay.FlatStyle = FlatStyle.Flat;
            BookPay.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BookPay.Location = new Point(568, 578);
            BookPay.Name = "BookPay";
            BookPay.Size = new Size(193, 30);
            BookPay.TabIndex = 14;
            BookPay.Text = "Proceed to Payment";
            BookPay.UseVisualStyleBackColor = false;
            BookPay.Click += BookPay_Click;
            // 
            // BookBoat
            // 
            BookBoat.Location = new Point(39, 335);
            BookBoat.Name = "BookBoat";
            BookBoat.Size = new Size(164, 27);
            BookBoat.TabIndex = 7;
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
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(291, 14);
            label4.Name = "label4";
            label4.Size = new Size(280, 35);
            label4.TabIndex = 0;
            label4.Text = "Book Tickets Now";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(232, 624);
            panel1.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Teal;
            panel5.Controls.Add(BookLogOut);
            panel5.Controls.Add(pictureBox3);
            panel5.Location = new Point(0, 324);
            panel5.Name = "panel5";
            panel5.Size = new Size(229, 61);
            panel5.TabIndex = 2;
            // 
            // BookLogOut
            // 
            BookLogOut.AutoSize = true;
            BookLogOut.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BookLogOut.Location = new Point(82, 13);
            BookLogOut.Name = "BookLogOut";
            BookLogOut.Size = new Size(100, 32);
            BookLogOut.TabIndex = 1;
            BookLogOut.Text = "Logout";
            BookLogOut.Click += BookLogOut_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(73, 62);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Lime;
            panel4.Controls.Add(BookLb3);
            panel4.Controls.Add(pictureBox2);
            panel4.Location = new Point(0, 243);
            panel4.Name = "panel4";
            panel4.Size = new Size(229, 61);
            panel4.TabIndex = 1;
            // 
            // BookLb3
            // 
            BookLb3.AutoSize = true;
            BookLb3.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BookLb3.Location = new Point(82, 13);
            BookLb3.Name = "BookLb3";
            BookLb3.Size = new Size(77, 32);
            BookLb3.TabIndex = 1;
            BookLb3.Text = "Book";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(73, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Teal;
            panel3.Controls.Add(BookSett);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(3, 163);
            panel3.Name = "panel3";
            panel3.Size = new Size(229, 61);
            panel3.TabIndex = 0;
            // 
            // BookSett
            // 
            BookSett.AutoSize = true;
            BookSett.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BookSett.Location = new Point(82, 13);
            BookSett.Name = "BookSett";
            BookSett.Size = new Size(109, 32);
            BookSett.TabIndex = 1;
            BookSett.Text = "Settings";
            BookSett.Click += BookSett_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Book
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(1033, 648);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Book";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BookDGV).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button BookPay;
        private TextBox BookBoat;
        private Label label6;
        private PictureBox pictureBox4;
        private Label label5;
        private Label label4;
        private Panel panel1;
        private Panel panel5;
        private Label BookLogOut;
        private PictureBox pictureBox3;
        private Panel panel4;
        private Label BookLb3;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Label BookSett;
        private PictureBox pictureBox1;
        private Label label8;
        private Label label7;
        private TextBox BookSeat;
        private Label label3;
        private Panel panel6;
        private TextBox BookSearch;
        private Label label2;
        private PictureBox pictureBox5;
        private ComboBox BookSched;
        private ComboBox BookRoute;
        private DataGridView BookDGV;
        private TextBox BookPrice;
        private Label label1;
    }
}