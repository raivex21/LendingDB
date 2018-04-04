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
    public partial class EmployeeProfiles : UserControl
    {
        SqlConnection con = new SqlConnection(@"server = LOCALHOST\SQLEXPRESS; Initial Catalog = Egaran_Lending; Integrated Security = true;");
        SqlCommand cmd;
        SqlDataReader rdr;


        public EmployeeProfiles()
        {
            InitializeComponent();
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("INSERT INTO Employees (EmpLname, EmpFname, EmpMname, Borrowed, Paid) VALUES ('"+txtEmpLname.Text+"', '"+txtEmpFname.Text+"', '"+txtEmpMname.Text+"', 0, 0)", con); 
            cmd.ExecuteNonQuery();
            





            con.Close();
            LoadEmployees();
            
        }

        private void LoadEmployees()
        {
            dataEmployees.Rows.Clear();
            con.Open();
            cmd = new SqlCommand("SELECT EmpID, EmpLname, EmpFname, EmpMname FROM Employees;", con);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                dataEmployees.Rows.Add(rdr["EmpID"].ToString(), rdr["EmpLname"].ToString(), rdr["EmpFname"].ToString(), rdr["EmpMname"].ToString());
            }




            con.Close();
        }
        public void LoadEmployeesPublic()
        {
            LoadEmployees();
        }

        private void EmployeeProfiles_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("UPDATE Employees SET EmpLname = '"+txtEmpLname.Text+"', EmpFname = '"+txtEmpFname.Text+"', EmpMname = '"+txtEmpMname.Text+"' WHERE EmpID = '"+txtEmpID.Text+"'", con);
            cmd.ExecuteNonQuery();
            


            con.Close();
            LoadEmployees();
        }

        private void dataEmployees_SelectionChanged(object sender, EventArgs e)
        {
            if(dataEmployees.SelectedRows.Count != 0)
            {
                txtEmpID.Text = dataEmployees.SelectedRows[0].Cells[0].Value.ToString();
                txtEmpLname.Text = dataEmployees.SelectedRows[0].Cells[1].Value.ToString();
                txtEmpFname.Text = dataEmployees.SelectedRows[0].Cells[2].Value.ToString();
                txtEmpMname.Text = dataEmployees.SelectedRows[0].Cells[3].Value.ToString();
            }
        }
    }
}
