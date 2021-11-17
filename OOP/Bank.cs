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
		private static int id;
		private int NumberCounting;
		private decimal Balans;
		private CountingType Type;

		public Bank(decimal balans)
		{
			Balans = balans;
			IncreeseId();
			NumberCounting = id;
		}
		public Bank(CountingType type)
		{
			Type = type;
			IncreeseId();
			NumberCounting = id;

		}
		public Bank(decimal balans, CountingType type)
		{
			Balans = balans;
			Type = type;
			IncreeseId();
			NumberCounting = id;
		}

		private static void IncreeseId()
		{
			id++;
		}
	
		public decimal GetBalans()
		{
			return Balans;
		}
		public CountingType GetType()
		{
			return Type;
		}
		public int GetNumberCounting()
		{
			if (NumberCounting==default)
			{
				IncreeseId();
				NumberCounting = id;
			}
			return NumberCounting;
		}
		public override string ToString()
		{
			var enter = Environment.NewLine;
			return $"номер счета  {NumberCounting}{enter}баланс {Balans}{enter}тип {Type}";
		}

	}

}
