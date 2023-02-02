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
    public partial class FixedDeposit : UserControl
    {
        public FixedDeposit()
        {
            InitializeComponent();
            DisplayFixedDepositTable();
            fixeddepositdgv.Columns["Tenors"].ReadOnly = true;
            fixeddepositdgv.Columns["Interest Rates for Public"].ReadOnly = true;
            fixeddepositdgv.Columns["Interest Rates for Senior Citizens"].ReadOnly = true;
            fixeddepositdgv.AllowUserToAddRows = false;
        }

        public void DisplayFixedDepositTable()
        {
            fixeddepositdgv.DataSource = DepositRatesBll.FillFDTable();
        }
    }
}
