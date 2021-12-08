using System;

namespace OOP
{
	

	
	class Program
	{
		static void Main(string[] args)
		{
			var s1 = new Number(1, 2);
			var s2 = new Number(2, 1);

		
			int q = (int)s1;
			float qq = (float)s2;

			Console.WriteLine(s1 == s2);
		}

		
	}
}
