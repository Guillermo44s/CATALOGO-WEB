using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsLogic
{
    public class Connection
    {
        //Catalogue
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        public SqlDataReader Reader
        {
            get { return reader; }
        }

        public Connection()
        {
            connection = new SqlConnection("Data Source=DESKTOP-ICI6NND\\SQLEXPRESS;Initial Catalog=CATALOGO_WEB_DB;User=sa;Password=esea");
            command = new SqlCommand();
        }

        public void SetQuery(string query)
        {
            command.CommandText = query;
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        public void SetParameters(string name, object value)
        {
            command.Parameters.AddWithValue(name, value);
        }

        public void ExecuteQuery()
        {
            command.Connection.Open();
            reader = command.ExecuteReader();
        }

        public void CloseConnection()
        {
            if (reader != null)
            {
                reader.Close();
                connection.Close();
            }
        }
    }
}
