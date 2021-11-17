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
		private int NumberCounting => id;
		private decimal Balans { get; set; }
		private CountingType Type { get; set; }

		public Bank(decimal balans)
		{
			Balans = balans;
			IncreeseId();
		}
		public Bank(CountingType type)
		{
			Type = type;
			IncreeseId();
				
		}
		public Bank(decimal balans, CountingType type)
		{
			Balans = balans;
			Type = type;
			IncreeseId();
		}

		private static void IncreeseId()
		{
			id++;
		}
	
		

		public override string ToString()
		{
			var enter = Environment.NewLine;
			return $"номер счета  {NumberCounting}{enter}баланс {Balans}{enter}тип {Type}";
		}

	}

}
