#region

using System;

#endregion

namespace Chapter3_Exercise
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Bank bank = new Bank();

			//普通账户额度都为 0
			bank.OpenAccount("Jack", "123", Bank.AccountType.NormalAccount, 0);
			bank["Jack"].SaveMoney(1000);

			bank.OpenAccount("Tom", "321", Bank.AccountType.CreditCardAccount, 10000);

			bank.OpenAccount("Jane", "246", Bank.AccountType.CreditCardAccount, 5000);
			bank["Jane"].SaveMoney(2000);

			ATM atm = new ATM(bank);

			ATM.ExitType result;
			do
			{
				result = atm.Transaction();
			} while (result != ATM.ExitType.ExitByUser);

			Console.ReadLine();
		}
	}
}