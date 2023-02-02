using Banking.Business;
using System.Windows.Forms;

namespace Banking.UserInterface
{
    public partial class BalanceEnquiry : UserControl
    {
        public static int accountNum;
        public BalanceEnquiry(int accountNo)
        {
            InitializeComponent();
            accountNum = accountNo;
            balenqaccountnotbx.Text = accountNum.ToString();
            balenqavailablebaltbx.Text = AccountDetails.CheckAccountBalance(accountNum).ToString();
        }
    }
}
