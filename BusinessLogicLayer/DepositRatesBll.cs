using Banking.DataBase;
using System.Data;

namespace Banking.Business
{
    public class DepositRatesBll
    {
        public static DataTable FillFDTable()
        {
            return FetchingData.GetFDRates();
        }
        public static DataTable FillRDTable()
        {
            return FetchingData.GetRDRates();
        }
    }
}
