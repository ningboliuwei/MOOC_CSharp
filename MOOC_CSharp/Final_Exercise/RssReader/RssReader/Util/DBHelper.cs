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
        private static readonly string DataPath = Application.StartupPath + "\\data.mdb";

        private static readonly string ConnectionString = $"Provider=Microsoft.Jet.OLEDB.4.0;" +
                                                          $"Data Source={DataPath}";

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