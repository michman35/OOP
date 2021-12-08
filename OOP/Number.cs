using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	class Number
	{
		public int Numerator { get; set; }
		public int Denominator { get;}

		public Number(int numerator,int denominator)
		{
			Numerator = numerator;
			Denominator = denominator;			
		}

		public static bool operator ==(Number s1, Number s2)
		{
			return s1.Equals(s2);
		}

		public static bool operator !=(Number s1, Number s2)
		{
			return !s1.Equals(s2);
		}
		public static bool operator >(Number s1, Number s2 )
		{
			return s1.Numerator > s2.Numerator && s1.Denominator > s2.Denominator;
		}
		public static bool operator <(Number s1, Number s2)
		{
			return s1.Numerator < s2.Numerator && s1.Denominator < s2.Denominator;
		}

		public static bool operator <=(Number s1,Number s2)
		{
			return s1.Numerator <= s2.Numerator && s1.Denominator <= s2.Denominator;
		}
	
		public static bool operator >=(Number s1, Number s2)
		{
			return s1.Numerator >= s2.Numerator && s1.Denominator >= s2.Denominator;
		}

		public static Number operator ++(Number s1)
		{
			s1.Numerator += s1.Numerator;
			return s1;
		}
		public static Number operator --(Number s1)
		{
			s1.Numerator -= s1.Numerator;
			return s1;
		}

		public static explicit operator float(Number number)
		{
			return float.Parse(number.ToString());
		}

		public static explicit operator int(Number number)
		{
			return number.Numerator;
		}

		public override bool Equals(object obj)
		{
			var s2 = (Number)obj;
			if(s2 == null) 
			{
				return base.Equals(obj);
			}

			return Numerator == s2.Numerator && Denominator == s2.Denominator;		
		}

		public override string ToString()
		{
			return $@"{Numerator},{Denominator}";
		}

	}
}