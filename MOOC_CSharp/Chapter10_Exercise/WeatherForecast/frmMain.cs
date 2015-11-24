using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace WeatherForecast
{
	public partial class frmMain : Form
	{
		List<LocationRecord> locationList = new List<LocationRecord>();
		List<YahooCityCodeRecord> yahooCityCodeList = new List<YahooCityCodeRecord>();

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
			//获取数据后显示在 GridView 中
			gridView.DataSource = GetYahooWeather(GetYahooCityCode(cmbCity.Text)).Tables[0];
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
			LoadLocationList();
			LoadCityCodeList();
			FilterLocations();
			BindProvinceComboBox();
			BindCityComboBox(locationList[0].Province);
		}

		private void cmbProvince_SelectedIndexChanged(object sender, EventArgs e)
		{
			BindCityComboBox(cmbProvince.Text);
		}

		//以下为唐大仕老师例子中的代码
		public static DataSet GetYahooWeather(string cityCode)
		{
			string strXml = "http://xml.weather.yahoo.com/forecastrss?p=" + cityCode;

			XmlDocument Weather = new XmlDocument();
			Weather.Load(strXml);

			XmlNamespaceManager namespacemanager = new
				XmlNamespaceManager(Weather.NameTable);
			namespacemanager.AddNamespace("yweather",
				"http://xml.weather.yahoo.com/ns/rss/1.0");
			XmlNodeList nodes = Weather.SelectNodes("/rss/channel/item/yweather:forecast", namespacemanager);

			//XmlNodeList nodes = Weather.GetElementsByTagName("forecast", "http://xml.weather.yahoo.com/ns/rss/1.0");

			DataSet dstWeather = new DataSet();
			DataTable dtblWeather = new DataTable("Weather");
			dstWeather.Tables.Add(dtblWeather);

			dstWeather.Tables["Weather"].Columns.Add("Date", typeof(string));
			dstWeather.Tables["Weather"].Columns.Add("Week", typeof(string));
			dstWeather.Tables["Weather"].Columns.Add("Weather", typeof(string));
			dstWeather.Tables["Weather"].Columns.Add("Tlow", typeof(string));
			dstWeather.Tables["Weather"].Columns.Add("Thigh", typeof(string));

			if (nodes.Count > 0)
			{
				foreach (XmlNode node in nodes)
				{
					DataRow drowWeather = dstWeather.Tables["Weather"].NewRow();

					drowWeather["Date"] = EmonthToCmonth(node.SelectSingleNode
						("@date").Value);
					drowWeather["Week"] = EweekToCweek(node.SelectSingleNode
						("@day").Value) + "(" + node.SelectSingleNode("@day").Value
										  + ")";
					drowWeather["Weather"] = node.SelectSingleNode("@text").Value;
					drowWeather["Tlow"] = FToC(int.Parse(node.SelectSingleNode
						("@low").Value)) + "℃";
					drowWeather["Thigh"] = FToC(int.Parse(node.SelectSingleNode
						("@high").Value)) + "℃";

					dstWeather.Tables["Weather"].Rows.Add(drowWeather);
				}

				return dstWeather;
			}
			DataRow drowNone = dstWeather.Tables["Weather"].NewRow();
			drowNone["Week"] = "None";
			drowNone["Weather"] = "None";
			drowNone["Tlow"] = "None";
			drowNone["Thigh"] = "None";

			dstWeather.Tables["Weather"].Rows.Add(drowNone);
			return dstWeather;

			return dstWeather;
		}

		/**/

		/// <summary>
		/// 从华氏转换成摄氏
		/// </summary>
		/// <param name="f">华氏度</param>
		/// <returns></returns>
		private static string FToC(int f)
		{
			return Math.Round((f - 32) / 1.8, 1).ToString();
		}

		/**/

		/// <summary>
		/// 从星期英文缩写转汉字
		/// </summary>
		/// <param name="strEweek">星期的英文缩写</param>
		/// <returns></returns>
		private static string EweekToCweek(string strEweek)
		{
			switch (strEweek)
			{
				case "Mon":
					return "星期一";
					break;
				case "Tue":
					return "星期二";
					break;
				case "Wed":
					return "星期三";
					break;
				case "Thu":
					return "星期四";
					break;
				case "Fri":
					return "星期五";
					break;
				case "Sat":
					return "星期六";
					break;
				case "Sun":
					return "星期日";
					break;
				default:
					return "传参错误";
					break;
			}
		}

		/**/

		/// <summary>
		/// 从月英文缩写转汉字
		/// </summary>
		/// <param name="strReplace">需要替换的年月日</param>
		/// <returns></returns>
		private static string EmonthToCmonth(string strReplace)
		{
			return Convert.ToDateTime(strReplace).ToString("yyyy年MM月dd日");
		}
	}
}