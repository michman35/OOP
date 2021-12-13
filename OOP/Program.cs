using System;
using static OOP.Bank;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP;


namespace OOP
{		
	class Program
	{
		static void Main(string[] args)
		{
			ConsoleMessage message = new ConsoleMessage();
			
			Bank bank = new Bank();
			bank.AccountNumber = 132123;
			bank.Account = 43424;

			Bank bank2 = new Bank();			
			bank2.AccountNumber = 654611;			
			bank2.Account = 4342;

			bank.Messages();
			bool result = bank.AccountNumber != bank2.AccountNumber;
			bool result2 = bank.Account == bank2.Account;
			message.Info($" номера счетов: {result}, Сравн количества денег на счете: {result2}");

		}

	
	}
}

