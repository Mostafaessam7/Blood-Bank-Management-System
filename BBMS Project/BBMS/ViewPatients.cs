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
namespace BBMS
{
    public partial class ViewPatients : Form
    {
        BloodContext bloodContext;
        public ViewPatients()
        {
            bloodContext = new BloodContext();
            InitializeComponent();
            population();
        }
        //   SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=BloodBankDb;Integrated Security=True");
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

           
            int age = DateTime.Now.Year - birthDate.Year;
            if (DateTime.Now.DayOfYear < birthDate.DayOfYear)
            {
                age--;
            }

            return age;
        }
        private void population()
        {
           
            PatientDGV.DataSource = bloodContext.patients.ToList();
      
        }


        int key = 0;
        private void Reset()
        {
            PNameTb.Text = "";
            PPhoneTb.Text = "";
            PAgeTb.Text = "";
            PAddressTb.Text = "";
            PGenderTb.SelectedIndex = -1;
            PBGroupCb.SelectedIndex = -1;
            key = 0;
        }




        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label15_Click(object sender, EventArgs e)
        {
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select Patient To Delete");
            }
            else
            {
                try
                {
                    Patient patient = bloodContext.patients.Where(e => e.PNum == key).FirstOrDefault();
                    bloodContext.patients.Remove(patient);
                    bloodContext.SaveChanges();
                    //Catch Textboxs Value And ComboBoxs Value and make insert query
                    //string query = "Delete from PatientTbl where PNum =" + key + ";";
                    //Con.Open();
                    //SqlCommand cmd = new SqlCommand(query, Con);
                    //cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Successfully Deleted");

                    Reset();
                    population();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void PatientDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //int indx = e.RowIndex;

            PNameTb.Text = PatientDGV.SelectedRows[0].Cells[2].Value.ToString();
            PAgeTb.Text = PatientDGV.SelectedRows[0].Cells[0].Value.ToString();
            PPhoneTb.Text = PatientDGV.SelectedRows[0].Cells[5].Value.ToString();
            PGenderTb.SelectedItem = PatientDGV.SelectedRows[0].Cells[4].Value.ToString();
            PBGroupCb.SelectedItem = PatientDGV.SelectedRows[0].Cells[7].Value.ToString();
            PAddressTb.Text = PatientDGV.SelectedRows[0].Cells[6].Value.ToString();
            if (PNameTb.Text == "")
                key = 0;
            else
            {
                key = Convert.ToInt32(PatientDGV.SelectedRows[0].Cells[1].Value.ToString());
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            PatientF pat = new PatientF();
            pat.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (PNameTb.Text == "" || PPhoneTb.Text == "" || PAgeTb.Text == "" || PGenderTb.SelectedIndex == -1 || PAddressTb.Text == "" || PBGroupCb.SelectedIndex == -1)
            {
                MessageBox.Show("Select Patient To Edit");
            }
            else if (PAgeTb.Text.Length != 14)
            {
                MessageBox.Show("NIDis 14 number ex 3000320023576");
            }
            else if (PPhoneTb.Text.Length != 11)
            {
                MessageBox.Show("NIDis 11 number ex 011120417134");
            }
            else
            {
                try
                {

                    Patient _patient = bloodContext.patients.Where(e => e.PNum == key).FirstOrDefault();
                    _patient.PAddress = PAddressTb.Text;
                   // MessageBox.Show(_patient.PAddress);

                    _patient.PName = PNameTb.Text;
                  //  MessageBox.Show(_patient.PName);




                    _patient.NId = PAgeTb.Text;
                   // MessageBox.Show(_patient.NId);

                    _patient.PAge = CalculateAgeFromNationalID(PAgeTb.Text);
                    //MessageBox.Show(_patient.PAge.ToString());




                    _patient.PBGroup = PBGroupCb.SelectedItem.ToString();

                   // MessageBox.Show(_patient.PBGroup);

                    _patient.PPhone = PPhoneTb.Text;
                    
                   // MessageBox.Show(_patient.PPhone);
                   

                    _patient.PGender = PGenderTb.SelectedItem.ToString();
                   // MessageBox.Show(_patient.PPhone);
                    try
                    {
                        bloodContext.SaveChanges();
                    }
                    catch(Exception eeee)
                    {
                        MessageBox.Show($"Failed to save {eeee.Message}");
                    }
                    //Catch Textboxs Value And ComboBoxs Value and make insert query
                    //string query = "update  PatientTbl set PName='" + PNameTb.Text + "',PAge='" + PAgeTb.Text + "',PPhone='" + PPhoneTb.Text + "',PGender='" + PGenderTb.SelectedItem.ToString() + "',PBGroup='" + PBGroupCb.SelectedItem.ToString() + "',PAdrress='" + PAddressTb.Text + "' where PNum =" + key + ";";
                    //Con.Open();
                    //SqlCommand cmd = new SqlCommand(query, Con);
                    //cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Successfully Edited");
                    //  Con.Close();
                    Reset();
                    population();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
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

        private void label23_Click(object sender, EventArgs e)
        {
            Donor donor = new Donor();
            donor.Show();
            this.Hide();
        }

        private void label24_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
