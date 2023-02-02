using System.Data;
using System.Data.SqlClient;

namespace Banking.DataBase
{
    public class FetchingData
    {
        public static string GetCustomerName(int cusId)
        {
            return QueryOptimizer.ExecuteScalarFunc("spcustomername", "@cusIdPara", cusId).ToString();
        }

        //returns the CustomerId
        public int ValidateCustomerId(int cusId)
        {
            return int.Parse(QueryOptimizer.ExecuteScalarFunc("spcustomer", "@cusIdPara", cusId).ToString());
        }

        //returns Customer's password
        public int ValidateCustomerPassword(string password)
        {
            return int.Parse(QueryOptimizer.ExecuteScalarFunc("sppassword", "@PassPara", password).ToString());
        }

        //returns datatable of customer's accounts and respective balances
        public DataTable GetAccountDetails(int cusId)
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("spaccountdetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CusIdPara", cusId);

                using (SqlDataReader dataReader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("AccountNo", typeof(System.Int32));
                    dt.Columns.Add("BalanceAmount", typeof(System.Double));
                    dt.Columns.Add("AccountType", typeof(System.String));

                    while (dataReader.Read())
                    {
                        DataRow dr = dt.NewRow();
                        dr["AccountNo"] = dataReader["AccountNo"];
                        dr["BalanceAmount"] = dataReader["BalanceAmount"];
                        dr["AccountType"] = dataReader["AccountType"];
                        dt.Rows.Add(dr);
                    }
                    return dt;
                }
            }
        }

        public static DataTable GetMiniStatement(int accountNum)
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("spministatement", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@accNoPara", accountNum);

                using (SqlDataReader dataReader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Date", typeof(System.DateTime));
                    dt.Columns.Add("AccountNo", typeof(System.Int32));
                    dt.Columns.Add("Transaction", typeof(System.String));
                    dt.Columns.Add("Amount", typeof(System.Double));
                    dt.Columns.Add("Balance", typeof(System.Double));

                    while (dataReader.Read())
                    {
                        DataRow dr = dt.NewRow();
                        dr["Date"] = dataReader["Date"];
                        dr["AccountNo"] = dataReader["AccountNo"];
                        dr["Transaction"] = dataReader["Transaction"];
                        dr["Amount"] = dataReader["Amount"];
                        dr["Balance"] = dataReader["Balance"];
                        dt.Rows.Add(dr);
                    }
                    return dt;
                }
            }
        }

        public string GetAccountType(int accountNum)
        {
            return QueryOptimizer.ExecuteScalarFunc("spaccounttype", "@accNumPara", accountNum).ToString();
        }

        public static double GetAccountBalance(int accountNum)
        {
            return double.Parse(QueryOptimizer.ExecuteScalarFunc("spaccountbalance", "@accNumPara", accountNum).ToString());
        }

        public static int ValidateAccountNumber(int accountNum)
        {
            return int.Parse(QueryOptimizer.ExecuteScalarFunc("spaccountno", "@accNoPara", accountNum).ToString());
        }

        public static double GetTodayWithdrawedAmount(int accountNum)
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sptrackeramount", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@accNopara", accountNum);
                //cmd.Parameters.AddWithValue("@datePara", date);
                return double.Parse(cmd.ExecuteScalar().ToString());
            }
        }


        public static DataTable GetFDRates()
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("select * from FixedDepositRates", con);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                return dt;
            }
        }

        public static DataTable GetRDRates()
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("select * from RecurringDepositRates", con);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                return dt;
            }
        }

        public static string GetInterestRate(string accType)
		{
            return QueryOptimizer.ExecuteScalarFunc("GetInterestRate", "@accTypePara", accType).ToString();
        }

        public static string GetMinimumBal(string accType)
        {
            return QueryOptimizer.ExecuteScalarFunc("GetMinimumBalanceSP", "@accTypePara", accType).ToString();
        }

        public static int GetWithdrawLimit(string accType)
		{
            return int.Parse(QueryOptimizer.ExecuteScalarFunc("Get_WithdrawLimit_SP", "@accTypePara", accType).ToString());
        }
    }
}
