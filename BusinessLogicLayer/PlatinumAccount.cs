using System;
using System.Collections.Generic;
using System.Text;
using Banking.DataBase;

namespace Banking.Business
{
    class PlatinumAccount : Account
    {
        public PlatinumAccount()
        {
            InterestPercentage = int.Parse(FetchingData.GetInterestRate("Platinum"));
        }

        public override string Benefits()
        {
            return "The Benefits are : cashback on card payments";
        }

        public override string Loan()
        {
            return "Eligible for Loan amount of 10000rs";
        }

        public override string MinimumBalance()
        {
            string miniBal = "Minimum Balance for your Account = " + FetchingData.GetMinimumBal("Platinum") + "rs";
            return miniBal;
        }

       
    }
}
