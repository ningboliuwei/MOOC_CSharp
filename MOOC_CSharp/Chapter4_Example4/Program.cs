using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_Example4
{
using System.Security.Policy;

internal class Program
{
    public delegate void DownloadStartHandler(object sender, DownloadStartEventArgs e);

    public delegate void DownloadEndHandler(object sender, DownloadEndEventArgs e);

    public delegate void DownloadingHandler(object sender, DownloadingEventArgs e);

    public class DownloadStartEventArgs
    {
        private string _url;

        public string Url
        {
            get
            {
                return _url;
            }
            set
            {
                _url = value;
            }
        }

        public DownloadStartEventArgs(string url)
        {
            _url = url;
        }
    }

    public class DownloadEndEventArgs
    {
        private string _url;

        private long _byteCount;

        public string Url
        {
            get
            {
                return _url;
            }
            set
            {
                _url = value;
            }
        }

        public long ByteCount
        {
            get
            {
                return this._byteCount;
            }
            set
            {
                this._byteCount = value;
            }
        }

        public DownloadEndEventArgs(string url, long size)
        {
            _url = url;
            _byteCount = size;
        }
    }

    public class DownloadingEventArgs
    {
        private string _url;

        private double _percent;

        public string Url
        {
            get
            {
                return _url;
            }

            set
            {
                _url = value;
            }
        }

        public double Percent
        {
            get
            {
                return _percent;
            }

            set
            {
                _percent = value;
            }
        }

        public DownloadingEventArgs(string url, double percent)
        {
            _url = url;
            _percent = percent;
        }
    }

    public class Crawler
    {
        private string _name;

        private string _site;

        public event DownloadStartHandler DownloadStart;
        public event DownloadEndHandler DownloadEnd;
        public event DownloadingHandler Downloading;

        private Random rnd = new Random();

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public Crawler(string name, string site)
        {
            _name = name;
            _site = site;
        }

        public void Craw()
        {
            while (true)
            {
                string url = GetNextUrl();

                if (url == null)
                {
                    break;
                }

                long size = this.GetSizeOfUrl(url);

                if (DownloadStart != null)
                {
                    DownloadStart(this, new DownloadStartEventArgs(url));
                }

                for (long i = 0; i < size + 1024; i += 1024)
                {
                    System.Threading.Thread.Sleep(100);

                    double percent = (int)(i * 100.0 / size);

                    if (percent > 100)
                    {
                        percent = 100;
                    }

                    if (Downloading != null)
                    {
                        Downloading(this, new DownloadingEventArgs(url, percent));
                    }
                }

                if (DownloadEnd != null)
                {
                    DownloadEnd(this, new DownloadEndEventArgs(url, size));
                }
            }
        }

        private string GetNextUrl()
        {
            int a = rnd.Next(10);

            if (a == 0)
            {
                return null;
            }

            return _site + "/Page" + a + ".html";
        }

        private long GetSizeOfUrl(string url)
        {
            return rnd.Next(3000 * url.Length);
        }
    }

    private static void Main(string[] args)
    {
        Crawler crawler = new Crawler("Crawer 101", "http://www.pku.edu.cn");

        crawler.DownloadStart += new DownloadStartHandler(ShowStart);
        crawler.DownloadEnd += new DownloadEndHandler(ShowEnd);
        crawler.Downloading += new DownloadingHandler(ShowPercent);

        crawler.Craw();
        Console.ReadKey();
    }

    private static void ShowStart(object sender, DownloadStartEventArgs e)
    {
        Console.WriteLine((sender as Crawler).Name + "开始下载" + e.Url);
    }

    private static void ShowEnd(object sender, DownloadEndEventArgs e)
    {
        Console.WriteLine("\n\r下载" + e.Url + "结束，其下载" + e.ByteCount + "字节");
    }

    private static void ShowPercent(object sender, DownloadingEventArgs e)
    {
        Console.Write("\r下载" + e.Url + "......." + e.Percent + "%");
    }
}
}