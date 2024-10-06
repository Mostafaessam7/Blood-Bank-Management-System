using BBMS.DBContext;
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


namespace BBMS
{
    public partial class BloodStock : Form
    {
        BloodContext bloodContext ;
        public BloodStock()
        {
            bloodContext = new BloodContext();
            InitializeComponent();
            bloodStock();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=BloodBankDb;Integrated Security=True");

        private void bloodStock()
        {
            
            var bloodList = bloodContext.BloodTbls.Select(e => new { e.BGroup, e.BStook }).ToList();
            //Con.Open();
            //string Query = "Select * from BloodTbl";

            //SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            //SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            //var ds = new DataSet();
            //sda.Fill(ds);

            //  BindingList<BloodTbl> bd = new BindingList<BloodTbl>();
            //Virtual.Items.Add("begin");

            //foreach (var b in bloodList)
            //{
            //    Virtual.Items.Add(b.BGroup);
            //    Virtual.Items.Add("adfsdf");

            //}
            //Virtual.Items.Add("End");

            BloodStockDVG.DataSource = bloodList;//ds.Tables[0];
            //Con.Close();


        }

        private void BloodStock_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            BloodTransfert Bt = new BloodTransfert();
            Bt.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

            Donor donor = new Donor();
            donor.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            DonateBlood Ob = new DonateBlood();
            Ob.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ViewDonor Ob = new ViewDonor();
            Ob.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

            PatientF Ob = new PatientF();
            Ob.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

            ViewPatients Ob = new ViewPatients();
            Ob.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            BloodStock Ob = new BloodStock();
            Ob.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            DashBoard Ob = new DashBoard();
            Ob.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DBGroupCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var bloodList = bloodContext.BloodTbls.Select(e => new { e.BGroup, e.BStook }).Where(e => e.BGroup == DBGroupCb.Text).ToList();
            BloodStockDVG.DataSource = bloodList;
        }
    }
}

