namespace BoatBooking_TicketingSystem
{
    partial class LoadingPg
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingPg));
            LoadBar = new ProgressBar();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            PercentBr = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LoadBar
            // 
            LoadBar.Location = new Point(0, 345);
            LoadBar.Name = "LoadBar";
            LoadBar.Size = new Size(612, 20);
            LoadBar.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(158, 109);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(95, 48);
            label1.Name = "label1";
            label1.Size = new Size(436, 33);
            label1.TabIndex = 2;
            label1.Text = "Boat Booking/Ticketing System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(0, 319);
            label2.Name = "label2";
            label2.Size = new Size(103, 23);
            label2.TabIndex = 3;
            label2.Text = "Loading ...";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(612, 33);
            panel1.TabIndex = 4;
            // 
            // PercentBr
            // 
            PercentBr.AutoSize = true;
            PercentBr.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PercentBr.ForeColor = Color.Blue;
            PercentBr.Location = new Point(109, 319);
            PercentBr.Name = "PercentBr";
            PercentBr.Size = new Size(28, 23);
            PercentBr.TabIndex = 5;
            PercentBr.Text = "%";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // LoadingPg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 377);
            Controls.Add(PercentBr);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(LoadBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoadingPg";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += LoadingPg_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar LoadBar;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label PercentBr;
        private System.Windows.Forms.Timer timer1;
    }
}
