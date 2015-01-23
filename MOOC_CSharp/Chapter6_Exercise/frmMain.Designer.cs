namespace Chapter6_Exercise
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
			this.lblEnglish = new System.Windows.Forms.Label();
			this.lblChinese = new System.Windows.Forms.Label();
			this.btnStart = new System.Windows.Forms.Button();
			this.chkRandom = new System.Windows.Forms.CheckBox();
			this.chkTop = new System.Windows.Forms.CheckBox();
			this.udInterval = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.tmrDisplay = new System.Windows.Forms.Timer(this.components);
			this.btnReset = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.udInterval)).BeginInit();
			this.SuspendLayout();
			// 
			// lblEnglish
			// 
			this.lblEnglish.AutoSize = true;
			this.lblEnglish.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblEnglish.Font = new System.Drawing.Font("宋体", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lblEnglish.ForeColor = System.Drawing.Color.MediumBlue;
			this.lblEnglish.Location = new System.Drawing.Point(0, 0);
			this.lblEnglish.Name = "lblEnglish";
			this.lblEnglish.Size = new System.Drawing.Size(0, 54);
			this.lblEnglish.TabIndex = 0;
			// 
			// lblChinese
			// 
			this.lblChinese.AutoSize = true;
			this.lblChinese.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblChinese.Font = new System.Drawing.Font("宋体", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lblChinese.Location = new System.Drawing.Point(0, 54);
			this.lblChinese.Name = "lblChinese";
			this.lblChinese.Size = new System.Drawing.Size(0, 54);
			this.lblChinese.TabIndex = 1;
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(13, 257);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(134, 59);
			this.btnStart.TabIndex = 2;
			this.btnStart.Text = "开始(&S)";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// chkRandom
			// 
			this.chkRandom.AutoSize = true;
			this.chkRandom.Location = new System.Drawing.Point(445, 257);
			this.chkRandom.Name = "chkRandom";
			this.chkRandom.Size = new System.Drawing.Size(48, 16);
			this.chkRandom.TabIndex = 3;
			this.chkRandom.Text = "随机";
			this.chkRandom.UseVisualStyleBackColor = true;
			// 
			// chkTop
			// 
			this.chkTop.AutoSize = true;
			this.chkTop.Location = new System.Drawing.Point(499, 257);
			this.chkTop.Name = "chkTop";
			this.chkTop.Size = new System.Drawing.Size(72, 16);
			this.chkTop.TabIndex = 4;
			this.chkTop.Text = "总在最上";
			this.chkTop.UseVisualStyleBackColor = true;
			// 
			// udInterval
			// 
			this.udInterval.Location = new System.Drawing.Point(504, 284);
			this.udInterval.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
			this.udInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.udInterval.Name = "udInterval";
			this.udInterval.Size = new System.Drawing.Size(46, 21);
			this.udInterval.TabIndex = 5;
			this.udInterval.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(445, 286);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 6;
			this.label1.Text = "间隔时间";
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(153, 257);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(134, 59);
			this.btnReset.TabIndex = 7;
			this.btnReset.Text = "从头开始(&T)";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(583, 328);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.udInterval);
			this.Controls.Add(this.chkTop);
			this.Controls.Add(this.chkRandom);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.lblChinese);
			this.Controls.Add(this.lblEnglish);
			this.Name = "frmMain";
			this.Text = "我爱背单词";
			((System.ComponentModel.ISupportInitialize)(this.udInterval)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblEnglish;
		private System.Windows.Forms.Label lblChinese;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.CheckBox chkRandom;
		private System.Windows.Forms.CheckBox chkTop;
		private System.Windows.Forms.NumericUpDown udInterval;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer tmrDisplay;
		private System.Windows.Forms.Button btnReset;
	}
}