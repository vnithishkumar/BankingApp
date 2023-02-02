using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Banking.DataBase
{
    public class Deposit
    {
        public static bool DepositToAcc(double amount, int accountNum)
        {
            return QueryOptimizer.ExecuteNonQueryFunc("spdeposit", "@accNoPara", accountNum, "@amountPara", amount);
        }
    }
}
