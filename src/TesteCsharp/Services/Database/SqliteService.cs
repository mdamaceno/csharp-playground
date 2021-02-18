
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json;
using Microsoft.Data.Sqlite;

namespace TesteCsharp.Services.Database
{
    public class SqliteService
    {
        public static SqliteConnection ConnectDB(string databasePath)
        {
            SqliteConnection connection = new SqliteConnection("Data Source=" + databasePath);
            connection.Open();

            return connection;
        }

        public static void DisconnectDB(SqliteConnection connection)
        {
            connection.Close();
        }

        public static List<Dictionary<string, dynamic>> Query(SqliteConnection connection, string statement, object parameters = null)
        {
            var command = connection.CreateCommand();
            command.CommandText = @statement;

            if (parameters != null)
            {
                foreach (var p in parameters.GetType().GetProperties())
                {
                    command.Parameters.AddWithValue("$" + p.Name, p.GetValue(parameters, null));
                }
            }

            var reader = command.ExecuteReader();
            Object[] values = new Object[reader.FieldCount];
            List<Dictionary<string, dynamic>> result = new List<Dictionary<string, dynamic>>();

            while (reader.Read()) {
                var dict = new Dictionary<string, dynamic>();
                int fieldCount = reader.GetValues(values);

                for (int i = 0; i < fieldCount; i++)
                    dict.Add(reader.GetName(i), values[i]);

                result.Add(dict);
            }

            return result;
        }
    }
}
