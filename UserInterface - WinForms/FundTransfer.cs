using System.Text.RegularExpressions;
using System.Windows.Forms;
using Banking.Business;

namespace Banking.UserInterface
{
    public partial class FundTransfer : UserControl
    {
        static int accountNo;
        public FundTransfer(int accountNum)
        {
            InitializeComponent();
            accountNo = accountNum;
            ftavailablebaltbx.Text = AccountDetails.CheckAccountBalance(accountNo).ToString();
        }

        private void beneaccountnotbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '\b') && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numerics");
            }
        }

        private void ftamounttbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '\b') && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numerics");
            }
            if (Regex.IsMatch(ftamounttbx.Text, @"\.\d\d") && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
            if ((ftamounttbx.Text.Length > 10) && (e.KeyChar != '\b'))
                MessageBox.Show("Please enter only 11 digits");
        }

        private void transferbtn_Click(object sender, System.EventArgs e)
        {
            if (beneaccountnotbx.Text == "")
            {
                MessageBox.Show("Please enter the Beneficiary Account Number");
            }
            else if (ftamounttbx.Text == "")
            {
                MessageBox.Show("Please enter the transfer amount");
            }
            else
            {
                int beneAccNum = int.Parse(beneaccountnotbx.Text);
                int senderAccNum = accountNo;
                double transferAmount = double.Parse(ftamounttbx.Text);
                TransactionBll transObj = new TransactionBll();
                string status = transObj.FundTransfer(transferAmount, beneAccNum, senderAccNum);
                MessageBox.Show(status);
                ftavailablebaltbx.Text = AccountDetails.CheckAccountBalance(accountNo).ToString();
            }
            beneaccountnotbx.Clear();
            ftamounttbx.Clear();
        }
    }
}
