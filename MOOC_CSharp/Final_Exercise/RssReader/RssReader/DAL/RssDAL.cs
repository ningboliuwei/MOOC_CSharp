using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using RssReader.Model;
using RssReader.Util;

namespace RssReader.DAL
{
    public static class RssDAL
    {
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

        public static RssInfo GetRssById(string id)
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

        public static void Add(RssInfo rssInfo)
        {
            string commandText = $"INSERT INTO [rss] (Title,Description,Url) " +
                                 $"VALUES ('{rssInfo.Title}', '{rssInfo.Description}','{rssInfo.Url}')";
            DBHelper.ExecuteNonQuery(commandText);
        }

        public static void Delete(string id)
        {
            string commandText = $"DELETE FROM [rss] " +
                                 $"WHERE id = {id}";
            DBHelper.ExecuteNonQuery(commandText);
        }
    }
}