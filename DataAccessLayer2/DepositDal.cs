using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class DepositDal
    {
        public static bool DepositToAcc(double amount, int accountNum)
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {

                SqlCommand cmd = new SqlCommand("spdeposit", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@accNoPara", accountNum);
                cmd.Parameters.AddWithValue("@amountPara", amount);
                int numOfRows = cmd.ExecuteNonQuery();
                if (numOfRows > 0 )
                    return true;

                return false;
            }
        }
    }
}
