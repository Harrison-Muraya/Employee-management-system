using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            LoginUser.Text = "";
            Password.Text = "";
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (LoginUser.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Missing data!");
            }
            else if (LoginUser.Text == "admin" || Password.Text == "1234")
            {
                Employees Obj = new Employees();
                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username Or Password");
                LoginUser.Text = "";
                Password.Text = "";
            }
        }
    }
}
