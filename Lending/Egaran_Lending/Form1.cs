using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Egaran_Lending
{
    public partial class LendingCompany : Form
    {


        public LendingCompany()
        {
            InitializeComponent();
            dashbtnHome.BackColor = clickedColor;
        }


        private Color clickedColor = Color.FromArgb(91, 192, 222);
        private Color unclickedColor = Color.FromArgb(43, 62, 80);
        

        private void dashbtnEmp_MouseClick(object sender, MouseEventArgs e)
        {
            dashbtnEmp.BackColor = clickedColor;
            Profiles.Visible = true;
            Lending.Visible = false;
            Payment.Visible = false;
            dashbtnHome.BackColor = unclickedColor;
            dashbtnLending.BackColor = unclickedColor;
            dashbtnPayment.BackColor = unclickedColor;

        }

        private void dashbtnHome_MouseClick(object sender, MouseEventArgs e)
        {
            dashbtnHome.BackColor = clickedColor;
            Profiles.Visible = false;
            Lending.Visible = false;
            Payment.Visible = false;
            dashbtnEmp.BackColor = unclickedColor;
            dashbtnLending.BackColor = unclickedColor;
            dashbtnPayment.BackColor = unclickedColor;
        }

        private void dashbtnLending_MouseClick(object sender, MouseEventArgs e)
        {
            dashbtnLending.BackColor = clickedColor;
            Profiles.Visible = false;
            Lending.Visible = true;
            Payment.Visible = false;
            dashbtnHome.BackColor = unclickedColor;
            dashbtnEmp.BackColor = unclickedColor;
            dashbtnPayment.BackColor = unclickedColor;
            Lending.LoadEmployeesPublic();
            
        }

        private void dashbtnPayment_MouseClick(object sender, MouseEventArgs e)
        {
            dashbtnLending.BackColor = unclickedColor;
            Profiles.Visible = false;
            Lending.Visible = false;
            Payment.Visible = true;
            dashbtnHome.BackColor = unclickedColor;
            dashbtnEmp.BackColor = unclickedColor;
            dashbtnPayment.BackColor = clickedColor;
            Payment.LoadPaymentsHistoryPublic();
        }
    }
}
