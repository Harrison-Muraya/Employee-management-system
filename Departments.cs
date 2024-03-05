using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_management_System
{
    public partial class Departments : Form
    {
        Fuctions con;
        public Departments()
        {
            InitializeComponent();
            con = new Fuctions();
            ShowDeprtments();
        }
        private void ShowDeprtments()
        {
            string Query = "select * from department";
            DepList.DataSource = con.GetData(Query);
        }
        private void Addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(DepNametb.Text =="")
                {
                    MessageBox.Show("Missing Data!","Error");
                }
                else
                {
                   
                    string Query = "insert into department values('{0}')";
                    Query = string.Format(Query,DepNametb.Text);
                    con.SetData(Query);
                    ShowDeprtments();
                    MessageBox.Show("Department Added!");

                }DepNametb.Text = "";
            }
            catch(Exception Ex) 
            {
                MessageBox.Show(Ex.Message);
            }
        }

       int key = 0;
        private void DepList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DepNametb.Text = DepList.SelectedRows[0].Cells[1].Value.ToString();
            if (DepNametb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(DepList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNametb.Text == "")
                {
                    MessageBox.Show("Missing Data!", "Error");
                }
                else
                {
                    string Dep = DepNametb.Text;
                    string Query = "Delete from department  where dptid = {1}";
                    Query = string.Format(Query, DepNametb.Text, key);
                    con.SetData(Query);
                    ShowDeprtments();
                    MessageBox.Show("Department Deleted!");

                }
                DepNametb.Text = "";
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNametb.Text == "")
                {
                    MessageBox.Show("Missing Data!", "Error");
                }
                else
                {
                    string Dep = DepNametb.Text;
                    string Query = "update department set dptname = '{0}' where dptid = {1}";
                    Query = string.Format(Query, DepNametb.Text, key);
                    con.SetData(Query);
                    ShowDeprtments();
                    MessageBox.Show("Department Updated!");

                }
                DepNametb.Text = "";
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Employees_Click(object sender, EventArgs e)
        {
            Employees Obj = new Employees();
            Obj.Show();
            this.Hide();
        }

        private void Salary_Click(object sender, EventArgs e)
        {
            Salaries Obj = new Salaries();
            Obj.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void lDepart_Click(object sender, EventArgs e)
        {
            Departments Obj = new Departments();
            Obj.Show(); 
            this.Hide();
        }
    }
}
