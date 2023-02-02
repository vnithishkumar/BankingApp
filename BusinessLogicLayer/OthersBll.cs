using Banking.DataBase;
namespace Banking.Business
{
    public class OthersBll
    {
        public static Account GetClassObj(string accountType)
        {
            switch (accountType)
            {
                case "Normal":
                    {
                        return new NormalAccount();
                    }
                case "Gold":
                    {
                        return new GoldAccount();
                    }
                case "Platinum":
                    {
                        return new PlatinumAccount();
                    }
				default:
                    return new Account();
            }
        }
        public static string DisplayBenfits(int accountNo)
        {
            FetchingData fetchObj = new FetchingData();
            string accountType = fetchObj.GetAccountType(accountNo);
            var obj = OthersBll.GetClassObj(accountType);
            return obj.Benefits();
        }

        public static string DisplayMinimumBal(int accountNo)
        {
            FetchingData fetchObj = new FetchingData();
            string accountType = fetchObj.GetAccountType(accountNo);
            var obj = OthersBll.GetClassObj(accountType);
            return obj.MinimumBalance();
        }

        public static string DisplayLoan(int accountNo)
        {
            FetchingData fetchObj = new FetchingData();
            string accountType = fetchObj.GetAccountType(accountNo);
            var obj = OthersBll.GetClassObj(accountType);
            return obj.Loan();
        }


    }
}
