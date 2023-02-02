using Banking.Business;
using System.Data;
using System.Windows.Forms;


namespace Banking.UserInterface
{
    public partial class Mini_Statement : UserControl
    {
        public Mini_Statement(int accountNum)
        {
            InitializeComponent();
            DisplayMiniStatment(accountNum);
            ministmtdgv.AllowUserToAddRows = false;
            ministmtdgv.Columns["Date"].ReadOnly = true;
            ministmtdgv.Columns["AccountNo"].ReadOnly = true;
            ministmtdgv.Columns["Transaction"].ReadOnly = true;
            ministmtdgv.Columns["Amount"].ReadOnly = true;
            
        }

        public void DisplayMiniStatment(int accountNum)
        {

            MiniStatementBll ministmtObj = new MiniStatementBll();

            DataTable dt = ministmtObj.DisplayMiniStatment(accountNum);

            ministmtdgv.DataSource = dt;
        }
    }
}
