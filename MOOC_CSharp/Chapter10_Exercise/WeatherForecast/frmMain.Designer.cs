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
			this.cmbProvince = new ComboBox();
			this.label1 = new Label();
			this.label2 = new Label();
			this.cmbCity = new ComboBox();
			this.btnQuery = new Button();
			this.gridView = new DataGridView();
			((ISupportInitialize)(this.gridView)).BeginInit();
			this.SuspendLayout();
			// 
			// cmbProvince
			// 
			this.cmbProvince.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cmbProvince.FormattingEnabled = true;
			this.cmbProvince.Location = new Point(76, 21);
			this.cmbProvince.Name = "cmbProvince";
			this.cmbProvince.Size = new Size(121, 26);
			this.cmbProvince.TabIndex = 0;
			this.cmbProvince.SelectedIndexChanged += new EventHandler(this.cmbProvince_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new Point(12, 21);
			this.label1.Name = "label1";
			this.label1.Size = new Size(58, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "省份";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new Point(203, 23);
			this.label2.Name = "label2";
			this.label2.Size = new Size(58, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "城市";
			// 
			// cmbCity
			// 
			this.cmbCity.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cmbCity.FormattingEnabled = true;
			this.cmbCity.Location = new Point(267, 24);
			this.cmbCity.Name = "cmbCity";
			this.cmbCity.Size = new Size(121, 26);
			this.cmbCity.TabIndex = 3;
			// 
			// btnQuery
			// 
			this.btnQuery.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
			this.btnQuery.Location = new Point(394, 12);
			this.btnQuery.Name = "btnQuery";
			this.btnQuery.Size = new Size(122, 43);
			this.btnQuery.TabIndex = 4;
			this.btnQuery.Text = "查询天气";
			this.btnQuery.UseVisualStyleBackColor = true;
			this.btnQuery.Click += new EventHandler(this.btnQuery_Click);
			// 
			// gridView
			// 
			this.gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridView.Location = new Point(13, 78);
			this.gridView.Name = "gridView";
			this.gridView.RowTemplate.Height = 30;
			this.gridView.Size = new Size(997, 459);
			this.gridView.TabIndex = 5;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new SizeF(9F, 18F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new Size(1022, 549);
			this.Controls.Add(this.gridView);
			this.Controls.Add(this.btnQuery);
			this.Controls.Add(this.cmbCity);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbProvince);
			this.Name = "frmMain";
			this.Text = "天气查询器";
			this.Load += new EventHandler(this.frmMain_Load);
			((ISupportInitialize)(this.gridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ComboBox cmbProvince;
		private Label label1;
		private Label label2;
		private ComboBox cmbCity;
		private Button btnQuery;
		private DataGridView gridView;
	}
}

