#region

using System;
using Chapter3_Exercise;

#endregion

namespace Chapter4_Exercise
{
	public class ATM
	{
		public enum ExitType
		{
			InvalidCardOrPassword,
			ExitByUser
		}

		/// <summary>
		/// 声明事件委托
		/// </summary>
		/// <param name="obj"></param>
		/// <param name="args"></param>
		public delegate void BigMoneyFetchedEventHandler(object obj, BigMoneyFetchedEventArgs args);

		/// <summary>
		/// 声明事件
		/// </summary>
		public event BigMoneyFetchedEventHandler BigMoneyFetched;

		private Bank bank;

		public ATM(Bank bank)
		{
			this.bank = bank;

			//注册事件
			this.BigMoneyFetched += ATM_BigMoneyFetched;
		}

		void ATM_BigMoneyFetched(object obj, BigMoneyFetchedEventArgs args)
		{
			//输出事件信息
			Console.WriteLine(string.Format("Warnning! {0} from {1} is withdrawed!", args.WithdrawAmount, args.SourceAccount));
		}

		public ExitType Transaction()
		{
			Show("please insert your card");
			string id = GetInput();

			Show("please enter your password");
			string pwd = GetInput();

			Account account = bank.FindAccount(id, pwd);

			if (account == null)
			{
				Show("card invalid or password not corrent");
				return ExitType.InvalidCardOrPassword;
			}


			string op = "";

			//此处进行了改进，除非用户选择 exit，否则不退出选单
			while (op != "4")
			{
				Show("1: display; 2: save; 3: withdraw; 4: exit");
				op = GetInput();
				if (op == "1")
				{
					Show("balance: " + account.getMoney());
				}
				else if (op == "2")
				{
					Show("save money");
					string smoney = GetInput();
					double money = double.Parse(smoney);

					bool ok = account.SaveMoney(money);
					if (ok) Show("ok");
					else Show("eeer");

					Show("balance: " + account.getMoney());
				}
				else if (op == "3")
				{
					Show("withdraw money");
					string smoney = GetInput();
					double money = double.Parse(smoney);

					bool ok = account.WithdrawMoney(money);
					if (ok) Show("ok");
					else Show("eeer");

					Show("balance: " + account.getMoney());

					if (money >= 10000)
					{
						if (BigMoneyFetched != null)
						{
							BigMoneyFetched(this, new BigMoneyFetchedEventArgs());
						}
					}
				}
			}
			return ExitType.ExitByUser;
		}


		public void Show(string msg)
		{
			Console.WriteLine(msg);
		}

		public string GetInput()
		{
			return Console.ReadLine(); // ÊäÈë×Ö·û
		}
	}
}