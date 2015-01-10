#region

using System;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace Chapter5_Exercise
{
	public partial class Form1 : Form
	{
		private const double PI = Math.PI;
		private Graphics graphics;
		private double per1;
		private double per2;
		private Random rnd = new Random();
		private double th1;
		private double th2;

		public Form1()
		{
			InitializeComponent();
			AutoScaleBaseSize = new Size(6, 14);
			ClientSize = new Size(500, 800);
			panel1.Paint += panel1_Paint;
			panel1.Click += Redraw;
			Load += Form1_Load;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			cmbColor.Items.AddRange(new[] { "红色", "绿色", "蓝色" });
			cmbWidth.Items.AddRange(new[] { "粗", "中", "细" });

			cmbColor.SelectedIndex = 0;
			cmbWidth.SelectedIndex = 2;
		}


		private void Redraw(object sender, EventArgs e)
		{
			panel1.Invalidate();
		}


		private double rand()
		{
			return rnd.NextDouble();
		}

		private void drawTree(int n,
			double x0, double y0, double leng, double th)
		{
			if (n == 0) return;

			//系数
			double k = trkK.Value / 10.0;

			double x1 = x0 + leng * Math.Cos(th);
			double y1 = y0 + leng * Math.Sin(th);

			double x2 = x0 + leng * k * Math.Cos(th);
			double y2 = y0 + leng * k * Math.Sin(th);

			drawLine(x0, y0, x2, y2);

			drawTree(n - 1, x1, y1, per1 * leng * (0.5 + rand()), th + th1 * (0.5 + rand()));
			drawTree(n - 1, x2, y2, per2 * leng * (0.4 + rand()), th - th2 * (0.5 + rand()));
			if (rand() > 0.6)
				drawTree(n - 1, x2, y2, per2 * leng * (0.4 + rand()), th - th2 * (0.5 + rand()));
		}

		private void drawLine(double x0, double y0, double x1, double y1)
		{
			//选择颜色
			Color[] colors = { Color.Red, Color.Green, Color.Blue };
			Color color = colors[cmbColor.SelectedIndex];

			//选择粗细
			int[] widths = { 3, 2, 1 };
			int width = widths[cmbWidth.SelectedIndex];

			graphics.DrawLine(
				new Pen(color, width),
				(int)x0, (int)y0, (int)x1, (int)y1);
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			Random rnd = new Random();

			th1 = !chkRandom.Checked ? trkTh1.Value * Math.PI / 180 : rnd.Next(0, 91);
			th2 = !chkRandom.Checked ? trkTh2.Value * Math.PI / 180 : rnd.Next(0, 91);
			per1 = !chkRandom.Checked ? (trkPer1.Value / 10.0) : rnd.NextDouble();
			per2 = !chkRandom.Checked ? (trkPer2.Value / 10.0) : rnd.NextDouble();

			graphics = e.Graphics;
			drawTree(10, 250, 300, 100, -PI / 2);
		}
	}
}