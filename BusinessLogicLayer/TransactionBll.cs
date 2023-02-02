using System;
using Banking.DataBase;

namespace Banking.Business
{
	public class TransactionBll
    {
        public WithdrawEnum.WithdrawCodes Withdrawal(double withdrawAmount, int accountNum)
        {
            if (withdrawAmount < 1)
                return WithdrawEnum.WithdrawCodes.InvalidAmount;
            //getting account balance from DB 
            double availableAccBal = FetchingData.GetAccountBalance(accountNum);

            //checking account withdraw Maximum limit
            int perDayLimit = AccountDetails.GetAccountLimit(accountNum);

            //getting DB Tracker Amount
            double amountWithdrawedForTheDay = FetchingData.GetTodayWithdrawedAmount(accountNum);

            //(checking if withdrawal amount is less than available balance) then checking (withdrawal limit + trackeramount is less than Maximum withdrawal limit)
            if (withdrawAmount <= availableAccBal)
            {
                if ((withdrawAmount + amountWithdrawedForTheDay) <= perDayLimit)
                {
                    //update DB in Account table
                    Withdraw withdrawObj = new Withdraw();
                    withdrawObj.WithdrawFromAcc(withdrawAmount, accountNum);
                    withdrawObj.UpdateWithdrawTracker(accountNum, withdrawAmount);
                }
				else
				{
                    return WithdrawEnum.WithdrawCodes.ExceedsPerDayLimit;
                }
            }
            else
			{
                return WithdrawEnum.WithdrawCodes.LowAccountBalance;
            }
            return WithdrawEnum.WithdrawCodes.Success;
        }
        

        public bool DepositAmount(double amount, int accountNum)
        {
            return Deposit.DepositToAcc(amount, accountNum);
        }

        public string FundTransfer(double amount, int beneAccNum, int senderAccNum)
        {
            double senderBal = FetchingData.GetAccountBalance(senderAccNum);
            
            bool status;
            if (FetchingData.ValidateAccountNumber(beneAccNum) == 0)
            {
                return "Beneficiary Account Not Found! Retry.";
            }
            else if(amount > senderBal)
            {
                return "Amount Exceeds Account Balance!";
            }
            else
            {
                FundTransfer ftObj = new FundTransfer();
                status = ftObj.FundTransferFunc(beneAccNum, senderAccNum, amount);
            }
            if (status)
                return "Amount Transferred Successfully!";
            return "something went wrong";
        }
    }
}







/*
        //Mainitaining a dictionary to track withdrawal limit per day
        public Dictionary<int, double> withdrawTracker = new Dictionary<int, double>()
        {
            {23456712, 0},
            {34567123, 0},
            {23145679, 0},
            {98765231, 0},
            {45678123, 0},
            {23417894, 0},
            {76438923, 0},
            {67543271, 0},
            {32156782, 0},
            {54378912, 0},
        };

        
        public bool Withdrawal2(double amount, int accountNum)
        {
            double withdrawAmount = amount;
            int accountNo = accountNum;
            //getting balance from DB 
            double accountBalance = FetchingData.GetAccountBalance(accountNo);
            bool updated = false;

            //check account withdraw limit
            int limit = AccountDetails.GetAccountLimit(accountNo);

            if (withdrawAmount <= accountBalance && (withdrawAmount + withdrawTracker[accountNo]) <= limit)
            {
                withdrawTracker[accountNo] += Math.Round(withdrawAmount,2);
                accountBalance -= Math.Round(withdrawAmount,2);

                //updating the account table in DB
                WithdrawDal withdrawObj = new WithdrawDal();
                updated = withdrawObj.WithdrawFromAcc(accountBalance, accountNo);
            }

            if(updated)
            {
                return true;
            }

            return false;
        }
        */