using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInheritanceAndPolym
{
	/// <summary>
	/// Polymorphism Implementation
	/// </summary>

	class Program
	{
		static void Main(string[] args)
		{
			Account myAccount;
			myAccount = new CheckingAcct(1000);
			myAccount.Withdrawal(500);
			Console.WriteLine(myAccount.GetType());
			myAccount.AccountNumber = "456789";


			myAccount = new SavingsAcct(2000, 0);
			myAccount.Withdrawal(1500);
			myAccount.Deposit(500);

			SavingsAcct mySav = new SavingsAcct(1000, 2);
			mySav.IntRate = 10;
			mySav.ProcessProfit();
			Console.WriteLine("Balance after process interest " + mySav.Balance);


			Console.WriteLine(myAccount.Balance);

			Console.WriteLine(myAccount.GetType());




			Console.ReadLine();
		}



	}
}
