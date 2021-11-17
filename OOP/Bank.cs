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

		
		
		private static void IncreeseId()
		{
			id++;
		}
	
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
			return $"номер счета  {GetNumberCounting()}{enter}баланс {Balans}{enter}тип {Type}";
		}

	}

}
