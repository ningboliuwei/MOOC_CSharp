using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace Chapter2_Exercise
{
	public partial class CaculationTest : Form
	{
		public CaculationTest()
		{
			InitializeComponent();
		}

		private void btnNextQuestion_Click(object sender, EventArgs e)
		{
			GenerateQuestion();
		}

		/// <summary>
		/// 生成一道新的题目
		/// </summary>
		private void GenerateQuestion()
		{
			int x;
			int y;
			int ceiling = 0;
			int op;
			string opStr = "";
			int result = 0;

			Random rnd = new Random();

			if (rbnMulitply.Checked)
			{
				ceiling = 11;
				op = 3;
			}
			else
			{
				if (rbn10.Checked)
				{
					ceiling = 11;
				}
				else if (rbn20.Checked)
				{
					ceiling = 21;
				}

				op = rnd.Next(2) + 1;
			}

			x = rnd.Next(ceiling);
			y = rnd.Next(ceiling);

			switch (op)
			{
				case 1:
					opStr = "+";
					result = x + y;
					break;
				case 2:
					opStr = "-";
					result = x - y;
					break;
				case 3:
					opStr = "×";
					result = x*y;
					break;
			}

			lblQuestion.Text = string.Format("{0} {1} {2}", x.ToString(), opStr, y.ToString());
			//将正确答案作为 Label 控件的 Tag 属性保存起来（在判断用户是否答对的时候使用）
			lblQuestion.Tag = result;
			

		}

		private void btnFaster_Click(object sender, EventArgs e)
		{
			//Timer 的时间间隔减少 1 秒
			if (tmrAutoNext.Interval >= 2000)
			{
				tmrAutoNext.Interval -= 1000;
			}
		}

		private void btnSlower_Click(object sender, EventArgs e)
		{
			//Timer 的时间间隔增加 1 秒
			tmrAutoNext.Interval += 1000;
		}

		private void tmrAutoNext_Tick(object sender, EventArgs e)
		{
			GenerateQuestion();
		}

		private void chkAutoNext_CheckedChanged(object sender, EventArgs e)
		{
			tmrAutoNext.Enabled = chkAutoNext.Checked;
		}
	}
}