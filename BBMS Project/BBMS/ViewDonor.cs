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
    public partial class ViewDonor : Form
    {
        public ViewDonor()
        {
            InitializeComponent();
            population();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }



        private void population()
        {
            BloodContext bloodContext = new BloodContext();


            DonorDGV.DataSource = bloodContext.donorTbls.Select(e => new { e.DNum, e.DName, e.DAddress, e.DBGroup, e.NID, e.DGender, e.DPhone }).ToList();


        }
        private void ViewDonor_Load(object sender, EventArgs e)
        {

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

        private void label8_Click(object sender, EventArgs e)
        {
            BloodTransfert Ob = new BloodTransfert();
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

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            BloodContext bloodContext = new BloodContext();


            DonorDGV.DataSource = bloodContext.donorTbls.Select(e => new { e.DNum, e.DName, e.DAddress, e.DBGroup, e.NID, e.DGender, e.DPhone }).Where(e => e.DName.Contains(guna2TextBox1.Text)).ToList();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
