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
using BBMS.DBContext;
namespace BBMS
{
    public partial class PatientF : Form
    {
        public PatientF()
        {
            InitializeComponent();
        }
        //   SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=BloodBankDb;Integrated Security=True");
        //Function That Reset Donor Form Data (Values)

        private void Reset()
        {
            PNameTb.Text = "";
            PPhoneTb.Text = "";
            PAgeTb.Text = "";
            PAddressTb.Text = "";
            PGenderTb.SelectedIndex = -1;
            PBGroupCb.SelectedIndex = -1;

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
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (PNameTb.Text == "" || PPhoneTb.Text == "" || PAgeTb.Text == "" || PGenderTb.SelectedIndex == -1 || PAddressTb.Text == "" || PBGroupCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else if (PAgeTb.Text.Length != 14)
            {
                MessageBox.Show("NIDis 14 number ex 3000320023576");
            }
            else if (PPhoneTb.Text.Length!=11)
            {
                MessageBox.Show("NIDis 11 number ex 011120417134");
            }
            else
            {
                try
                {




                    BloodContext bloodContext = new BloodContext();
                    Patient _patient = new Patient();
                    _patient.PAddress = PAddressTb.Text;
                    //MessageBox.Show(_patient.PAddress);

                    _patient.PName = PNameTb.Text;
                    //MessageBox.Show(_patient.PName);

                    _patient.NId = PAgeTb.Text;
                    //MessageBox.Show(_patient.NId);

                    _patient.PAge = CalculateAgeFromNationalID(_patient.NId);
                   // MessageBox.Show(_patient.PAge.ToString());





                    _patient.PBGroup = PBGroupCb.SelectedItem.ToString();

                  //  MessageBox.Show(_patient.PBGroup);

                    _patient.PPhone = PPhoneTb.Text;
                  //  MessageBox.Show(_patient.PPhone);
                   


                    _patient.PGender = PGenderTb.SelectedItem.ToString();

                 //   MessageBox.Show(_patient.PGender);


                    bloodContext.patients.Add(_patient);
                    try
                    {
                        bloodContext.SaveChanges();

                    }
                    catch (Exception eee)
                    {
                        MessageBox.Show(eee.Message);
                    }
                    MessageBox.Show("Patient Successfully Saved");


                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ViewPatients VP = new ViewPatients();
            VP.Show();
            this.Hide();
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

        private void label23_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
