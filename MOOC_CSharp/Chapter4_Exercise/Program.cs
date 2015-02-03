using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter4_Exercise
{
	class Program
	{
		private static void Main(string[] args)
		{
			Bank bank = new Bank();

			//普通账户额度都为 0
			bank.OpenAccount("Jack", "123", Bank.AccountType.NormalAccount, 0);
			bank["Jack"].SaveMoney(20000);

			bank.OpenAccount("Tom", "321", Bank.AccountType.CreditCardAccount, 10000);

			bank.OpenAccount("Jane", "246", Bank.AccountType.CreditCardAccount, 5000);
			bank["Jane"].SaveMoney(2000);


			//本程序需要一次取出超过10000的金额（以实现事件）
			ATM atm = new ATM(bank);

			ATM.ExitType result;

			try
			{
				do
				{
					result = atm.Transaction();
				} while (result != ATM.ExitType.ExitByUser);
			}
			catch (BadCashException e)
			{
				Console.WriteLine( e.Message + " Please contact us!");
			}
			Console.ReadLine();
		}
	}
}
