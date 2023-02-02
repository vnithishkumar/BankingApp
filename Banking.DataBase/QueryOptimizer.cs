using System.Data;
using System.Data.SqlClient;

namespace Banking.DataBase
{
	class QueryOptimizer
	{
		public static object ExecuteScalarFunc(string spName, string queryParameter, dynamic queryParaValue)
		{
			using (SqlConnection con = DBConnection.GetConnection())
			{
				SqlCommand cmd = new SqlCommand(spName, con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue(queryParameter, queryParaValue);
				return cmd.ExecuteScalar();
			}
		}

		public static bool ExecuteNonQueryFunc(string spname, string queryParameter1, dynamic queryParaValue1, string queryParameter2, dynamic queryParaValue2)
		{
			using (SqlConnection con = DBConnection.GetConnection())
			{
				SqlCommand cmd = new SqlCommand(spname, con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue(queryParameter1, queryParaValue1);
				cmd.Parameters.AddWithValue(queryParameter2, queryParaValue2);
				int numOfRows = cmd.ExecuteNonQuery();

				if (numOfRows > 0)
					return true;

				return false;
			}
		}
	}
}
















//public static SqlDataReader ExecuteReaderFunc(string spName, string queryParameter, dynamic queryParaValue)
//{
//	SqlConnection con = DBConnection.GetConnection();
//	SqlCommand cmd = new SqlCommand(spName, con);
//	cmd.CommandType = CommandType.StoredProcedure;
//	cmd.Parameters.AddWithValue(queryParameter, queryParaValue);
//	return cmd.ExecuteReader();
//}