using System.Data;
using Banking.DataBase;


namespace Banking.Business
{
	public class DisplayAccountDetailsBll
    {
        public DataTable DisplayCustomerAccounts(int cusId)
        {
            //creating business layer obj
            FetchingData fd = new FetchingData();

            DataTable dt = fd.GetAccountDetails(cusId);

            return dt;
        }
    }
}
