namespace Banking.Business
{
	public class WithdrawEnum
	{
		public enum WithdrawCodes
		{
			InvalidAmount,
			LowAccountBalance,
			ExceedsPerDayLimit,
			Success
		}
	}
}
