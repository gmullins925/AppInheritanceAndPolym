using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInheritanceAndPolym
{
	/// <summary>
	///  Inheritance
	///  Parent Class
	/// </summary>
	
	class CheckingAcct : Account //establishing parent class attributes
	{
		public CheckingAcct(decimal initialBalance) : base(initialBalance)
		{

		}
		public override Transactions Withdrawal(decimal amount)
		{
			//create Transaction Object
			Transactions thisTransaction = new Transactions();
			thisTransaction.AccountNumber = AccountNumber;  //AccountNumber (right side) pulling from parent class above
			thisTransaction.Amount = amount;
			thisTransaction.isSuccessful = false;
			thisTransaction.TimeStamp = DateTime.Now;


			if (amount > Balance)
			{
				thisTransaction.Detail = "Transaction Failed: Insufficient Funds";
				Console.WriteLine("Transaction Failed: Insufficient Funds");
				Console.WriteLine("Your current balance: $"+Balance);
			}
			else
			{
				Balance -= amount; //Balance = Balance - amount
				thisTransaction.isSuccessful = true;
				thisTransaction.Detail = String.Format("Account Number: {0} was debited{1}", thisTransaction.AccountNumber, thisTransaction.Amount);
				Console.WriteLine(thisTransaction.Detail);
				Console.WriteLine("Successfully withdrew from " + thisTransaction.AccountNumber + " debited amount " + thisTransaction.Amount);
			}

			return thisTransaction;
		}
	}
}
