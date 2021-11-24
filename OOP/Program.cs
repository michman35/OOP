using System;

namespace OOP
{
	class Program
	{
		static void Main(string[] args)
		{ //1 задание
			Bank bank = new Bank();
			bank.SetBalans(200);
			bank.SetNumberCounting(868979);

			Bank bank1 = new Bank();
			bank1.SetBalans(350);
			bank1.SetNumberCounting(34355);

			bank.Transfer(bank1, 50);// снятие со счета 

			// 2 здание 
			Console.WriteLine("partizan");
			string name = "partizan";

			for(int i = name.Length - 1; i >= 0; i--)
			{
				Console.Write(name[i]);
			}
		}
	}
}
