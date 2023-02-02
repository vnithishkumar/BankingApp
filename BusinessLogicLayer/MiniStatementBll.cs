using Banking.DataBase;
using System.Data;

namespace Banking.Business
{
    public class MiniStatementBll
    {
        public DataTable DisplayMiniStatment(int accountNum)
        {
            DataTable dt = FetchingData.GetMiniStatement(accountNum);

            return dt;
        }
    }
}
