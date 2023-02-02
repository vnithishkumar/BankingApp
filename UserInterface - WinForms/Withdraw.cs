using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Banking.Business;

namespace Banking.UserInterface
{
	public partial class Withdraw : UserControl
    {
        public static int accountNum;
        public Withdraw(int accountNo)
        {
            InitializeComponent();
            accountNum = accountNo;
            withdrawaccountnotbx.Text = accountNum.ToString();
            withdrawavailablebaltbx.Text = AccountDetails.CheckAccountBalance(accountNum).ToString();
        }

        private void withdrawamounttxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '\b') && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numerics");
            }
            if (Regex.IsMatch(withdrawamounttbx.Text, @"\.\d\d") && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
            if ((withdrawamounttbx.Text.Length > 10) && (e.KeyChar != '\b'))
                MessageBox.Show("Please enter only 11 digits");
        }

        private void withdrawbtn_Click(object sender, EventArgs e)
        {
            if (withdrawamounttbx.Text == "")
            {
                MessageBox.Show("Please enter the Withdraw Amount");
            }
            else if (withdrawamounttbx.Text == "0" | withdrawamounttbx.Text == ".")
            {
                MessageBox.Show("Please enter valid Amount");
                withdrawamounttbx.Clear();
            }
            else
            {
                TransactionBll transobj = new TransactionBll();
                WithdrawEnum.WithdrawCodes result = transobj.Withdrawal(double.Parse(withdrawamounttbx.Text), accountNum);

                if(result == WithdrawEnum.WithdrawCodes.InvalidAmount)
				{
                    MessageBox.Show("Invalid Amount. Less than 1rs");
                }
                else if (result == WithdrawEnum.WithdrawCodes.LowAccountBalance)
                {
                    MessageBox.Show("Amount Exceeds Account Balance");
                }
				else if (result == WithdrawEnum.WithdrawCodes.ExceedsPerDayLimit)
				{
					MessageBox.Show("Amount Exceeds Per day Withdrawal Limit");
				}
                else if(result == WithdrawEnum.WithdrawCodes.Success)
				{
                    MessageBox.Show("Amount Withdrawed Successfully");
                    withdrawavailablebaltbx.Text = AccountDetails.CheckAccountBalance(accountNum).ToString();
                }
                withdrawamounttbx.Clear();
            }
		}
    }
}













/*
private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
{
    int i;
    for(i=1;i<=10;i++)
    {
        Thread.Sleep(1000);
        backgroundWorker1.ReportProgress(i*10);
    }
    //Thread.Sleep(20000);
    TransactionBll transobj = new TransactionBll();
    bool updated = transobj.Withdrawal(double.Parse(withdrawamounttbx.Text), accountNum);

    if (!updated)
    {
        MessageBox.Show("Please enter within the Withdraw limit");
    }
    //else if (updated)
    //{
    //    MessageBox.Show("Amount Withdrawed Successfully");
    //}
}

private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
{
    withdrawprogbar.Value = e.ProgressPercentage;
    progbarlbl.Text = e.ProgressPercentage.ToString() + "%";
}

private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
{
    if (e.Cancelled)
    {
        MessageBox.Show("Processing cancelled");
    }
    else if (e.Error != null)
    {
        MessageBox.Show(e.Error.Message);
    }
    else
    {
        withdrawavailablebaltbx.Text = AccountDetails.CheckAccountBalance(accountNum).ToString();
        MessageBox.Show("Amount Withdrawed Successfully");
    }
}
*/

