using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RssReader.Util
{
    public static class DBHelper
    {
        //Access 数据库文件路径
        private static readonly string DataPath = Application.StartupPath + "\\data.mdb";

        //数据库连接字符串
        private static readonly string ConnectionString = $"Provider=Microsoft.Jet.OLEDB.4.0;" +
                                                          $"Data Source={DataPath}";

        //执行 SQL 命令并以 DataTable 形式返回数据
        public static DataTable GetDataTableByCommand(string commandText)
        {
            try
            {
                using (var connection = new OleDbConnection(ConnectionString))
                {
                    var adapter = new OleDbDataAdapter(commandText, connection);
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //执行无返回值 SQL 命令
        public static void ExecuteNonQuery(string commandText)
        {
            try
            {
                using (var connection = new OleDbConnection(ConnectionString))
                {
                    var command = new OleDbCommand(commandText, connection);

                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}