using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter4_Exercise
{
	public class BigMoneyFetchedEventArgs
	{
		/// <summary>
		/// 大额提款的账户
		/// </summary>
		public Account SourceAccount { get; set; }

		/// <summary>
		/// 提取的数额
		/// </summary>
		public double WithdrawAmount { get; set; }

		public BigMoneyFetchedEventArgs(Account sourceAccount, double withdrawAmount)
		{
			SourceAccount = sourceAccount;
			WithdrawAmount = withdrawAmount;
		}

	}
}
