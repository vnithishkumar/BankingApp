using Banking.DataBase;

namespace Banking.Business
{
	public class AccountDetails
    {
        static public int GetAccountLimit(int accountNo)
        {
            //getting account type from database
            FetchingData fetchObj = new FetchingData();
            string accountType = fetchObj.GetAccountType(accountNo);
            return FetchingData.GetWithdrawLimit(accountType);
        }
        public static bool CheckAccountNo(int accountNum)
        {
            int result = FetchingData.ValidateAccountNumber(accountNum);
            if (result == 1)
                return true;
            return false;
        }
        public static double CheckAccountBalance(int accountNum)
        {
            return FetchingData.GetAccountBalance(accountNum);
        }
       
    }
}


















////setting the account limit
//if (accountType == AccountTypeEnum.AccountTypes.Normal.ToString())
//{
//    NormalAccount na = new NormalAccount();
//    limit = na.GetWithdrawalLimit();
//}
//else if (accountType == AccountTypeEnum.AccountTypes.Gold.ToString())
//{
//    GoldAccount ga = new GoldAccount();
//    limit = ga.GetWithdrawalLimit();
//}
//else if (accountType == AccountTypeEnum.AccountTypes.Platinum.ToString())
//{
//    PlatinumAccount pa = new PlatinumAccount();
//    limit = pa.GetWithdrawalLimit();
//}
//return limit;