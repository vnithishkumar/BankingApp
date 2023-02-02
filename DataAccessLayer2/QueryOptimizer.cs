using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
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

		public static SqlDataReader ExecuteReaderFunc(string spName, string queryParameter, dynamic queryParaValue)
		{

			using (SqlConnection con = DBConnection.GetConnection())
			{
				SqlCommand cmd = new SqlCommand(spName, con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue(queryParameter, queryParaValue);
				return cmd.ExecuteReader();
			}
		}
	}
}
