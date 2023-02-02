using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Business
{
    public class Account:ILoan
    {
        private int _interestPercentage;

        private int _withdrawalLimit;
        public int InterestPercentage { get => _interestPercentage; set => _interestPercentage = value; }
        public int WithdrawalLimit { get => _withdrawalLimit; set => _withdrawalLimit = value; }

        public int GetInterestRate()
        {
            return InterestPercentage;
        }
        public virtual string Loan()
        {
            return "Loan is available based on acc type";
        }
        public virtual string Benefits()
        {
            return "there are benefits for all account types";
        }
        public virtual string MinimumBalance()
        {
            return "Minimum Balance for an account should be 500 or more";
        }  
    }
}
