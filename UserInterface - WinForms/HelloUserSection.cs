using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banking.Business;

namespace Banking.UserInterface
{
    public partial class HelloUserSection : UserControl
    {
        static int cusId;
        public HelloUserSection(int customerId)
        {
            InitializeComponent();
            cusId = customerId;
            string userName = CustomerDetails.GetCustomerName(customerId);
            namelbl.Text = userName + ",";
            
        }
        private void logoutlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dialogRes = MessageBox.Show("Are you sure?", "Logout", MessageBoxButtons.YesNo);
            if (dialogRes == DialogResult.Yes)
            {
                this.ParentForm.Hide();
                LoginForm loginObj = new LoginForm();
                loginObj.ShowDialog();
            }
            else if (dialogRes == DialogResult.No)
            {
                //do nothing
            }
        }

		private void backbtn_Click(object sender, EventArgs e)
		{
            this.ParentForm.Hide();
            DisplayAccountsForm disAccForm = new DisplayAccountsForm(cusId);
            disAccForm.ShowDialog();
        }
	}
}
