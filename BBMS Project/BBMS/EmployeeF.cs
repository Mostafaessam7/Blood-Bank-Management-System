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
    public partial class EmployeeF : Form
    {
        BloodContext bloodContext;
        public EmployeeF()
        {
            bloodContext = new BloodContext();
            InitializeComponent();
            population();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
        // SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=BloodBankDb;Integrated Security=True");

        private void Reset()
        {
            EmpNameTb.Text = "";
            EmpPassTb.Text = "";
            key = 0;
        }
        private void population()
        {
            //Con.Open();
            //string Query = "Select * from EmployeeTb1";
            //SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            //SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            //var ds = new DataSet();
            //sda.Fill(ds);
            EmpDGV.DataSource = bloodContext.employees.ToList();//ds.Tables[0];
            //Con.Close();
        }
        //private void guna2Button1_Click(object sender, EventArgs e)
        //{
        //    if (EmpNameTb.Text == "" || EmpPassTb.Text == "" )
        //    {
        //        MessageBox.Show("Missing Information");
        //    }

        //    else
        //    {
        //        try
        //        {
        //            string setIdentityInsertOn = "SET IDENTITY_INSERT EmployeeTb1 ON;";
        //            string insertData = @"
        //INSERT INTO example_table (EmpId, EmpPass)
        //VALUES (@field1, @field2);";
        //            string setIdentityInsertOff = "SET IDENTITY_INSERT archive_table OFF;";
        //            //Catch Textboxs Value And ComboBoxs Value and make insert query
        //            //string query = "insert into EmployeeTb1 values('" + DNameTb.Text + "'," + DAgeTb.Text + ",'" + DGenCb.SelectedItem.ToString() + "','" + DPhoneTb.Text + "','" + DAddressTb.Text + "','" + DBGroupCb.SelectedItem.ToString() + "')";

        //            string query = "insert into EmployeeTb1 values('" + EmpNameTb.Text + "'," + EmpPassTb.Text + ",'"  + "')";
        //            Con.Open();
        //            using (SqlCommand command = new SqlCommand(insertData, Con))
        //            {
        //                // Add parameters to prevent SQL injection
        //                command.Parameters.AddWithValue("@field1", EmpNameTb.Text);
        //                command.Parameters.AddWithValue("@field2", EmpPassTb.Text);

        //                // Execute the command
        //                int rowsAffected = command.ExecuteNonQuery();

        //                MessageBox.Show($"{rowsAffected} row(s) inserted successfully.");
        //            }
        //            SqlCommand cmd = new SqlCommand(query, Con);
        //            cmd.ExecuteNonQuery();
        //            MessageBox.Show("Employee Successfully Saved");
        //            Con.Close();
        //            Reset();
        //            population();
        //        }
        //        catch (Exception Ex)
        //        {
        //            MessageBox.Show(Ex.Message);
        //        }
        //    }
        //}



        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (EmpNameTb.Text == "" || EmpPassTb.Text == "")
            {
                MessageBox.Show("Missing Information");
                return; // Exit the method if input is missing
            }

            try
            {


                DBContext.Employee emp = new DBContext.Employee() { Name = EmpNameTb.Text, password = EmpPassTb.Text };
                bloodContext.employees.Add(emp);
                bloodContext.SaveChanges();
                MessageBox.Show($" Employee Saved successfully.");
            }
            catch (Exception Ex)
            {
                MessageBox.Show("An error occurred: " + Ex.Message);
            }
            finally
            {
                // Ensure connection is closed even if an error occurs
                Reset();
                population(); // Refresh the data grid
            }
        }
        int key = 0;
        private void EmpDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpNameTb.Text = EmpDGV.SelectedRows[0].Cells[1].Value.ToString();
            EmpPassTb.Text = EmpDGV.SelectedRows[0].Cells[2].Value.ToString();

            if (EmpNameTb.Text == "")
                key = 0;
            else
            {
                key = Convert.ToInt32(EmpDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select Employee To Delete");
            }
            else
            {
                try
                {
                    DBContext.Employee emp = bloodContext.employees.Where(e => e.Id == key).FirstOrDefault();
                    bloodContext.employees.Remove(emp);
                    bloodContext.SaveChanges();
                    //Catch Textboxs Value And ComboBoxs Value and make insert query

                    MessageBox.Show("Employee Successfully Deleted");

                    Reset();
                    population();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (EmpNameTb.Text == "" || EmpPassTb.Text == "")
            {
                MessageBox.Show("Select Employee To Edit");
            }
            else
            {
                try
                {
                    DBContext.Employee emp = bloodContext.employees.Where(e => e.Id == key).FirstOrDefault();
                    emp.Name = EmpNameTb.Text;
                    emp.password = EmpPassTb.Text;
                    bloodContext.SaveChanges();

                    //Catch Textboxs Value And ComboBoxs Value and make insert query

                    MessageBox.Show("Employee Successfully Edited");

                    Reset();
                    population();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EmployeeF_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
