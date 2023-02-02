using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Banking.Business;

namespace Banking.UserInterface
{
	public partial class Deposit : UserControl
    {
        public static int accountNum;
        public Deposit(int accountNo)
        {
            InitializeComponent();
            accountNum = accountNo;
            depositaccountnotbx.Text = accountNum.ToString();
            depositavailablebaltbx.Text = AccountDetails.CheckAccountBalance(accountNum).ToString();
        }

        private void deposittbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '\b') && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numerics");
            }
            if (Regex.IsMatch(deposittbx.Text, @"\.\d\d") && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
        }

        private void depositbtn_Click(object sender, EventArgs e)
        {
            if (deposittbx.Text == "")
            {
                MessageBox.Show("Please enter the Withdraw Amount");
            }
            else if (deposittbx.Text == "0")
            {
                MessageBox.Show("Please enter valid Amount");
                deposittbx.Clear();
            }
            else
            {
                TransactionBll transobj = new TransactionBll();
   
                if (transobj.DepositAmount(double.Parse(deposittbx.Text), accountNum))
                {
                    MessageBox.Show("Amount Deposited Successfully");
                    depositavailablebaltbx.Text = AccountDetails.CheckAccountBalance(accountNum).ToString();
                    deposittbx.Clear();
                }
            }
        }

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
