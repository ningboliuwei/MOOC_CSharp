namespace Chapter2_Exercise
{
	partial class CaculationTest
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbnMulitply = new System.Windows.Forms.RadioButton();
			this.rbn20 = new System.Windows.Forms.RadioButton();
			this.rbn10 = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnSlower = new System.Windows.Forms.Button();
			this.btnFaster = new System.Windows.Forms.Button();
			this.chkAutoNext = new System.Windows.Forms.CheckBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtAnswer = new System.Windows.Forms.TextBox();
			this.lblQuestion = new System.Windows.Forms.Label();
			this.btnNextQuestion = new System.Windows.Forms.Button();
			this.tmrAutoNext = new System.Windows.Forms.Timer(this.components);
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbnMulitply);
			this.groupBox1.Controls.Add(this.rbn20);
			this.groupBox1.Controls.Add(this.rbn10);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.groupBox1.Size = new System.Drawing.Size(723, 77);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "题目类型";
			// 
			// rbnMulitply
			// 
			this.rbnMulitply.AutoSize = true;
			this.rbnMulitply.Location = new System.Drawing.Point(280, 32);
			this.rbnMulitply.Margin = new System.Windows.Forms.Padding(4);
			this.rbnMulitply.Name = "rbnMulitply";
			this.rbnMulitply.Size = new System.Drawing.Size(112, 25);
			this.rbnMulitply.TabIndex = 3;
			this.rbnMulitply.TabStop = true;
			this.rbnMulitply.Text = "10 以内乘法";
			this.rbnMulitply.UseVisualStyleBackColor = true;
			// 
			// rbn20
			// 
			this.rbn20.AutoSize = true;
			this.rbn20.Location = new System.Drawing.Point(144, 32);
			this.rbn20.Margin = new System.Windows.Forms.Padding(4);
			this.rbn20.Name = "rbn20";
			this.rbn20.Size = new System.Drawing.Size(131, 25);
			this.rbn20.TabIndex = 1;
			this.rbn20.TabStop = true;
			this.rbn20.Text = "20 以内加减法";
			this.rbn20.UseVisualStyleBackColor = true;
			// 
			// rbn10
			// 
			this.rbn10.AutoSize = true;
			this.rbn10.Location = new System.Drawing.Point(8, 32);
			this.rbn10.Margin = new System.Windows.Forms.Padding(4);
			this.rbn10.Name = "rbn10";
			this.rbn10.Size = new System.Drawing.Size(128, 25);
			this.rbn10.TabIndex = 0;
			this.rbn10.TabStop = true;
			this.rbn10.Text = "10 以内加减法";
			this.rbn10.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnSlower);
			this.groupBox2.Controls.Add(this.btnFaster);
			this.groupBox2.Controls.Add(this.chkAutoNext);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox2.Location = new System.Drawing.Point(0, 77);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.groupBox2.Size = new System.Drawing.Size(723, 77);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "自动出题";
			// 
			// btnSlower
			// 
			this.btnSlower.Location = new System.Drawing.Point(262, 25);
			this.btnSlower.Margin = new System.Windows.Forms.Padding(4);
			this.btnSlower.Name = "btnSlower";
			this.btnSlower.Size = new System.Drawing.Size(96, 32);
			this.btnSlower.TabIndex = 2;
			this.btnSlower.Text = "减速(&S)";
			this.btnSlower.UseVisualStyleBackColor = true;
			this.btnSlower.Click += new System.EventHandler(this.btnSlower_Click);
			// 
			// btnFaster
			// 
			this.btnFaster.Location = new System.Drawing.Point(158, 25);
			this.btnFaster.Margin = new System.Windows.Forms.Padding(4);
			this.btnFaster.Name = "btnFaster";
			this.btnFaster.Size = new System.Drawing.Size(96, 32);
			this.btnFaster.TabIndex = 1;
			this.btnFaster.Text = "加速(&F)";
			this.btnFaster.UseVisualStyleBackColor = true;
			this.btnFaster.Click += new System.EventHandler(this.btnFaster_Click);
			// 
			// chkAutoNext
			// 
			this.chkAutoNext.AutoSize = true;
			this.chkAutoNext.Location = new System.Drawing.Point(8, 32);
			this.chkAutoNext.Margin = new System.Windows.Forms.Padding(4);
			this.chkAutoNext.Name = "chkAutoNext";
			this.chkAutoNext.Size = new System.Drawing.Size(141, 25);
			this.chkAutoNext.TabIndex = 0;
			this.chkAutoNext.Text = "自动显示下一题";
			this.chkAutoNext.UseVisualStyleBackColor = true;
			this.chkAutoNext.CheckedChanged += new System.EventHandler(this.chkAutoNext_CheckedChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.txtAnswer);
			this.groupBox3.Controls.Add(this.lblQuestion);
			this.groupBox3.Controls.Add(this.btnNextQuestion);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox3.Location = new System.Drawing.Point(0, 154);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.groupBox3.Size = new System.Drawing.Size(723, 346);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "答题区";
			// 
			// txtAnswer
			// 
			this.txtAnswer.Font = new System.Drawing.Font("微软雅黑 Light", 80.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txtAnswer.Location = new System.Drawing.Point(366, 28);
			this.txtAnswer.Margin = new System.Windows.Forms.Padding(4);
			this.txtAnswer.Name = "txtAnswer";
			this.txtAnswer.Size = new System.Drawing.Size(127, 150);
			this.txtAnswer.TabIndex = 3;
			// 
			// lblQuestion
			// 
			this.lblQuestion.AutoSize = true;
			this.lblQuestion.Location = new System.Drawing.Point(17, 32);
			this.lblQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblQuestion.Name = "lblQuestion";
			this.lblQuestion.Size = new System.Drawing.Size(0, 21);
			this.lblQuestion.TabIndex = 2;
			// 
			// btnNextQuestion
			// 
			this.btnNextQuestion.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnNextQuestion.Location = new System.Drawing.Point(4, 283);
			this.btnNextQuestion.Margin = new System.Windows.Forms.Padding(4);
			this.btnNextQuestion.Name = "btnNextQuestion";
			this.btnNextQuestion.Size = new System.Drawing.Size(715, 57);
			this.btnNextQuestion.TabIndex = 1;
			this.btnNextQuestion.Text = "下一题(&N)";
			this.btnNextQuestion.UseVisualStyleBackColor = true;
			this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
			// 
			// tmrAutoNext
			// 
			this.tmrAutoNext.Interval = 5000;
			this.tmrAutoNext.Tick += new System.EventHandler(this.tmrAutoNext_Tick);
			// 
			// CaculationTest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(723, 500);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.Name = "CaculationTest";
			this.Text = "算数练习";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbnMulitply;
		private System.Windows.Forms.RadioButton rbn20;
		private System.Windows.Forms.RadioButton rbn10;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnSlower;
		private System.Windows.Forms.Button btnFaster;
		private System.Windows.Forms.CheckBox chkAutoNext;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox txtAnswer;
		private System.Windows.Forms.Label lblQuestion;
		private System.Windows.Forms.Button btnNextQuestion;
		private System.Windows.Forms.Timer tmrAutoNext;
	}
}

