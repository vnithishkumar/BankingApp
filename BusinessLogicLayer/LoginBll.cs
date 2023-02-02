using Banking.DataBase;

namespace Banking.Business
{
	public class LoginBll
    {
        
        public string ValidateCredentials(int customerId, string password)
        {
            
            int cusId = customerId;

            //creating object for data access layer -> fetchingData class
            FetchingData dal = new FetchingData();

            int cusDbVal = dal.ValidateCustomerId(cusId); //returns 1 -> found, 0 -> not found

            if (cusDbVal == 1)
            {
                int pwdDbVal = dal.ValidateCustomerPassword(password);  //returns 1 -> found, 0 -> not found
                if (pwdDbVal == 0)
                    return "Wrong Password";
            }
            else
			{
                return "Wrong Customer Id";
			}
            return "success";
        }
    }
}
