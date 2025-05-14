namespace BoatBooking_TicketingSystem
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            panel2 = new Panel();
            BookDGV = new DataGridView();
            GenReceipt = new Button();
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
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BookDGV).BeginInit();
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
            panel2.Controls.Add(BookDGV);
            panel2.Controls.Add(GenReceipt);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(242, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(779, 624);
            panel2.TabIndex = 5;
            // 
            // BookDGV
            // 
            BookDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookDGV.Location = new Point(25, 180);
            BookDGV.Name = "BookDGV";
            BookDGV.RowHeadersWidth = 51;
            BookDGV.Size = new Size(730, 148);
            BookDGV.TabIndex = 22;
            BookDGV.CellContentClick += BookDGV_CellContentClick;
            // 
            // GenReceipt
            // 
            GenReceipt.BackColor = Color.FromArgb(128, 128, 255);
            GenReceipt.FlatStyle = FlatStyle.Flat;
            GenReceipt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GenReceipt.Location = new Point(278, 395);
            GenReceipt.Name = "GenReceipt";
            GenReceipt.Size = new Size(193, 30);
            GenReceipt.TabIndex = 14;
            GenReceipt.Text = "Generate Receipt";
            GenReceipt.UseVisualStyleBackColor = false;
            GenReceipt.Click += BookPay_Click;
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
            label4.Size = new Size(266, 35);
            label4.TabIndex = 0;
            label4.Text = "Payment Receipt";
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
            panel1.TabIndex = 4;
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
            // printDocument1
            // 
            printDocument1.DocumentName = "Receipt";
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            printPreviewDialog1.Load += printPreviewDialog1_Load;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(1030, 649);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Payment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BookDGV).EndInit();
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
        private DataGridView BookDGV;
        private Button GenReceipt;
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
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}