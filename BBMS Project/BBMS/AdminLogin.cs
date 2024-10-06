using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBMS
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (AdminPassTb.Text == "")
            {
                MessageBox.Show("Enter The Admin Password");
            }
            else if (AdminPassTb.Text == "Password")
            {
                EmployeeF employee = new EmployeeF();
                employee.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Password Contact The System Admin");
                AdminPassTb.Text = "";
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
