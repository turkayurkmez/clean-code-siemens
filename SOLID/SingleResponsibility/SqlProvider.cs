using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class SqlProvider
    {
        private SqlConnection sqlConnection = null;
        public SqlProvider(string connectionString)
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public int ExecuteNonQuery(string sql, Dictionary<string,object> parameters) {

            SqlCommand sqlCommand = createCommand(sql, parameters);
            sqlCommand.Connection.Open();
            int rowsAffected = sqlCommand.ExecuteNonQuery();
            sqlCommand.Connection.Close();
            return rowsAffected;
        
        }

        private SqlCommand createCommand(string sql, Dictionary<string, object> parameters)
        {
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            addParametersToCommand(sqlCommand, parameters);
            return sqlCommand;
        }

        private void addParametersToCommand(SqlCommand sqlCommand, Dictionary<string, object> parameters)
        {
            foreach (var parameter in parameters)
            {
                sqlCommand.Parameters.AddWithValue(parameter.Key, parameter.Value);
            }
        }
    }
}
