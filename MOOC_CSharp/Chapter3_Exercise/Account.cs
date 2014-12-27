using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3_Exercise
{
	public class Account
	{
		private double money; //decimal money;
		private string id;
		private string pwd;
		//string name;

		public Account() 
		{
			
		}

		public Account(string id, string pwd, double money)
		{
			this.id = id;
			this.pwd = pwd;
			this.money = money;
		}

		public double getMoney()
		{
			return money;
		}

		public void setMoney(double val)
		{
			this.money = val;
		}

		public string getId()
		{
			return id;
		}

		public void setId(string id)
		{
			this.id = id;
		}

		public string getPwd()
		{
			return pwd;
		}

		public void setPwd(string pwd)
		{
			this.pwd = pwd;
		}

		public bool SaveMoney(double money)
		{
			if (money < 0) return false; //卫语句

			this.money += money;
			return true;
		}

		public bool WithdrawMoney(double money)
		{
			if (this.money >= money)
			{
				this.money -= money;
				return true;
			}

			return false;
		}

		public bool IsMatch(string id, string pwd)
		{
			return id == this.id && pwd == this.pwd;
		}
	}
}