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
	abstract class Account
	{
		public string AccountNumber { get; set; }
		public decimal Balance { get; set; }

		//Set wour account balannce, initial balance value before using constructor
		public Account(decimal initialBalance)
		{
			Balance = initialBalance;
		}

		public void Deposit(decimal amount)
		{
			Balance += amount;
		}

		// child class can impleme t its own Withdrawal
		public abstract Transactions Withdrawal(decimal amount);
	}
}
