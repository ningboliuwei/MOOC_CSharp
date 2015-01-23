#region

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

#endregion

namespace Chapter6_Exercise
{
	public partial class frmMain : Form
	{
		private int index;
		private bool isRunning;
		private Random rnd = new Random();
		private List<WordItem> wordList = new List<WordItem>();

		public frmMain()
		{
			InitializeComponent();
			Load += Form1_Load;
			tmrDisplay.Tick += tmrDisplay_Tick;
			chkTop.CheckedChanged += chkTop_CheckedChanged;
			udInterval.ValueChanged += udInterval_ValueChanged;
			tmrDisplay.Interval = Convert.ToInt32(udInterval.Value*1000);
		}

		private void udInterval_ValueChanged(object sender, EventArgs e)
		{
			tmrDisplay.Interval = Convert.ToInt32(udInterval.Value*1000);
		}

		private void chkTop_CheckedChanged(object sender, EventArgs e)
		{
			TopMost = chkTop.Checked;
		}


		private void tmrDisplay_Tick(object sender, EventArgs e)
		{
			if (chkRandom.Checked)
			{
				index = rnd.Next(0, wordList.Count);
			}
			else
			{
				index++;
			}

			//显示单词及解释到标签控件
			lblEnglish.Text = wordList[index].Word;
			lblChinese.Text = wordList[index].Explaination;

			//如果到了最后一个单词
			if (index == wordList.Count)
			{
				index = -1;
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			LoadWordList();
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			if (!isRunning)
			{
				tmrDisplay.Start();
				btnStart.Text = "停止(&P)";
				//为了立即显示单词
				tmrDisplay_Tick(this, null);
			}
			else
			{
				tmrDisplay.Stop();
				btnStart.Text = "开始(&S)";
			}
			isRunning = !isRunning;
		}

		private void LoadWordList()
		{
			string filePath = Application.StartupPath + "\\College_Grade4.txt";

			try
			{
				StreamReader reader = new StreamReader(filePath, Encoding.UTF8);
				string content = reader.ReadToEnd();
				string[] wordLines = content.Split('\n');

				foreach (string s in wordLines)
				{
					WordItem newWord = new WordItem();
					newWord.Word = s.Split('\t')[1];
					newWord.Explaination = s.Split('\t')[2];

					wordList.Add(newWord);
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			//重新从第一个单词开始
			index = -1;
		}

		private class WordItem
		{
			public string Word { get; set; }
			public string Explaination { get; set; }
		}
	}
}