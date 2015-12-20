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

        public static CategoryInfo GetCategoryById(int id)
        {
            string commandText = $"SELECT * FROM [category]" +
                                 $"WHERE ID = {id}";
            DataTable resultDataTable = DBHelper.GetDataTableByCommand(commandText);
            return (from c in resultDataTable.AsEnumerable()
                    select new CategoryInfo()
                    {
                        ID = Convert.ToInt32(c.Field<int>("ID")),
                        CategoryName = c.Field<string>("CategoryName"),
                    }).ToList().First();
        }

        public static void Add(CategoryInfo categoryInfo)
        {
            string commandText = $"INSERT INTO [category]" +
                                 $"VALUES ({categoryInfo.CategoryName})";
            DBHelper.ExecuteNonQuery(commandText);
        }

        public static void Delete(string id)
        {
            string commandText = $"DELETE FROM [category]" +
                                 $"WHERE id = {id}";
            DBHelper.ExecuteNonQuery(commandText);
        }
    }
}