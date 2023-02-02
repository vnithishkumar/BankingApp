using System.Data;
using System.Data.SqlClient;

namespace Banking.DataBase
{
    public class FundTransfer
    {
        public bool FundTransferFunc(int beneAccNum, int senderAccNum, double amount)
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("spfundtransfer", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@beneAccNoPara", beneAccNum);
                cmd.Parameters.AddWithValue("@senderAccNoPara", senderAccNum);
                cmd.Parameters.AddWithValue("@AmountPara", amount);
                int numOfRows = cmd.ExecuteNonQuery();

                if (numOfRows > 0)
                    return true;

                return false;
            }
        }
    }
}
