using BBMS.DBContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBMS
{
    public partial class DashBoard : Form
    {
        BloodContext bloodContext;
        public DashBoard()
        {
            bloodContext = new BloodContext();
            InitializeComponent();
            GetData();
        }

        private void GetData()
        {


            DonorLbl.Text = bloodContext.donorTbls.ToList().Count().ToString();


            TransferLbl.Text = bloodContext.transferTbls.ToList().Count().ToString();


            EmployeeLbl.Text = bloodContext.transferTbls.Count().ToString();


            int Bstock = bloodContext.BloodTbls.Select(e => e.BStook).ToList().Sum();
            TotalLbl.Text = Bstock.ToString();


            var bl = bloodContext.BloodTbls.Where(e => e.BGroup == "O+").Select(e => e.BStook).ToList();
            UpdateBloodGroupProgress(bl, Bstock, OplussNumLbl, OPlussProgress);


            bl = bloodContext.BloodTbls.Where(e => e.BGroup == "AB+").Select(e => e.BStook).ToList();
            UpdateBloodGroupProgress(bl, Bstock, ABplussNumlbl, ABPlussProgress);


            bl = bloodContext.BloodTbls.Where(e => e.BGroup == "O-").Select(e => e.BStook).ToList();
            UpdateBloodGroupProgress(bl, Bstock, OminusNumLbl, OMinusProgress);

            bl = bloodContext.BloodTbls.Where(e => e.BGroup == "AB-").Select(e => e.BStook).ToList();
            UpdateBloodGroupProgress(bl, Bstock, ABminusNumLbl, ABMinusProgress);

            //Con.Close();
        }

        private void UpdateBloodGroupProgress(List<int> dt, int totalStock, Label countLabel, Guna.UI2.WinForms.Guna2CircleProgressBar progressBar)
        {
            if (totalStock > 0 && dt.Count > 0 && dt[0] != 0)
            {
                int groupStock = Convert.ToInt32(dt[0]);
                countLabel.Text = groupStock.ToString();

                double percentage = (Convert.ToDouble(groupStock) / totalStock) * 100;

                // Clamp the value between 0 and 100 to avoid ProgressBar range exceptions
                percentage = Math.Max(0, Math.Min(100, percentage));

                progressBar.Value = Convert.ToInt32(percentage);
            }
            else
            {
                countLabel.Text = "0";
                progressBar.Value = 0; // Set progress bar to 0 if there's an issue
            }
        }

        private void DashBoard_Load(object sender, EventArgs e)
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

        private void label8_Click(object sender, EventArgs e)
        {
            BloodTransfert Ob = new BloodTransfert();
            Ob.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {

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

        private void OLblminus_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
