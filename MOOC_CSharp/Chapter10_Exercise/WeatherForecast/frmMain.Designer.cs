using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WeatherForecast
{
	partial class frmMain
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private IContainer components = null;

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
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.cmbProvince = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbCity = new System.Windows.Forms.ComboBox();
			this.wbsResult = new System.Windows.Forms.WebBrowser();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnQuery = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.tableLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmbProvince
			// 
			this.cmbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbProvince.FormattingEnabled = true;
			this.cmbProvince.Location = new System.Drawing.Point(67, 3);
			this.cmbProvince.Name = "cmbProvince";
			this.cmbProvince.Size = new System.Drawing.Size(121, 26);
			this.cmbProvince.TabIndex = 0;
			this.cmbProvince.SelectedIndexChanged += new System.EventHandler(this.cmbProvince_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "省份";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(194, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "城市";
			// 
			// cmbCity
			// 
			this.cmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCity.FormattingEnabled = true;
			this.cmbCity.Location = new System.Drawing.Point(258, 3);
			this.cmbCity.Name = "cmbCity";
			this.cmbCity.Size = new System.Drawing.Size(121, 26);
			this.cmbCity.TabIndex = 3;
			// 
			// wbsResult
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.wbsResult, 2);
			this.wbsResult.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wbsResult.Location = new System.Drawing.Point(0, 40);
			this.wbsResult.Margin = new System.Windows.Forms.Padding(0);
			this.wbsResult.MinimumSize = new System.Drawing.Size(20, 20);
			this.wbsResult.Name = "wbsResult";
			this.wbsResult.Size = new System.Drawing.Size(978, 804);
			this.wbsResult.TabIndex = 5;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
			this.tableLayoutPanel1.Controls.Add(this.btnQuery, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.wbsResult, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(978, 844);
			this.tableLayoutPanel1.TabIndex = 6;
			// 
			// btnQuery
			// 
			this.btnQuery.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnQuery.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnQuery.Location = new System.Drawing.Point(831, 3);
			this.btnQuery.Name = "btnQuery";
			this.btnQuery.Size = new System.Drawing.Size(144, 34);
			this.btnQuery.TabIndex = 5;
			this.btnQuery.Text = "查询天气";
			this.btnQuery.UseVisualStyleBackColor = true;
			this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.label1);
			this.flowLayoutPanel1.Controls.Add(this.cmbProvince);
			this.flowLayoutPanel1.Controls.Add(this.label2);
			this.flowLayoutPanel1.Controls.Add(this.cmbCity);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(822, 34);
			this.flowLayoutPanel1.TabIndex = 6;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(978, 844);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "frmMain";
			this.Text = "天气查询器";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private ComboBox cmbProvince;
		private Label label1;
		private Label label2;
		private ComboBox cmbCity;
		private WebBrowser wbsResult;
		private TableLayoutPanel tableLayoutPanel1;
		private Button btnQuery;
		private FlowLayoutPanel flowLayoutPanel1;
	}
}

