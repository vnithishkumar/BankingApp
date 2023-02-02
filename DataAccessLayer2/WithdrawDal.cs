using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class WithdrawDal
    {
        public bool WithdrawFromAcc(double amount, int accountNum)
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {

                SqlCommand cmd = new SqlCommand("spwithdraw", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@amountPara", amount);
                cmd.Parameters.AddWithValue("@accNopara", accountNum);
                int numOfRows = cmd.ExecuteNonQuery();

                if (numOfRows > 0)
                    return true;

                return false;
            }
        }

        public bool UpdateWithdrawTracker(int accountNo, double trackerAmount, string date)
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {

                SqlCommand cmd = new SqlCommand("spwithdrawtracker", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@accNopara", accountNo);
                cmd.Parameters.AddWithValue("@amountpara", trackerAmount);
                cmd.Parameters.AddWithValue("@datePara", date);
                int numOfRows = cmd.ExecuteNonQuery();
                if (numOfRows > 0)
                    return true;

                return false;
            }
        }
    }
}
