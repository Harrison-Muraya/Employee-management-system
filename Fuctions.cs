using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_management_System
{
    class Fuctions
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string ConStr;

        public Fuctions() 
        {
            ConStr = @"Data Source=HARRISON\SQLEXPRESS;Initial Catalog=Employee1;Integrated Security=True;";
            con = new SqlConnection(ConStr);
            cmd = new SqlCommand();
            cmd.Connection = con;
        }

        public DataTable GetData(string Query)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(Query, ConStr);
            sda.Fill(dt);
            return dt;
        }

        public int SetData (string Query)
        {
            int cnt = 0;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.CommandText = Query;
            cnt = cmd.ExecuteNonQuery();
            return cnt;
        }
    }

}
