using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using BBMS.DBContext;
using Guna.UI2.WinForms;
namespace BBMS
{
    public partial class DonateBlood : Form
    {
        BloodContext bloodContext;
        public DonateBlood()
        {
            bloodContext = new BloodContext();
            InitializeComponent();
            population();
            bloodStock();
        }



        // SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=BloodBankDb;Integrated Security=True");
        private void population()
        {


            DonorsDGV.DataSource = bloodContext.donorTbls.Select(e => new { e.DName, e.DBGroup, e.NID }).ToList();

        }
        int oldStock;
        private void GetStock(string Bgroup)
        {

            oldStock = bloodContext.BloodTbls.Where(e => e.BGroup == Bgroup).Select(e => e.BStook).FirstOrDefault();


        }
        private void bloodStock()
        {


            BloodStockDVG.DataSource = bloodContext.BloodTbls.Select(e => new { e.BGroup, e.BStook }).ToList(); //ds.Tables[0];

        }

        private void DonateBlood_Load(object sender, EventArgs e)
        {

        }

        private void PatientDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DNameTb.Text = DonorsDGV.SelectedRows[0].Cells[0].Value.ToString();
            DBGroupTb.Text = DonorsDGV.SelectedRows[0].Cells[1].Value.ToString();
            MessageBox.Show(DBGroupTb.Text);
            GetStock(DBGroupTb.Text);
        }
        private void Reset()
        {
            DNameTb.Text = "";
            DBGroupTb.Text = "";

        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (DNameTb.Text == "")
            {
                MessageBox.Show("Select A Donor");
            }
            else
            {
                try
                {
                    int stock = oldStock + 1;
                    string CheckBloodGroup = DBGroupTb.Text;
                    BloodTbl blT = bloodContext.BloodTbls.Where(e => e.BGroup == CheckBloodGroup).FirstOrDefault();
                    if (blT != null)
                    {
                        blT.BStook = stock;
                        bloodContext.SaveChanges();
                        MessageBox.Show("Donation Successfully");
                    }
                    //Catch Textboxs Value And ComboBoxs Value and make insert query




                    Reset();
                    bloodStock();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void DonateBlood_Load_1(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NameSearch_TextChanged(object sender, EventArgs e)
        {

            BloodContext bloodContext = new BloodContext();


            DonorsDGV.DataSource = bloodContext.donorTbls.Select(e => new { e.DName ,e.DBGroup, e.NID }).Where(e => e.DName.Contains(NameSearch.Text)).ToList();

        }
    }
}
