using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Xsl;

namespace WeatherForecast
{
	public partial class frmMain : Form
	{
		List<LocationRecord> locationList = new List<LocationRecord>();
		List<YahooCityCodeRecord> yahooCityCodeList = new List<YahooCityCodeRecord>();

		//得到 Yahoo Weather 的天气后保存为的 XML 文件路径
		readonly string xmlPath = Application.StartupPath + "\\weather.xml";
		//用于转换 XML 文件的 XSL 文件
		readonly string xslPath = Application.StartupPath + "\\weather.xsl";
		//输出的结果 HTML 文件（用于显示在窗体中的 WebBrowser 控件中）
		readonly string resultPath = Application.StartupPath + "\\weather.html";

		public frmMain()
		{
			InitializeComponent();
		}

		//城市与省份对应记录类（第三方）
		class LocationRecord
		{
			public string LocationSn;
			public string LocationName;
			public string LocationCode;
			public string Province;
		}

		//城市名与 Yahoo Weather 代码对应记录类
		class YahooCityCodeRecord
		{
			public string CityName;
			public string YahooCityCode;
		}

		//从 mobile.weather.com.cn 获取所有城市与省份的对应数据
		public void LoadLocationList()
		{
			string url = "http://mobile.weather.com.cn/js/citylist.xml";
			XDocument doc = XDocument.Load(url);

			//通过 LINQ 将数据添加到 locationList 这个泛型中
			locationList = (from r in doc.Descendants("d")
							select new LocationRecord
							{
								LocationSn = r.Attribute("d1").Value,
								LocationName = r.Attribute("d2").Value,
								LocationCode = r.Attribute("d3").Value,
								Province = r.Attribute("d4").Value
							}).ToList();
		}

		//将 Yahoo Weather 中不存在的城市剔除
		public void FilterLocations()
		{
			locationList = (from l in locationList
							where (from c in yahooCityCodeList
								   select c.CityName).ToArray().Contains(l.LocationName)
							select l).ToList();
		}

		private void btnQuery_Click(object sender, EventArgs e)
		{
			//根据城市代码查询天气，得到 XML 文件并保存到本地
			SaveWeatherXml(GetYahooCityCode(cmbCity.Text));
			//利用 XSL 文件对天气 XML 文件进行转换，并输出 HTML 文件
			TransformResult();
			//将 HTML 文件显示在 WebBrowser 控件中
			ShowResult();
		}

		//将省份显示到下拉列表中
		private void BindProvinceComboBox()
		{
			//从（过滤后的）城市列表中选取所有的省份名称
			var provinces = from l in locationList
							select new
							{
								l.Province
							};

			cmbProvince.DisplayMember = "Province";
			cmbProvince.DataSource = provinces.Distinct().ToList();
		}

		//根据省份名，在城市下拉列表中显示该省份对应的城市
		private void BindCityComboBox(string province)
		{
			//在城市列表中找到所有对应省份为指定省份的记录
			var cities = from c in locationList
						 where c.Province == province
						 select new
						 {
							 City = c.LocationName,
							 Code = c.LocationCode
						 };

			cmbCity.DisplayMember = "City";
			cmbCity.ValueMember = "Code";
			cmbCity.DataSource = cities.Distinct().ToList();
		}

		//从网上找到的数据文件中根据城市名获取相应的 Yahoo Weather 城市代码数据
		private void LoadCityCodeList()
		{
			string path = Application.StartupPath + "\\CityCodes.txt";

			using (StreamReader sr = new StreamReader(path, Encoding.Default))
			{
				while (sr.Peek() >= 0)
				{
					string line = sr.ReadLine();
					if (line != null)
					{
						yahooCityCodeList.Add(new YahooCityCodeRecord { CityName = line.Split(' ')[0], YahooCityCode = line.Split(' ')[1] });
					}
				}
			}
		}

		//根据城市名获取 Yahoo Weather 城市代码
		private string GetYahooCityCode(string cityName)
		{
			string s = (from c in yahooCityCodeList
						where c.CityName == cityName
						select c.YahooCityCode).First();
			return s;
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			//加载所有地区列表
			LoadLocationList();
			//加载所有城市代码列表
			LoadCityCodeList();
			//剔除在城市代码列表中不存在的地区
			FilterLocations();
			//将省份显示在省份下拉框中
			BindProvinceComboBox();
			//在城市下拉框中显示第一个省份的城市
			BindCityComboBox(locationList[0].Province);
		}

		private void cmbProvince_SelectedIndexChanged(object sender, EventArgs e)
		{
			//根据所选省份，改变城市下拉框中的选项
			BindCityComboBox(cmbProvince.Text);
		}

		//获取指定城市的天气 XML 字符串并保存为 XML 文件
		public void  SaveWeatherXml(string cityCode)
		{
			string weatherXmlUrl = $"http://xml.weather.yahoo.com/forecastrss?p={cityCode}&u=c";

			XmlDocument Weather = new XmlDocument();
			try
			{
				Weather.Load(weatherXmlUrl);
				Weather.Save(xmlPath);
			}
			catch (Exception)
			{
				throw new Exception("无法获取天气");
			}


		}

		//将天气 XML 文件转换为 HTML 文件
		public void TransformResult()
		{
			var trans = new XslCompiledTransform();
			trans.Load(xslPath);
			trans.Transform(xmlPath, resultPath);
		}

		//将 HTML 结果文件显示在 WebBrowser 控件中
		public void ShowResult()
		{
			wbsResult.Navigate(resultPath);
		}
	}
}