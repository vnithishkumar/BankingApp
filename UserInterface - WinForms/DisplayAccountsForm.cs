using Banking.Business;
using System;
using System.Data;
using System.Windows.Forms;

namespace Banking.UserInterface
{

    public partial class DisplayAccountsForm : Form
    {
        
        public static int customerId;
        public DisplayAccountsForm(int cusId)
        {
            InitializeComponent();
            DisplayDataViewGrid(cusId);
            customerId = cusId;
            dgv1.Columns["AccountNo"].ReadOnly = true;
            dgv1.Columns["BalanceAmount"].ReadOnly = true;
            dgv1.Columns["AccountType"].ReadOnly = true;
            dgv1.AllowUserToAddRows = false;
            string userName = CustomerDetails.GetCustomerName(customerId);

            HelloUserSection hellouserObj = new HelloUserSection(customerId);
            toppanel2.Controls.Add(hellouserObj);
            hellouserObj.Dock = DockStyle.Fill;


        }

        public void DisplayDataViewGrid(int cusId)
        {
            DisplayAccountDetailsBll disAccObj = new DisplayAccountDetailsBll();

            DataTable dt =  disAccObj.DisplayCustomerAccounts(cusId);

            dgv1.DataSource = dt;
        }

        private void accountnotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '\b'))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numerics");
            }
        }
        private void proceedbtn_Click(object sender, EventArgs e)
        {

            if (accountnotxt.Text == "")
            {
                MessageBox.Show("Please enter the Account Number");
            }
            
            else
            {
                int accountNo = int.Parse(accountnotxt.Text);

                if (AccountDetails.CheckAccountNo(accountNo)) //this method checks whether the account number is present or not.
                {
                    this.Hide();
                    Menu menuobj = new Menu(accountNo, customerId);
                    menuobj.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please Enter the correct account number");
                }
            }
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogRes = MessageBox.Show("Are You Sure", "Logout", MessageBoxButtons.YesNo);
            if (dialogRes == DialogResult.Yes)
            {
                this.Hide();
                LoginForm loginObj = new LoginForm();
                loginObj.ShowDialog();
            }
            else if (dialogRes == DialogResult.No)
            {
                //do nothing
            }
        }

        private void DisplayAccountsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
