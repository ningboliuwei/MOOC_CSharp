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
			this.pnlBoard = new System.Windows.Forms.Panel();
			this.ledScore = new DmitryBrant.CustomControls.SevenSegmentArray();
			this.SuspendLayout();
			// 
			// pnlBoard
			// 
			this.pnlBoard.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlBoard.Location = new System.Drawing.Point(0, 55);
			this.pnlBoard.Name = "pnlBoard";
			this.pnlBoard.Size = new System.Drawing.Size(311, 300);
			this.pnlBoard.TabIndex = 0;
			// 
			// ledScore
			// 
			this.ledScore.ArrayCount = 9;
			this.ledScore.ColorBackground = System.Drawing.Color.DarkGray;
			this.ledScore.ColorDark = System.Drawing.Color.DimGray;
			this.ledScore.ColorLight = System.Drawing.Color.Red;
			this.ledScore.DecimalShow = true;
			this.ledScore.Dock = System.Windows.Forms.DockStyle.Top;
			this.ledScore.ElementPadding = new System.Windows.Forms.Padding(4);
			this.ledScore.ElementWidth = 10;
			this.ledScore.ItalicFactor = 0F;
			this.ledScore.Location = new System.Drawing.Point(0, 0);
			this.ledScore.Name = "ledScore";
			this.ledScore.Size = new System.Drawing.Size(311, 53);
			this.ledScore.TabIndex = 1;
			this.ledScore.TabStop = false;
			this.ledScore.Value = "2048";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(311, 355);
			this.Controls.Add(this.ledScore);
			this.Controls.Add(this.pnlBoard);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBoard;
		private DmitryBrant.CustomControls.SevenSegmentArray ledScore;
    }
}

