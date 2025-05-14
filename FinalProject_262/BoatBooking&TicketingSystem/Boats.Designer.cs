namespace BoatBooking_TicketingSystem
{
    partial class Boats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Boats));
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            BoatSeat = new TextBox();
            BoatName = new TextBox();
            BDelete = new Button();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            BRefresh = new Button();
            BEdit = new Button();
            BSave = new Button();
            BoatDGV = new DataGridView();
            panel7 = new Panel();
            BSearchBr = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            UserLb = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            panel5 = new Panel();
            LogoutLb = new Label();
            pictureBox5 = new PictureBox();
            panel4 = new Panel();
            AnalyticsLb = new Label();
            pictureBox4 = new PictureBox();
            panel3 = new Panel();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel6 = new Panel();
            BClear = new Button();
            BoatPrice = new TextBox();
            label12 = new Label();
            BoatSched = new ComboBox();
            BoatRoute = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BoatDGV).BeginInit();
            panel7.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(0, 10);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(103, 29);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 3;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(3, 3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(206, 57);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 17;
            pictureBox7.TabStop = false;
            // 
            // BoatSeat
            // 
            BoatSeat.Location = new Point(249, 100);
            BoatSeat.Name = "BoatSeat";
            BoatSeat.Size = new Size(164, 27);
            BoatSeat.TabIndex = 15;
            // 
            // BoatName
            // 
            BoatName.Location = new Point(26, 99);
            BoatName.Name = "BoatName";
            BoatName.Size = new Size(164, 27);
            BoatName.TabIndex = 13;
            // 
            // BDelete
            // 
            BDelete.BackColor = Color.FromArgb(192, 192, 255);
            BDelete.FlatStyle = FlatStyle.Flat;
            BDelete.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BDelete.Location = new Point(782, 178);
            BDelete.Name = "BDelete";
            BDelete.Size = new Size(94, 29);
            BDelete.TabIndex = 12;
            BDelete.Text = "Delete";
            BDelete.UseVisualStyleBackColor = false;
            BDelete.Click += BDelete_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(489, 74);
            label11.Name = "label11";
            label11.Size = new Size(90, 21);
            label11.TabIndex = 11;
            label11.Text = "Schedule";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(249, 74);
            label10.Name = "label10";
            label10.Size = new Size(133, 21);
            label10.TabIndex = 10;
            label10.Text = "Seat Capacity";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(26, 153);
            label9.Name = "label9";
            label9.Size = new Size(62, 21);
            label9.TabIndex = 9;
            label9.Text = "Route";
            // 
            // BRefresh
            // 
            BRefresh.BackColor = Color.FromArgb(192, 192, 255);
            BRefresh.FlatStyle = FlatStyle.Flat;
            BRefresh.Font = new Font("Century", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            BRefresh.Location = new Point(882, 178);
            BRefresh.Name = "BRefresh";
            BRefresh.Size = new Size(94, 29);
            BRefresh.TabIndex = 7;
            BRefresh.Text = "Refresh";
            BRefresh.UseVisualStyleBackColor = false;
            BRefresh.Click += BRefresh_Click;
            // 
            // BEdit
            // 
            BEdit.BackColor = Color.FromArgb(192, 192, 255);
            BEdit.FlatStyle = FlatStyle.Flat;
            BEdit.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BEdit.Location = new Point(582, 179);
            BEdit.Name = "BEdit";
            BEdit.Size = new Size(94, 29);
            BEdit.TabIndex = 6;
            BEdit.Text = "Edit";
            BEdit.UseVisualStyleBackColor = false;
            BEdit.Click += BEdit_Click;
            // 
            // BSave
            // 
            BSave.BackColor = Color.FromArgb(192, 192, 255);
            BSave.FlatStyle = FlatStyle.Flat;
            BSave.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BSave.Location = new Point(682, 179);
            BSave.Name = "BSave";
            BSave.Size = new Size(94, 29);
            BSave.TabIndex = 5;
            BSave.Text = "Save";
            BSave.UseVisualStyleBackColor = false;
            BSave.Click += BSave_Click;
            // 
            // BoatDGV
            // 
            BoatDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BoatDGV.GridColor = Color.DeepSkyBlue;
            BoatDGV.Location = new Point(6, 238);
            BoatDGV.Name = "BoatDGV";
            BoatDGV.RowHeadersWidth = 51;
            BoatDGV.Size = new Size(970, 387);
            BoatDGV.TabIndex = 4;
            BoatDGV.CellContentClick += BoatDGV_CellClick;
            // 
            // panel7
            // 
            panel7.Controls.Add(pictureBox6);
            panel7.Controls.Add(BSearchBr);
            panel7.Controls.Add(label7);
            panel7.Location = new Point(216, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(498, 49);
            panel7.TabIndex = 3;
            // 
            // BSearchBr
            // 
            BSearchBr.Location = new Point(172, 13);
            BSearchBr.Name = "BSearchBr";
            BSearchBr.Size = new Size(311, 27);
            BSearchBr.TabIndex = 1;
            BSearchBr.TextChanged += BSearchBr_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(109, 14);
            label7.Name = "label7";
            label7.Size = new Size(57, 19);
            label7.TabIndex = 2;
            label7.Text = "Search";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(26, 74);
            label8.Name = "label8";
            label8.Size = new Size(108, 21);
            label8.TabIndex = 8;
            label8.Text = "Boat Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(956, 0);
            label6.Name = "label6";
            label6.Size = new Size(23, 23);
            label6.TabIndex = 0;
            label6.Text = "X";
            label6.Click += label6_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(UserLb);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(3, 174);
            panel2.Name = "panel2";
            panel2.Size = new Size(215, 47);
            panel2.TabIndex = 2;
            // 
            // UserLb
            // 
            UserLb.AutoSize = true;
            UserLb.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserLb.Location = new Point(89, 7);
            UserLb.Name = "UserLb";
            UserLb.Size = new Size(80, 32);
            UserLb.TabIndex = 1;
            UserLb.Text = "Users";
            UserLb.Click += UserLb_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(11, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(227, 634);
            panel1.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.SteelBlue;
            panel5.Controls.Add(LogoutLb);
            panel5.Controls.Add(pictureBox5);
            panel5.Location = new Point(6, 416);
            panel5.Name = "panel5";
            panel5.Size = new Size(215, 42);
            panel5.TabIndex = 5;
            // 
            // LogoutLb
            // 
            LogoutLb.AutoSize = true;
            LogoutLb.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoutLb.Location = new Point(82, 5);
            LogoutLb.Name = "LogoutLb";
            LogoutLb.Size = new Size(100, 32);
            LogoutLb.TabIndex = 1;
            LogoutLb.Text = "Logout";
            LogoutLb.Click += LogoutLb_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(3, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(60, 36);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SteelBlue;
            panel4.Controls.Add(AnalyticsLb);
            panel4.Controls.Add(pictureBox4);
            panel4.Location = new Point(5, 288);
            panel4.Name = "panel4";
            panel4.Size = new Size(215, 47);
            panel4.TabIndex = 4;
            // 
            // AnalyticsLb
            // 
            AnalyticsLb.AutoSize = true;
            AnalyticsLb.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AnalyticsLb.Location = new Point(74, 8);
            AnalyticsLb.Name = "AnalyticsLb";
            AnalyticsLb.Size = new Size(126, 32);
            AnalyticsLb.TabIndex = 1;
            AnalyticsLb.Text = "Analytics";
            AnalyticsLb.Click += AnalyticsLb_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(60, 42);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Cyan;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(3, 231);
            panel3.Name = "panel3";
            panel3.Size = new Size(215, 47);
            panel3.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(89, 7);
            label3.Name = "label3";
            label3.Size = new Size(82, 32);
            label3.TabIndex = 1;
            label3.Text = "Boats";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(60, 42);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SteelBlue;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 255, 128);
            label1.Location = new Point(-3, 63);
            label1.Name = "label1";
            label1.Size = new Size(236, 32);
            label1.TabIndex = 1;
            label1.Text = "Admin Dashboard";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(BClear);
            panel6.Controls.Add(BoatPrice);
            panel6.Controls.Add(label12);
            panel6.Controls.Add(BoatSched);
            panel6.Controls.Add(BoatRoute);
            panel6.Controls.Add(pictureBox7);
            panel6.Controls.Add(BoatSeat);
            panel6.Controls.Add(BoatName);
            panel6.Controls.Add(BDelete);
            panel6.Controls.Add(label11);
            panel6.Controls.Add(label10);
            panel6.Controls.Add(label9);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(BRefresh);
            panel6.Controls.Add(BEdit);
            panel6.Controls.Add(BSave);
            panel6.Controls.Add(BoatDGV);
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(238, 12);
            panel6.Name = "panel6";
            panel6.Size = new Size(979, 634);
            panel6.TabIndex = 3;
            // 
            // BClear
            // 
            BClear.BackColor = Color.FromArgb(192, 192, 255);
            BClear.FlatStyle = FlatStyle.Flat;
            BClear.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BClear.Location = new Point(482, 179);
            BClear.Name = "BClear";
            BClear.Size = new Size(94, 29);
            BClear.TabIndex = 22;
            BClear.Text = "Clear";
            BClear.UseVisualStyleBackColor = false;
            BClear.Click += BClear_Click;
            // 
            // BoatPrice
            // 
            BoatPrice.Location = new Point(772, 98);
            BoatPrice.Name = "BoatPrice";
            BoatPrice.Size = new Size(150, 27);
            BoatPrice.TabIndex = 21;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(769, 74);
            label12.Name = "label12";
            label12.Size = new Size(170, 21);
            label12.TabIndex = 20;
            label12.Text = "Price per 1 Ticket";
            // 
            // BoatSched
            // 
            BoatSched.FormattingEnabled = true;
            BoatSched.Items.AddRange(new object[] { "6:00  AM - 6:30 AM", "7:30 AM - 8:00 AM", "11:30 AM - 12:00 PM", "12:30 PM - 1:00 PM", "5:30 PM - 6:00 PM", "7:30 PM - 8:00PM" });
            BoatSched.Location = new Point(489, 98);
            BoatSched.Name = "BoatSched";
            BoatSched.Size = new Size(228, 28);
            BoatSched.TabIndex = 19;
            // 
            // BoatRoute
            // 
            BoatRoute.FormattingEnabled = true;
            BoatRoute.Items.AddRange(new object[] { "Lapu-lapu Ferry Boat Dock - Pier 1", "Lapu-lapu Ferry Boat Dock - Pier 2", "Lapu-lapu Ferry Boat Dock - Pier 3", "Passenger Terminal 1 (Pier 1) - Ferry Boat", "Passenger Terminal 1 (Pier 1) - Pier 2", "Passenger Terminal 1 (Pier 1) - Pier 3", "Passenger Terminal 2 (Pier 2) - Pier 1", "Passenger Terminal 2 (Pier 2) - Pier 3", "Passenger Terminal 2 (Pier 2) - Ferry Boat", "Passenger Terminal 3 (Pier 3) - Pier 1", "Passenger Terminal 3 (Pier 3) - Pier 2", "Passenger Terminal 3 (Pier 3) - Ferry Boat" });
            BoatRoute.Location = new Point(26, 179);
            BoatRoute.Name = "BoatRoute";
            BoatRoute.Size = new Size(364, 28);
            BoatRoute.TabIndex = 18;
            // 
            // Boats
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(1229, 658);
            Controls.Add(panel1);
            Controls.Add(panel6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Boats";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Boats";
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)BoatDGV).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private TextBox BoatSeat;
        private TextBox BoatName;
        private Button BDelete;
        private Label label11;
        private Label label10;
        private Label label9;
        private Button BRefresh;
        private Button BEdit;
        private Button BSave;
        private DataGridView BoatDGV;
        private Panel panel7;
        private TextBox BSearchBr;
        private Label label7;
        private Label label8;
        private Label label6;
        private Panel panel2;
        private Label UserLb;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel5;
        private Label LogoutLb;
        private PictureBox pictureBox5;
        private Panel panel4;
        private Label AnalyticsLb;
        private PictureBox pictureBox4;
        private Panel panel3;
        private Label label3;
        private PictureBox pictureBox3;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel6;
        private ComboBox BoatRoute;
        private ComboBox BoatSched;
        private TextBox BoatPrice;
        private Label label12;
        private Button BClear;
    }
}