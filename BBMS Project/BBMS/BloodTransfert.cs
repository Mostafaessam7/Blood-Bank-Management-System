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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BBMS
{
    public partial class BloodTransfert : Form
    {
        BloodContext bloodContext;
        public BloodTransfert()
        {
            bloodContext = new BloodContext();
            InitializeComponent();
            fillPatientCb();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void fillPatientCb()
        {

            var bloodList = bloodContext.patients.Select(e => e.PNum).ToList();

            PatientIdCb.DataSource = bloodList;

        }
        private void GetData()
        {
            MessageBox.Show(PatientIdCb.SelectedValue.ToString());
            int x = int.Parse(PatientIdCb.SelectedValue.ToString());
            var bloodList = bloodContext.patients.Where(e => e.PNum == x).ToList();

            foreach (var dr in bloodList)
            {
                PatNameTb.Text = dr.PName;
                BloodGroup.Text = dr.PBGroup;

            }



        }
        int Stock = 0;
        private void GetStock(string Bgroup)
        {
            var bloodList = bloodContext.BloodTbls.Where(e => e.BGroup == Bgroup).ToList();


            foreach (var dr in bloodList)
            {
                Stock = dr.BStook;

            }



        }
        private void BloodTransfert_Load(object sender, EventArgs e)
        {

        }
        //int oldStock;
        //private void GetStock(string Bgroup)
        //{
        //    //Helps to get the actual stock of Blood based on particular Blood Group
        //    Con.Open();
        //    string query = "select * from BloodTbl where BGroup='" + Bgroup + "'";
        //    SqlCommand cmd = new SqlCommand(query, Con);
        //    DataTable dt = new DataTable();
        //    SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //    sda.Fill(dt);
        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        oldStock = Convert.ToInt32(dr["BStock"].ToString());

        //    }

        //    Con.Close();

        //}
        private void PatientIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetData();
            GetStock(BloodGroup.Text);
            if (Stock > 0)
            {
                TransferBtn.Visible = true;
                AvailableLbl.Text = "Available Stock";
                AvailableLbl.Visible = true;

            }
            else
            {
                AvailableLbl.Text = "Stock Not Available";
                AvailableLbl.Visible = true;

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            PatientF pat = new PatientF();
            pat.Show();
            this.Hide();
        }
        private void Reset()
        {
            PatNameTb.Text = "";
            //PatientIdCb.SelectedValue = -1;
            BloodGroup.Text = "";
            AvailableLbl.Visible = false;
            TransferBtn.Visible = false;
        }

        private void updateStock()
        {
            int newStock = Stock - 1;
            try
            {
                var bloodList = bloodContext.BloodTbls.Where(e => e.BGroup == BloodGroup.Text).FirstOrDefault();
                MessageBox.Show(newStock.ToString());
                bloodList.BStook = newStock;
                bloodContext.SaveChanges();



            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void TransferBtn_Click(object sender, EventArgs e)
        {
            if (PatNameTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }

            else
            {
                try
                {
                    TransferTbl transferTbl = new TransferTbl() { PName = PatNameTb.Text, PBGroup = BloodGroup.Text };
                    bloodContext.transferTbls.Add(transferTbl);
                    bloodContext.SaveChanges();

                    MessageBox.Show("Successfull Transfer");

                    GetStock(BloodGroup.Text);
                    updateStock();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            BloodStock Bstock = new BloodStock();
            Bstock.Show();
            this.Hide();

        }

        private void label11_Click(object sender, EventArgs e)
        {
            DashBoard Ob = new DashBoard();
            Ob.Show();
            this.Hide();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void BloodGroup_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
