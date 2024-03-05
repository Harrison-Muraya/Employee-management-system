using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Employee_management_System
{
    public partial class Salaries : Form
    {
        Fuctions con;
        public Salaries()
        {
            con = new Fuctions();
            InitializeComponent();
            GetEmployees();
            GetSalary();
            ShowSalary();
        }

        int Dsal = 0;
        String Period = "";
        private void GetSalary()
        {
            string Query = "select empsal from employee where empid = {0}";
            Query = String.Format(Query, Employee.SelectedValue.ToString());
            
            foreach (DataRow dr in con.GetData(Query).Rows)
            {
                Dsal = Convert.ToInt32(dr["empsal"].ToString());
            }

            //MessageBox.Show("" + Dsal);
            if(DaysAttd.Text == "")
            {
                Amountb.Text = "Ksh " + (D * Dsal);
            }
            else if(Convert.ToInt32(DaysAttd.Text) > 31)
            {
                MessageBox.Show("Days Can not be Greater than 31 Days");
            }
            else
            {
                D = Convert.ToInt32(DaysAttd.Text);
                Amountb.Text = "Ksh " + (D * Dsal);
            }
                

        }

        private void GetEmployees()
        {
            string Query = "Select * from employee ";
            Employee.DisplayMember = con.GetData(Query).Columns["empfname"].ToString();
            Employee.ValueMember = con.GetData(Query).Columns["empid"].ToString();
            Employee.DataSource = con.GetData(Query);
        }

        private void ShowSalary()
        {
            string Query = "select * from salary order by scode desc";
            SalaryList.DataSource = con.GetData(Query);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        int D = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Employee.SelectedIndex == -1 || DaysAttd.Text == "" || Periodtb.Text == "")
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    Period = Periodtb.Value.Date.Month.ToString() + " " + Periodtb.Value.Date.Year.ToString();
                    int Amount = Dsal * Convert.ToInt32(DaysAttd.Text);
                    int Days = Convert.ToInt32(DaysAttd.Text);
                    string Query = "insert into salary  values ({0},{1},'{2}',{3},'{4}','{5}')";
                    Query = string.Format(Query, Employee.SelectedValue.ToString(), Days, Period, Amount, DateTime.Today.Date);
                    con.SetData(Query);
                    ShowSalary();
                    MessageBox.Show("Salary Added !");

                    DaysAttd.Text = "";
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SalaryList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           


        }

        private void Employee_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetSalary();
        }

        private void Department_Click(object sender, EventArgs e)
        {
            Departments Obj = new Departments();
            Obj.Show();
            this.Hide();
        }

        private void Amountb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void SEmployee_Click(object sender, EventArgs e)
        {
            Departments Obj = new Departments();
            Obj.Show();
            this.Hide();
        }
    }
}
