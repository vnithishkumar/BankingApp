using System;
using System.Windows.Forms;

namespace Banking.UserInterface
{
    public partial class Menu : Form
    {
        static int accountNo;
        static int customerId;
        public Menu(int accountNum, int cusId)
        {
            InitializeComponent();
            accountNo = accountNum;
            customerId = cusId;
            
            HelloUserSection hellouserObj = new HelloUserSection(customerId);
            toppanel.Controls.Add(hellouserObj);
            hellouserObj.Dock = DockStyle.Fill;
        }

        private void withdrawalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Withdraw ucWithdrawObj = new Withdraw(accountNo);
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(ucWithdrawObj);
            ucWithdrawObj.Dock = DockStyle.Fill;
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deposit ucDepositObj = new Deposit(accountNo);
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(ucDepositObj);
            ucDepositObj.Dock = DockStyle.Fill;
        }

        private void FundTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FundTransfer fundTransObj = new FundTransfer(accountNo);
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(fundTransObj);
            fundTransObj.Dock = DockStyle.Fill;
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void miniStaementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mini_Statement ministmtObj = new Mini_Statement(accountNo);
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(ministmtObj);
            ministmtObj.Dock = DockStyle.Fill;
        }

        private void accountBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BalanceEnquiry ucBalObj = new BalanceEnquiry(accountNo);
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(ucBalObj);
            ucBalObj.Dock = DockStyle.Fill;
        }

        private void fDInterestRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FixedDeposit fdObj = new FixedDeposit();
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(fdObj);
            fdObj.Dock = DockStyle.Fill;
        }

        private void rDInterestRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecurringDeposit rdObj = new RecurringDeposit();
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(rdObj);
            rdObj.Dock = DockStyle.Fill;
        }

        private void minimumnBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MinimumBalance minibalObj = new MinimumBalance(accountNo);
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(minibalObj);
            minibalObj.Dock = DockStyle.Fill;
        }

        private void benefitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Benefits benefitObj = new Benefits(accountNo);
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(benefitObj);
            benefitObj.Dock = DockStyle.Fill;
        }

        private void loanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loan loanObj = new Loan(accountNo);
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(loanObj);
            loanObj.Dock = DockStyle.Fill;
        }

		//private void backbtn_Click(object sender, EventArgs e)
		//{
  //          this.Hide();
  //          DisplayAccountsForm disAccForm = new DisplayAccountsForm(customerId);
  //          disAccForm.ShowDialog();
  //      }
	}
}
