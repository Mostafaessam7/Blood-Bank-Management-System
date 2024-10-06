using BBMS.DBContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace BBMS
{
    public partial class Donor : Form
    {
        public Donor()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        //Connection Stirng 
        // SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=BloodBankDb;Integrated Security=True");
        //Function That Reset Donor Form Data (Values)

        private void Reset()
        {
            DNameTb.Text = "";
            DPhoneTb.Text = "";
            DAgeTb.Text = "";
            DAddressTb.Text = "";
            DGenCb.SelectedIndex = -1;
            DBGroupCb.SelectedIndex = -1;

        }
        public static int CalculateAgeFromNationalID(string nationalID)
        {
            if (nationalID.Length != 14)
            {
                throw new ArgumentException("Invalid national ID number. It must be 14 digits long.");
            }

            // Extract birth date components from the national ID
            string century = nationalID.Substring(0, 1); // 1st digit (century)
            string year = nationalID.Substring(1, 2);    // 2nd and 3rd digits (year)
            string month = nationalID.Substring(3, 2);   // 4th and 5th digits (month)
            string day = nationalID.Substring(5, 2);     // 6th and 7th digits (day)

            int birthYear = int.Parse(year);
            int birthMonth = int.Parse(month);
            int birthDay = int.Parse(day);

            // Determine the full year of birth
            if (century == "2")
            {
                birthYear += 1900; // 1900s century
            }
            else if (century == "3")
            {
                birthYear += 2000; // 2000s century
            }
            else
            {
                throw new ArgumentException("Invalid century in the national ID number.");
            }

            // Create DateTime object for the birth date
            DateTime birthDate = new DateTime(birthYear, birthMonth, birthDay);

            // Calculate age
            int age = DateTime.Now.Year - birthDate.Year;
            if (DateTime.Now.DayOfYear < birthDate.DayOfYear)
            {
                age--;
            }

            return age;
        }
        //Save Button Click 
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //Validation on Textboxs and Comboboxs
            if (DNameTb.Text == "" || DPhoneTb.Text == "" || DAgeTb.Text == "" || DGenCb.SelectedIndex == -1 || DAddressTb.Text == "" || DBGroupCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else if (DAgeTb.Text.Length != 14)
            {
                MessageBox.Show("NIDis 14 number ex 3000320023576");
            }
            else if (DPhoneTb.Text.Length != 11)
            {
                MessageBox.Show("NIDis 11 number ex 011120417134");
            }
            else
            {
                try
                {
                    BloodContext bloodContext = new BloodContext();
                    DonorTbl donor = new DonorTbl();
                    donor.DAddress = DAddressTb.Text;
                    // MessageBox.Show(donor.DAddress);
                    donor.DName = DNameTb.Text;
                  //  MessageBox.Show(donor.DName);

                    donor.NID = DAgeTb.Text;
                   // MessageBox.Show(donor.NID);

                    donor.DAge= CalculateAgeFromNationalID(donor.NID);

                  //  MessageBox.Show(donor.DAge.ToString());

                
                    //MessageBox.Show(donor.DNum.ToString());

                    donor.DBGroup = DBGroupCb.SelectedItem.ToString();
                 //   MessageBox.Show(donor.DBGroup);

                    donor.DPhone = DPhoneTb.Text;
                  //  MessageBox.Show(donor.DPhone);

                    donor.DGender = DGenCb.SelectedItem.ToString();
                    //MessageBox.Show(donor.DGender);


                    bloodContext.donorTbls.Add(donor);
                    try
                    {
                        bloodContext.SaveChanges();

                    }
                    catch (Exception eee)
                    {
                        MessageBox.Show(eee.Message);
                    }
                    //Catch Textboxs Value And ComboBoxs Value and make insert query
                    //string query = "insert into DonorTbl values('" + DNameTb.Text + "'," + DAgeTb.Text + ",'" + DGenCb.SelectedItem.ToString() + "','" + DPhoneTb.Text + "','" + DAddressTb.Text + "','" + DBGroupCb.SelectedItem.ToString() + "')";
                    //            Con.Open();
                    //            SqlCommand cmd = new SqlCommand(query, Con);
                    //            cmd.ExecuteNonQuery();
                    MessageBox.Show("Donor Successfully Saved");
                    //            Con.Close();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void Donor_Load(object sender, EventArgs e)
        {

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DGenCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
