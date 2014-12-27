using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3_Exercise
{
	class CreditCardAccount:Account
	{
		//额度
		public double limit;
		//积分
		public long score;

		public CreditCardAccount(string id, string pwd, double money, double limit) : base()
		{
			this.limit = limit;
		}

		/// <summary>
		/// 改变信用卡额度
		/// </summary>
		/// <param name="limit">新的额度</param>
		public void SetCreditLimit(double limit)
		{
			this.limit = limit;
		}
	}
}

