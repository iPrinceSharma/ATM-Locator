using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ATMLocator.Database
{
    public class DatabaseUtility
    {

        private static DatabaseUtility instance;
        public static DatabaseUtility Instance
        {
            get
            {
                if (instance == null)
                    instance = new DatabaseUtility();
                return instance;
            }
        }

        private const string connectionString = "data source=DESKTOP-NVRLAML\\SQLEXPRESS; initial catalog=MyATM;Integrated Security=True";

        public DataTable Select(string storedProcedureorCommandText, bool isStoredProcedure = true)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    Console.WriteLine("Command Received:" + command);
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    if (!isStoredProcedure)
                    {
                        command.CommandType = CommandType.Text;
                    }

                    command.CommandText = storedProcedureorCommandText;
                    connection.Open();

                    Console.WriteLine("Fnal Command Received:" + command);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);

                    return dataTable;
                }
            }
        }

        public IEnumerable<T> ExcuteObject<T>(string storedProcedureorCommandText, bool isStoredProcedure = false)
        {
            List<T> items = new List<T>();
            var dataTable = Select(storedProcedureorCommandText, isStoredProcedure); //this will use the DataTable Select function
            foreach (var row in dataTable.Rows)
            {
                T item = (T)Activator.CreateInstance(typeof(T), row);
                items.Add(item);
            }
            return items;
        }
    }
}