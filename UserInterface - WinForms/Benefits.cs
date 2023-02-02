using System.Windows.Forms;
using Banking.Business;

namespace Banking.UserInterface
{
    public partial class Benefits : UserControl
    {
        public Benefits(int accountNo)
        {
            InitializeComponent();
            benefitlbl.Text = OthersBll.DisplayBenfits(accountNo);
        }
    }
}
