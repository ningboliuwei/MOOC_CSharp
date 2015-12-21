using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RssReader.Model
{
    //RSS 信息 Model 类
    public class RssInfo
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public int Category { get; set; }
    }
}