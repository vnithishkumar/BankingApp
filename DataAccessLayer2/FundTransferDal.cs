using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class FundTransferDal
    {
        public bool FundTransfer(double beneAccBal, int beneAccNum, double senderAccBal, int senderAccNum)
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {

                SqlCommand cmd = new SqlCommand("spfundtransfer", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@beneAccNoPara", beneAccNum);
                cmd.Parameters.AddWithValue("@beneAmountPara", beneAccBal);
                cmd.Parameters.AddWithValue("@senderAccNoPara", senderAccNum);
                cmd.Parameters.AddWithValue("@senderAmountPara", senderAccBal);
                int numOfRows = cmd.ExecuteNonQuery();

                if (numOfRows > 0)
                    return true;

                return false;
            }
        }
    }
}
