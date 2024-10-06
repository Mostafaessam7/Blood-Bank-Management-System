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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
       // SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=BloodBankDb;Integrated Security=True");
        

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Con.Open();

            // SqlDataAdapter adapter = new SqlDataAdapter("select count(*) from EmployeeTb1 where EmpId ='"+EmpIdTb.Text+"'and EmpPass='"+EmpPassTb.Text+"'",Con);
            // DataTable dt = new DataTable();
            //  adapter.Fill(dt);
            BloodContext bloodContext = new BloodContext();
            var emp = bloodContext.employees.Where(e => e.Name == EmpIdTb.Text && e.password == EmpPassTb.Text).FirstOrDefault();
                //(e => e.Name == EmpIdTb.Text && e.password = EmpPassTb.Text)

            if (emp!=null)
            {
                Mainform mainform = new Mainform();
                mainform.Show();
                this.Hide();
               
            }
            else 
            {
                MessageBox.Show("Wrong Username or Password");
            }
         
        }

        private void label4_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }
    }
}
