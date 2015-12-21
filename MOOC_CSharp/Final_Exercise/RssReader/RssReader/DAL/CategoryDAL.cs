using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using RssReader.Model;
using RssReader.Util;

namespace RssReader.DAL
{
    public static class CategoryDAL
    {
        //得到所有 RSS 信息
        public static List<CategoryInfo> GetAllCategories()
        {
            string commandText = $"SELECT * FROM [category]";

            DataTable resultDataTable = DBHelper.GetDataTableByCommand(commandText);

            return (from c in resultDataTable.AsEnumerable()
                select new CategoryInfo()
                {
                    ID = Convert.ToInt32(c.Field<int>("ID")),
                    CategoryName = c.Field<string>("CategoryName"),
                }).ToList();
        }

        //根据 ID 得到某一个 RSS 信息
        public static CategoryInfo GetCategoryById(int id)
        {
            string commandText = $"SELECT * FROM [category] " +
                                 $"WHERE ID = {id}";
            DataTable resultDataTable = DBHelper.GetDataTableByCommand(commandText);
            return (from c in resultDataTable.AsEnumerable()
                select new CategoryInfo()
                {
                    ID = Convert.ToInt32(c.Field<int>("ID")),
                    CategoryName = c.Field<string>("CategoryName"),
                }).ToList().First();
        }

        //添加新的 RSS 信息
        public static void Add(CategoryInfo categoryInfo)
        {
            string commandText = $"INSERT INTO [category] (CategoryName) " +
                                 $"VALUES ('{categoryInfo.CategoryName}')";
            DBHelper.ExecuteNonQuery(commandText);
        }

        //根据 ID 删除指定的 RSS 信息
        public static void Delete(string id)
        {
            string commandText = $"DELETE FROM [category] " +
                                 $"WHERE id = {id}";
            DBHelper.ExecuteNonQuery(commandText);
        }

        //修改指定的 RSS 信息
        public static void Update(int id, CategoryInfo categoryInfo)
        {
            string commandText = $"UPDATE [category] " +
                                 $"SET CategoryName = '{categoryInfo.CategoryName}'" +
                                 $"WHERE ID = {id}";
            DBHelper.ExecuteNonQuery(commandText);
        }
    }
}