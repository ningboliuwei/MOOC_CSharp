#region

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Game2048;

#endregion

namespace Chapter7_Exercise
{
	public partial class frmPad : Form
	{
		private Form1 frmMain;

		public frmPad()
		{
		}

		public frmPad(Form1 frm)
		{
			InitializeComponent();

			Load += frmPad_Load;
			Closing += frmPad_Closing;
			frmMain = frm;
		}

		private void frmPad_Closing(object sender, CancelEventArgs e)
		{
			frmMain.虚拟按键模式VToolStripMenuItem.Checked = false;
		}

		private void frmPad_Load(object sender, EventArgs e)
		{
			Width = 250;
			Height = SystemInformation.CaptionHeight + 250;
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Left = frmMain.Left + frmMain.Width;
			Top = frmMain.Top + frmMain.Height - Height;
			//不在任务栏中显示
			ShowInTaskbar = false;
			//不显示最小化按钮
			MinimizeBox = false;
			//不显示最大化按钮
			MaximizeBox = false;

			GenerateArrowButtons();
		}

		/// <summary>
		///     生成四个方向按钮
		/// </summary>
		private void GenerateArrowButtons()
		{
			Button[] buttons = new Button[4];
			//按钮离左边框的距离
			int leftMargin = 10;
			//按钮之间的距离
			int spacing = 10;
			//按钮宽度
			int width = (pnlDirections.Width - leftMargin*2 - spacing*2)/3;
			int height = width;
			//按钮离上边框的距离
			int topMargin = (pnlDirections.Height - spacing - 2*height)/2;

			for (int i = 0; i < 4; i++)
			{
				buttons[i] = new Button();
				buttons[i].Font = new Font("楷体", 16);
				buttons[i].Width = width;
				buttons[i].Height = height;

				//对四个按钮位置的不同处理
				if (i == 0)
				{
					buttons[i].Left = (pnlDirections.Width - width)/2;
					buttons[i].Top = topMargin;
				}
				else
				{
					buttons[i].Left = leftMargin + (i - 1)*(width + spacing);
					buttons[i].Top = topMargin + height + spacing;
				}

				buttons[i].Click += ButtonClicked;
			}

			buttons[0].Text = "↑";
			buttons[1].Text = "←";
			buttons[2].Text = "↓";
			buttons[3].Text = "→";

			pnlDirections.Controls.AddRange(buttons);
		}

		private void ButtonClicked(object sender, EventArgs e)
		{
			Button btn = (Button) sender;
			switch (btn.Text)
			{
				case "↑":
					frmMain.KeyPressed(Keys.Up);
					break;
				case "↓":
					frmMain.KeyPressed(Keys.Down);
					break;
				case "←":
					frmMain.KeyPressed(Keys.Left);
					break;
				case "→":
					frmMain.KeyPressed(Keys.Right);
					break;
				default:
					break;
			}
		}
	}
}