using Banking.Business;
using System.Windows.Forms;

namespace Banking.UserInterface
{
    public partial class RecurringDeposit : UserControl
    {
        public RecurringDeposit()
        {
            InitializeComponent();
            DisplayRDTable();
            rddgv.Columns["Tenors"].ReadOnly = true;
            rddgv.Columns["Interest Rates for Public"].ReadOnly = true;
            rddgv.Columns["Interest Rates for Senior Citizens"].ReadOnly = true;
            rddgv.AllowUserToAddRows = false;
        }

        public void DisplayRDTable()
        {
            rddgv.DataSource = DepositRatesBll.FillRDTable();
        }
    }
}
