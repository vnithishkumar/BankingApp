using System.Data;
using System.Data.SqlClient;

namespace Banking.DataBase
{
	public class Withdraw
    {
        public bool WithdrawFromAcc(double amount, int accountNum)
        {
            return QueryOptimizer.ExecuteNonQueryFunc("spwithdraw", "@amountPara", amount, "@accNopara", accountNum);
        }

        public bool UpdateWithdrawTracker(int accountNo, double trackerAmount)
        {
            return QueryOptimizer.ExecuteNonQueryFunc("spwithdrawtracker", "@accNopara", accountNo, "@amountpara", trackerAmount);
        }
    }
}
