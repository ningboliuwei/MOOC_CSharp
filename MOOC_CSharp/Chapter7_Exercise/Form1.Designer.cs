namespace Game2048
{
    partial class Form1
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.panel1 = new System.Windows.Forms.Panel();
			this.设置PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.游戏模式MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.经典CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.朝廷PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.军队AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pnlBoard = new System.Windows.Forms.Panel();
			this.朝代DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.虚拟按键模式VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ledHighest = new DmitryBrant.CustomControls.SevenSegmentArray();
			this.ledScore = new DmitryBrant.CustomControls.SevenSegmentArray();
			this.功能FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.重新开始RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.退出XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.功能FToolStripMenuItem,
            this.设置PToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(311, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.Controls.Add(this.ledScore);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(311, 53);
			this.panel1.TabIndex = 3;
			// 
			// 设置PToolStripMenuItem
			// 
			this.设置PToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.游戏模式MToolStripMenuItem,
            this.虚拟按键模式VToolStripMenuItem});
			this.设置PToolStripMenuItem.Name = "设置PToolStripMenuItem";
			this.设置PToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
			this.设置PToolStripMenuItem.Text = "设置(&P)";
			// 
			// 游戏模式MToolStripMenuItem
			// 
			this.游戏模式MToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.经典CToolStripMenuItem,
            this.朝代DToolStripMenuItem,
            this.朝廷PToolStripMenuItem,
            this.军队AToolStripMenuItem});
			this.游戏模式MToolStripMenuItem.Name = "游戏模式MToolStripMenuItem";
			this.游戏模式MToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
			this.游戏模式MToolStripMenuItem.Text = "游戏模式(&M)";
			// 
			// 经典CToolStripMenuItem
			// 
			this.经典CToolStripMenuItem.Checked = true;
			this.经典CToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.经典CToolStripMenuItem.Name = "经典CToolStripMenuItem";
			this.经典CToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.经典CToolStripMenuItem.Text = "经典(&C)";
			this.经典CToolStripMenuItem.Click += new System.EventHandler(this.经典CToolStripMenuItem_Click);
			// 
			// 朝廷PToolStripMenuItem
			// 
			this.朝廷PToolStripMenuItem.Name = "朝廷PToolStripMenuItem";
			this.朝廷PToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.朝廷PToolStripMenuItem.Text = "朝廷(&P)";
			this.朝廷PToolStripMenuItem.Click += new System.EventHandler(this.朝廷PToolStripMenuItem_Click);
			// 
			// 军队AToolStripMenuItem
			// 
			this.军队AToolStripMenuItem.Name = "军队AToolStripMenuItem";
			this.军队AToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.军队AToolStripMenuItem.Text = "军队(&A)";
			this.军队AToolStripMenuItem.Click += new System.EventHandler(this.军队AToolStripMenuItem_Click);
			// 
			// pnlBoard
			// 
			this.pnlBoard.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlBoard.Location = new System.Drawing.Point(0, 130);
			this.pnlBoard.Name = "pnlBoard";
			this.pnlBoard.Size = new System.Drawing.Size(311, 330);
			this.pnlBoard.TabIndex = 5;
			// 
			// 朝代DToolStripMenuItem
			// 
			this.朝代DToolStripMenuItem.Name = "朝代DToolStripMenuItem";
			this.朝代DToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.朝代DToolStripMenuItem.Text = "朝代(&D)";
			this.朝代DToolStripMenuItem.Click += new System.EventHandler(this.朝代DToolStripMenuItem_Click);
			// 
			// 虚拟按键模式VToolStripMenuItem
			// 
			this.虚拟按键模式VToolStripMenuItem.Name = "虚拟按键模式VToolStripMenuItem";
			this.虚拟按键模式VToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
			this.虚拟按键模式VToolStripMenuItem.Text = "虚拟按键模式(&V)";
			this.虚拟按键模式VToolStripMenuItem.Click += new System.EventHandler(this.虚拟按键模式VToolStripMenuItem_Click);
			// 
			// ledHighest
			// 
			this.ledHighest.ArrayCount = 9;
			this.ledHighest.ColorBackground = System.Drawing.Color.Black;
			this.ledHighest.ColorDark = System.Drawing.Color.DarkGreen;
			this.ledHighest.ColorLight = System.Drawing.Color.Lime;
			this.ledHighest.DecimalShow = true;
			this.ledHighest.Dock = System.Windows.Forms.DockStyle.Top;
			this.ledHighest.ElementPadding = new System.Windows.Forms.Padding(4);
			this.ledHighest.ElementWidth = 10;
			this.ledHighest.ItalicFactor = 0F;
			this.ledHighest.Location = new System.Drawing.Point(0, 77);
			this.ledHighest.Name = "ledHighest";
			this.ledHighest.Size = new System.Drawing.Size(311, 53);
			this.ledHighest.TabIndex = 4;
			this.ledHighest.TabStop = false;
			this.ledHighest.Value = "0";
			// 
			// ledScore
			// 
			this.ledScore.ArrayCount = 9;
			this.ledScore.ColorBackground = System.Drawing.Color.Black;
			this.ledScore.ColorDark = System.Drawing.Color.Maroon;
			this.ledScore.ColorLight = System.Drawing.Color.Red;
			this.ledScore.DecimalShow = true;
			this.ledScore.Dock = System.Windows.Forms.DockStyle.Top;
			this.ledScore.ElementPadding = new System.Windows.Forms.Padding(4);
			this.ledScore.ElementWidth = 10;
			this.ledScore.ItalicFactor = 0F;
			this.ledScore.Location = new System.Drawing.Point(0, 0);
			this.ledScore.Name = "ledScore";
			this.ledScore.Size = new System.Drawing.Size(311, 53);
			this.ledScore.TabIndex = 2;
			this.ledScore.TabStop = false;
			this.ledScore.Value = "0";
			// 
			// 功能FToolStripMenuItem
			// 
			this.功能FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.重新开始RToolStripMenuItem,
            this.退出XToolStripMenuItem});
			this.功能FToolStripMenuItem.Name = "功能FToolStripMenuItem";
			this.功能FToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
			this.功能FToolStripMenuItem.Text = "功能(&F)";
			// 
			// 重新开始RToolStripMenuItem
			// 
			this.重新开始RToolStripMenuItem.Name = "重新开始RToolStripMenuItem";
			this.重新开始RToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.重新开始RToolStripMenuItem.Text = "重新开始(&R)";
			this.重新开始RToolStripMenuItem.Click += new System.EventHandler(this.重新开始RToolStripMenuItem_Click);
			// 
			// 退出XToolStripMenuItem
			// 
			this.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem";
			this.退出XToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.退出XToolStripMenuItem.Text = "退出(&X)";
			this.退出XToolStripMenuItem.Click += new System.EventHandler(this.退出XToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(311, 460);
			this.Controls.Add(this.pnlBoard);
			this.Controls.Add(this.ledHighest);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Panel panel1;
		private DmitryBrant.CustomControls.SevenSegmentArray ledScore;
		private System.Windows.Forms.ToolStripMenuItem 设置PToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 游戏模式MToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 经典CToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 朝廷PToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 军队AToolStripMenuItem;
		private DmitryBrant.CustomControls.SevenSegmentArray ledHighest;
		private System.Windows.Forms.Panel pnlBoard;
		private System.Windows.Forms.ToolStripMenuItem 朝代DToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem 虚拟按键模式VToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 功能FToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 重新开始RToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 退出XToolStripMenuItem;
    }
}

