using System;
using System.Collections.Generic;
using System.Text;
using Banking.DataBase;

namespace Banking.Business
{
    class NormalAccount : Account
    {
        public NormalAccount()
        {
            InterestPercentage = int.Parse(FetchingData.GetInterestRate("Normal"));
        }

        public override string Benefits()
        {
            return "The Benefits are : Debit card option is available";
        }

        public override string Loan()
        {
            return "Not Eligible for loan. Need Approval";
        }

        public override string MinimumBalance()
        {
            string miniBal = "Minimum Balance for your Account = " + FetchingData.GetMinimumBal("Normal") + "rs";
            return miniBal;
        }

        
    }

}

