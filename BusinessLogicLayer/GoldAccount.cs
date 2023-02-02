using System;
using System.Collections.Generic;
using System.Text;
using Banking.DataBase;

namespace Banking.Business
{
    class GoldAccount : Account
    {
        public GoldAccount()
        {
            InterestPercentage = int.Parse(FetchingData.GetInterestRate("Normal"));
        }
        public override string Benefits()
        {
            
            return "The Benefits are : Debit card & cerdit card option are available";
            
        }
        public override string Loan()
        {

            return "Eligible for Loan amount of 5000rs";
            
        }
        public override string MinimumBalance()
        {
            string miniBal = "Minimum Balance for your Account = " + FetchingData.GetMinimumBal("Gold") + "rs";
            return miniBal;
        }

        
    }
}
