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
    public partial class Employees : Form
    {
        Fuctions con;
        public Employees()
        {
            con = new Fuctions();
            InitializeComponent();
            ShowEmployees();

            GetDepartments();
        }

        private void ShowEmployees()
        {
            string Query = "select * from employee order by empid desc ";
            Emplist.DataSource = con.GetData(Query);
        }

        private void Employees_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void GetDepartments()
        {
            string Query = "Select * from department";
            Empdepartmet.DisplayMember = con.GetData(Query).Columns["dptname"].ToString();
            Empdepartmet.ValueMember = con.GetData(Query).Columns["dptid"].ToString();
            Empdepartmet.DataSource = con.GetData(Query);

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Empfname.Text == "" || EmpSurname.Text == "" || EmpGender.SelectedIndex == -1 || Empdepartmet.SelectedIndex == -1 || EmpSalary.Text == "")
                {
                    MessageBox.Show("Missing Data!", "Error");
                }
                else
                {
                    string Name = Empfname.Text;
                    string Surname = EmpSurname.Text;
                    string Gender = EmpGender.SelectedItem.ToString();
                    int Dep = Convert.ToInt32(Empdepartmet.SelectedValue.ToString());
                    string DoB = EDoB.Value.ToString();
                    string JDate = Jdate.Value.ToString();
                    int Salary = Convert.ToInt32(EmpSalary.Text);

                    string Query = "insert into employee values ('{0}','{1}','{2}',{3},'{4}','{5}',{6})";
                    Query = string.Format(Query, Name, Surname, Gender, Dep, DoB, JDate, Salary);
                    con.SetData(Query);
                    ShowEmployees();
                    MessageBox.Show("Employee Added !");

                    Empfname.Text = "";
                    EmpSurname.Text = "";
                    EmpSalary.Text = "";
                    EmpGender.SelectedIndex = -1;
                    Empdepartmet.SelectedIndex = -1;
                }
                
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        int Key = 0;
        private void Emplist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Empfname.Text = Emplist.SelectedRows[0].Cells[1].Value.ToString();
            EmpSurname.Text = Emplist.SelectedRows[0].Cells[2].Value.ToString();
            EmpGender.Text = Emplist.SelectedRows[0].Cells[3].Value.ToString();
            Empdepartmet.SelectedValue = Emplist.SelectedRows[0].Cells[4].Value.ToString();
            EDoB.Text = Emplist.SelectedRows[0].Cells[5].Value.ToString();
            Jdate.Text = Emplist.SelectedRows[0].Cells[6].Value.ToString();
            EmpSalary.Text = Emplist.SelectedRows[0].Cells[7].Value.ToString();

            if(Empfname.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(Emplist.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Empfname.Text == "" || EmpSurname.Text == "" || EmpGender.SelectedIndex == -1 || Empdepartmet.SelectedIndex == -1 || EmpSalary.Text == "")
                {
                    MessageBox.Show("Missing Data!", "Error");
                }
                else
                {
                    string Name = Empfname.Text;
                    string Surname = EmpSurname.Text;
                    string Gender = EmpGender.SelectedItem.ToString();
                    int Dep = Convert.ToInt32(Empdepartmet.SelectedValue.ToString());
                    string DoB = EDoB.Value.Date.ToString();
                    string JDate = Jdate.Value.ToString();
                    int Salary = Convert.ToInt32(EmpSalary.Text);

                    string Query = "update employee set empfname = '{0}',empsurname = '{1}',empgen = '{2}', empdpt = {3}, empdob = '{4}', empjdate = '{5}', empsal = {6} where empid = {7}";
                    Query = string.Format(Query, Name, Surname, Gender, Dep, DoB, JDate, Salary, Key);
                    con.SetData(Query);
                    ShowEmployees();
                    MessageBox.Show("Employee Edited !");

                    Empfname.Text = "";
                    EmpSurname.Text = "";
                    EmpSalary.Text = "";
                    EmpGender.SelectedIndex = -1;
                    Empdepartmet.SelectedIndex = -1;
                }

            }
            catch (Exception Ex)
            { 
                MessageBox.Show(Ex.Message);
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Key == 0)
                {
                    MessageBox.Show("Missing Data!", "Error");
                }
                else
                {
                    string Query = "delete from employee where empid = {0}";
                    Query = string.Format(Query, Key);
                    con.SetData(Query);
                    ShowEmployees();
                    MessageBox.Show("Employee Deleted !");

                    Empfname.Text = "";
                    EmpSurname.Text = "";
                    EmpSalary.Text = "";
                    EmpGender.SelectedIndex = -1;
                    Empdepartmet.SelectedIndex = -1;
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Salaries obj = new Salaries();
            obj.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Departments obj = new Departments();
            obj.Show(); 
            this.Hide();
        }
    }
}
