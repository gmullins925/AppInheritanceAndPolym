using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInheritanceAndPolym
{
	class SavingsAcct:Account
	{
		private const int MONTHLY_WITHDRAWAL_LIMIT = 5;
		public decimal IntRate { get; set; }
		public int WithdrawalsThisMonth { get; set; }

		// Set initial balance
		public SavingsAcct(decimal initialBalance, int monthlyWithdrawals) : base(initialBalance)
		{
			WithdrawalsThisMonth = monthlyWithdrawals;
		}

		public override Transactions Withdrawal(decimal amount)
		{
			Transactions thisTransaction = new Transactions();
			this.AccountNumber = AccountNumber;
			thisTransaction.Amount = amount;
			thisTransaction.TimeStamp = DateTime.Now;
			thisTransaction.isSuccessful = false;

			//perform withdrawal

			if (amount > Balance)
			{
				thisTransaction.Detail = "Transaction Failed: Insufficient Funds";
				Console.WriteLine("Transaction Failed: Insufficient Funds");
				Console.WriteLine("Your current balance: $" + Balance);
			}
			else if (WithdrawalsThisMonth >= MONTHLY_WITHDRAWAL_LIMIT)
			{
				thisTransaction.Detail = "Transaction Failed: Exceeds Allowed Number of Withdrawals";
				Console.WriteLine("Transaction Failed: Exceeds Allowed Number of Withdrawals");
			}
			else
			{
				Balance -= amount; //Balance = Balance - amount
				thisTransaction.isSuccessful = true;
				thisTransaction.Detail = String.Format("Account#: {0} was debited{1}", thisTransaction.AccountNumber, thisTransaction.Amount);
				Console.WriteLine("Successfully withdrew from " + thisTransaction.AccountNumber + " debited amount " + thisTransaction.Amount);
			}

			return thisTransaction;
		}

		public void ProcessProfit()
		{
			Balance += Balance * (IntRate/100);
		}

		
	}
}
