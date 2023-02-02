using System;
using System.Data.SqlClient;
using System.Configuration;

namespace Banking.DataBase
{

    public class DBConnection
    {
        //static string connectionstr= "Data Source = EHILP-340; Initial Catalog = BankingApp; Integrated Security = True";
        static string connectionstr = ConfigurationManager.ConnectionStrings["connectionstr"].ConnectionString;
        private DBConnection() { }

        static SqlConnection con = new SqlConnection(connectionstr);
        public static SqlConnection GetConnection()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con = new SqlConnection(connectionstr);
                con.Open();
            }
            return con;
        }

    }
}
