using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Egaran_Lending
{
    public partial class Payments : UserControl
    {
        SqlConnection con = new SqlConnection(@"server = LOCALHOST\SQLEXPRESS; Initial Catalog = Egaran_Lending; Integrated Security = true;");
        SqlCommand cmd;
        SqlDataReader rdr;


        public Payments()
        {
            InitializeComponent();
        }
        private void LoadEmployees()
        {
            dataEmployees.Rows.Clear();
            con.Open();
            cmd = new SqlCommand("SELECT EmpID, EmpLname + ', ' + EmpFname + ' ' + EmpMname AS Employee, Borrowed, Paid FROM Employees", con);
            //"SELECT Employees.EmpID, EmpLname + ', ' + EmpFname + ' ' + EmpMname AS Employee, Borrowed, PaymentHistory.Paid FROM Employees LEFT JOIN PaymentHistory ON PaymentHistory.EmpID = Employees.EmpID;"
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                dataEmployees.Rows.Add(rdr["EmpID"].ToString(), rdr["Employee"].ToString(), rdr["Borrowed"].ToString(), rdr["Paid"].ToString());
            }




            con.Close();
        }

        private void Payments_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }
        public void LoadPaymentsHistoryPublic()
        {
            LoadEmployees();
        }

        private void dataEmployees_SelectionChanged(object sender, EventArgs e)
        {
            if (dataEmployees.SelectedRows.Count != 0)
            {
                txtEmpID.Text = dataEmployees.SelectedRows[0].Cells[0].Value.ToString();
                LoadPaymentHistory();
            }
        }

        private void LoadPaymentHistory()
        {
            dataHistory.Rows.Clear();
            con.Open();
            cmd = new SqlCommand("SELECT Paid, DatePaid FROM PaymentHistory WHERE EmpID LIKE '%"+txtEmpID.Text+"%' AND Paid != 0;", con);
            rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                dataHistory.Rows.Add(rdr["Paid"].ToString(), rdr["DatePaid"].ToString());
            }
            con.Close();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            float paid;
            float amount;
            string sumtext;
            float sum;
            paid = float.Parse(txtAmount.Text);
            amount = float.Parse(dataEmployees.SelectedRows[0].Cells[3].Value.ToString());

            sum = paid + amount;
            sumtext = Convert.ToString(sum);
            con.Open();
            cmd = new SqlCommand("UPDATE Employees SET Paid = '" + sumtext + "' WHERE EmpID = '"+txtEmpID.Text+"'" , con);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("INSERT INTO PaymentHistory (EmpID, Paid, DatePaid) VALUES ('"+txtEmpID.Text+"', '" + txtAmount.Text + "', '" + DateTime.Now.ToString("MM/dd/yyyy HH:MM:ss") + "')", con);
            cmd.ExecuteNonQuery();
            
            //should add seperate table for paid and date in database 
            con.Close();
            LoadEmployees();
            LoadPaymentHistory();
            /*if (dataEmployees.SelectedRows[0].Cells[2].Value.Equals(dataEmployees.SelectedRows[0].Cells[3].Value))
            {
                con.Open();
                cmd = new SqlCommand("UPDATE Employees SET Borrowed = 0, Paid = 0 WHERE EmpID = '" + txtEmpID.Text + "'", con);
                cmd.ExecuteNonQuery();

                con.Close();
            }*/
            
        }
    }
}
