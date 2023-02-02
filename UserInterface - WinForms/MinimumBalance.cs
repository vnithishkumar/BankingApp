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
    public partial class MinimumBalance : UserControl
    {
        public MinimumBalance(int accountNo)
        {
            InitializeComponent();
            miniballbl.Text = OthersBll.DisplayMinimumBal(accountNo);
        }
    }
}
