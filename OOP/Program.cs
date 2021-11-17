using System;

namespace OOP
{
	class Program
	{
		static void Main(string[] args)
		{
			Bank bank = new Bank();
			bank.SetBalans(1);
			bank.SetType(CountingType.fiz);
			bank.SetNumberCounting(2);
			Console.WriteLine(bank.ToString());
;
		}
	}
}
