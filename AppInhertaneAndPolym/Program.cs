using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInheritanceAndPolym
{
	class Program
	{
		static void Main(string[] args)
		{
			CheckingAcct myChkAccount = new CheckingAcct(1000);
			Console.WriteLine("Initiate Witdrawal of $250");
			myChkAccount.Withdrawal(250);
			Console.ReadLine();

			Console.WriteLine("Initiate Witdrawal of $850");
			myChkAccount.Withdrawal(850);
			Console.ReadLine();
		}



	}
}
