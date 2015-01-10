namespace Chapter5_Exercise
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.trkTh1 = new System.Windows.Forms.TrackBar();
			this.label2 = new System.Windows.Forms.Label();
			this.trkTh2 = new System.Windows.Forms.TrackBar();
			this.label3 = new System.Windows.Forms.Label();
			this.trkPer1 = new System.Windows.Forms.TrackBar();
			this.label4 = new System.Windows.Forms.Label();
			this.trkPer2 = new System.Windows.Forms.TrackBar();
			this.label6 = new System.Windows.Forms.Label();
			this.trkK = new System.Windows.Forms.TrackBar();
			this.label7 = new System.Windows.Forms.Label();
			this.cmbColor = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.cmbWidth = new System.Windows.Forms.ComboBox();
			this.chkRandom = new System.Windows.Forms.CheckBox();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trkTh1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trkTh2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trkPer1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trkPer2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trkK)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(536, 338);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.label1);
			this.flowLayoutPanel1.Controls.Add(this.trkTh1);
			this.flowLayoutPanel1.Controls.Add(this.label2);
			this.flowLayoutPanel1.Controls.Add(this.trkTh2);
			this.flowLayoutPanel1.Controls.Add(this.label3);
			this.flowLayoutPanel1.Controls.Add(this.trkPer1);
			this.flowLayoutPanel1.Controls.Add(this.label4);
			this.flowLayoutPanel1.Controls.Add(this.trkPer2);
			this.flowLayoutPanel1.Controls.Add(this.label6);
			this.flowLayoutPanel1.Controls.Add(this.trkK);
			this.flowLayoutPanel1.Controls.Add(this.label7);
			this.flowLayoutPanel1.Controls.Add(this.cmbColor);
			this.flowLayoutPanel1.Controls.Add(this.label8);
			this.flowLayoutPanel1.Controls.Add(this.cmbWidth);
			this.flowLayoutPanel1.Controls.Add(this.chkRandom);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 338);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(536, 349);
			this.flowLayoutPanel1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "角度1";
			// 
			// trkTh1
			// 
			this.trkTh1.Location = new System.Drawing.Point(44, 3);
			this.trkTh1.Maximum = 90;
			this.trkTh1.Name = "trkTh1";
			this.trkTh1.Size = new System.Drawing.Size(467, 45);
			this.trkTh1.TabIndex = 1;
			this.trkTh1.TickFrequency = 5;
			this.trkTh1.Value = 30;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 12);
			this.label2.TabIndex = 2;
			this.label2.Text = "角度2";
			// 
			// trkTh2
			// 
			this.trkTh2.Location = new System.Drawing.Point(44, 54);
			this.trkTh2.Maximum = 90;
			this.trkTh2.Name = "trkTh2";
			this.trkTh2.Size = new System.Drawing.Size(467, 45);
			this.trkTh2.TabIndex = 3;
			this.trkTh2.TickFrequency = 5;
			this.trkTh2.Value = 35;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 102);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 12);
			this.label3.TabIndex = 4;
			this.label3.Text = "长度1";
			// 
			// trkPer1
			// 
			this.trkPer1.Location = new System.Drawing.Point(44, 105);
			this.trkPer1.Name = "trkPer1";
			this.trkPer1.Size = new System.Drawing.Size(467, 45);
			this.trkPer1.TabIndex = 5;
			this.trkPer1.Value = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 153);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 12);
			this.label4.TabIndex = 6;
			this.label4.Text = "长度2";
			// 
			// trkPer2
			// 
			this.trkPer2.Location = new System.Drawing.Point(44, 156);
			this.trkPer2.Name = "trkPer2";
			this.trkPer2.Size = new System.Drawing.Size(467, 45);
			this.trkPer2.TabIndex = 7;
			this.trkPer2.Value = 7;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 204);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(29, 12);
			this.label6.TabIndex = 10;
			this.label6.Text = "系数";
			// 
			// trkK
			// 
			this.trkK.Location = new System.Drawing.Point(38, 207);
			this.trkK.Maximum = 20;
			this.trkK.Minimum = 10;
			this.trkK.Name = "trkK";
			this.trkK.Size = new System.Drawing.Size(467, 45);
			this.trkK.TabIndex = 11;
			this.trkK.TickFrequency = 2;
			this.trkK.Value = 15;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(3, 255);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(29, 12);
			this.label7.TabIndex = 13;
			this.label7.Text = "颜色";
			// 
			// cmbColor
			// 
			this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbColor.FormattingEnabled = true;
			this.cmbColor.Location = new System.Drawing.Point(38, 258);
			this.cmbColor.Name = "cmbColor";
			this.cmbColor.Size = new System.Drawing.Size(121, 20);
			this.cmbColor.TabIndex = 12;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(165, 255);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(29, 12);
			this.label8.TabIndex = 15;
			this.label8.Text = "粗细";
			// 
			// cmbWidth
			// 
			this.cmbWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbWidth.FormattingEnabled = true;
			this.cmbWidth.Location = new System.Drawing.Point(200, 258);
			this.cmbWidth.Name = "cmbWidth";
			this.cmbWidth.Size = new System.Drawing.Size(72, 20);
			this.cmbWidth.TabIndex = 14;
			// 
			// chkRandom
			// 
			this.chkRandom.AutoSize = true;
			this.chkRandom.Location = new System.Drawing.Point(278, 258);
			this.chkRandom.Name = "chkRandom";
			this.chkRandom.Size = new System.Drawing.Size(72, 16);
			this.chkRandom.TabIndex = 16;
			this.chkRandom.Text = "完全随机";
			this.chkRandom.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(536, 687);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Tree Generator";
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trkTh1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trkTh2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trkPer1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trkPer2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trkK)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trkTh1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trkTh2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trkPer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trkPer2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trkK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbWidth;
        private System.Windows.Forms.CheckBox chkRandom;

    }
}

