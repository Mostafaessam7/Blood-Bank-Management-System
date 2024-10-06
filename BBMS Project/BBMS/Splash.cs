namespace BBMS
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 3000; 
           
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Login login = new Login();
            login.Show();
            this.Hide();
        }


    }
}