namespace BoatBooking_TicketingSystem
{
    public partial class LoadingPg : Form
    {
        public LoadingPg()
        {
            InitializeComponent();
        }
        int startpos = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpos += 1;
            LoadBar.Value = startpos;
            PercentBr.Text = startpos + "%";
            if (LoadBar.Value == 100)
            {
                LoadBar.Value = 0;
                timer1.Stop();
                LoginPg login = new LoginPg();
                login.Show();
                this.Hide();
            }
        }

        private void LoadingPg_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
