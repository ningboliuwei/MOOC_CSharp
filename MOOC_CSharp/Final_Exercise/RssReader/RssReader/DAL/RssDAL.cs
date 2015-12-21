using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using RssReader.Model;
using RssReader.Util;

namespace RssReader.DAL
{
    //RSS 数据访问层
    public static class RssDAL
    {
        //得到所有 RSS 信息
        public static List<RssInfo> GetAllRsses()
        {
            string commandText = $"SELECT * FROM [rss] ";

            DataTable resultDataTable = DBHelper.GetDataTableByCommand(commandText);

            return (from c in resultDataTable.AsEnumerable()
                select new RssInfo()
                {
                    ID = Convert.ToInt32(c.Field<int>("ID")),
                    Title = c.Field<string>("Title"),
                    Description = c.Field<string>("Description"),
                    Url = c.Field<string>("Url"),
                    Category = c.Field<int>("Category")
                }).ToList();
        }

        //根据 ID 得到某一个 RSS 信息
        public static RssInfo GetRssById(int id)
        {
            string commandText = $"SELECT * FROM [rss] " +
                                 $"WHERE ID = {id}";
            DataTable resultDataTable = DBHelper.GetDataTableByCommand(commandText);
            return (from c in resultDataTable.AsEnumerable()
                select new RssInfo()
                {
                    ID = Convert.ToInt32(c.Field<int>("ID")),
                    Title = c.Field<string>("Title"),
                    Description = c.Field<string>("Description"),
                    Url = c.Field<string>("Url"),
                    Category = c.Field<int>("Category")
                }).ToList().First();
        }

        //添加新的 RSS 信息
        public static void Add(RssInfo rssInfo)
        {
            string commandText = $"INSERT INTO [rss] (Title, Description, Url, Category) " +
                                 $"VALUES ('{rssInfo.Title}', '{rssInfo.Description}','{rssInfo.Url}', {rssInfo.Category})";
            DBHelper.ExecuteNonQuery(commandText);
        }

        //根据 ID 删除指定的 RSS 信息
        public static void Delete(string id)
        {
            string commandText = $"DELETE FROM [rss] " +
                                 $"WHERE id = {id}";
            DBHelper.ExecuteNonQuery(commandText);
        }


        //修改指定的 RSS 信息
        public static void Update(int id, RssInfo rssInfo)
        {
            string commandText = $"UPDATE [rss] " +
                                 $"SET Title = '{rssInfo.Title}', " +
                                 $"Description = '{rssInfo.Description}', " +
                                 $"Url = '{rssInfo.Url}' " +
                                 $"WHERE ID = {id}";
            DBHelper.ExecuteNonQuery(commandText);
        }
    }
}