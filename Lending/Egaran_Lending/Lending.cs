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
    public partial class Lending : UserControl
    {

        SqlConnection con = new SqlConnection(@"server = LOCALHOST\SQLEXPRESS; Initial Catalog = Egaran_Lending; Integrated Security = true;");
        SqlCommand cmd;
        SqlDataReader rdr;

        public Lending()
        {
            InitializeComponent();
        }

        private void LoadEmployees()
        {
            dataEmployees.Rows.Clear();
            con.Open();
            cmd = new SqlCommand("SELECT Employees.EmpId, EmpLname, EmpFname, EmpMname, Borrowed, Paid FROM Employees;", con);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                dataEmployees.Rows.Add(rdr["EmpID"].ToString(), rdr["EmpLname"].ToString(), rdr["EmpFname"].ToString(), rdr["EmpMname"].ToString(), rdr["Borrowed"].ToString(), rdr["Paid"].ToString());
            }
            con.Close();
        }

        private void Lending_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }
        public void LoadEmployeesPublic()
        {
            LoadEmployees();
        }

        private void dataEmployees_SelectionChanged(object sender, EventArgs e)
        {
            if (dataEmployees.SelectedRows.Count != 0)
            {
                txtEmpID.Text = dataEmployees.SelectedRows[0].Cells[0].Value.ToString();
                txtAmount.Clear();
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            float borrowed;
            float amount;
            string sumtext;
            borrowed = float.Parse(txtAmount.Text);
            amount = float.Parse(dataEmployees.SelectedRows[0].Cells[4].Value.ToString());
            float sum = borrowed + amount;
            sumtext = Convert.ToString(sum);
            con.Open();
            cmd = new SqlCommand("UPDATE Employees SET Borrowed = '" + sumtext + "' WHERE EmpID = '" + dataEmployees.SelectedRows[0].Cells[0].Value + "'", con);
            //
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("INSERT INTO PaymentHistory (EmpId, Paid) VALUES ('" + txtEmpID.Text + "', 0)", con);
            cmd.ExecuteNonQuery();

            con.Close();
            LoadEmployees();
        }
    }
}
