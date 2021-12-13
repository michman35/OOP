using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP;
using static System.Formats.Asn1.AsnWriter;
using static OOP.Bank;

namespace OOP
{

    class Bank
    {
		internal int AccountNumber;
		internal int Account;

		public class BankAccount
        {
            private int _accountNumber;
            private int _account;
            public int AccountNumber
            {
                get { return _accountNumber; }
                set
                {
                    if(value < 0)
                        throw new Exception("не существует");
                    else
                        _accountNumber = value;
                }
            }
            public int Account
            {
                get { return _account; }
                set
                {
                    if(value < 0)
                        throw new Exception("в банке ");
                    else
                        _account = value;
                }
            }
            //переопределение операторов 
            public static bool operator ==(BankAccount s1, BankAccount s2)
            {
                return s1.AccountNumber == s2.AccountNumber && s1.Account == s2.Account;
            }
            public static bool operator !=(BankAccount s1, BankAccount s2)
            {
                return s1.AccountNumber != s2.AccountNumber && s1.Account != s2.Account;
            }
            public override bool Equals(object? obj)
            {
                return base.Equals(obj);
            }
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
            public override string ToString()
            {
                return $"Сравниваем счета ";
            }
            public void Messages()
            {
                ConsoleMessage message = new ConsoleMessage();
                message.Info(ToString());
            }
        }

		internal void Messages()
		{
			throw new NotImplementedException();
		}

		public abstract class Message
        {
            public abstract void Info(string message);
        }
        public sealed class ConsoleMessage : Message
        {
            public override void Info(string message)
            {
                Console.WriteLine(message);
            }
        }
    }



}
    


