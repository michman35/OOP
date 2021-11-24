using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	public enum CountingType
	{
		fiz,
		ur,
	}
	class Bank
	{
		
		private int NumberCounting;
		private decimal Balans;
		private CountingType Type;

	
		public decimal GetBalans()
		{
			return Balans;
		}
		public void SetBalans(decimal balans)
		{
			Balans = balans;
		}
		public CountingType GetType()
		{
			return Type;
		}
		public void SetType(CountingType type)
		{
			Type = type;
		}
		public int GetNumberCounting()
		{
			
			return NumberCounting;
		}
		public void SetNumberCounting(int numberCounting)
		{
			NumberCounting = numberCounting;
		}
		public override string ToString()
		{
			var enter = Environment.NewLine;
			return $"номер счета  {GetNumberCounting()}{enter}баланс {Balans}";
		}

		public void Transfer(Bank bank, int summ)
		{
			Console.WriteLine($"На счете 868979 осталось: { this.Balans -= summ}$");
			Console.WriteLine($"Стало на счете 34355  : { bank.Balans += summ}$");
		}

	}

}
