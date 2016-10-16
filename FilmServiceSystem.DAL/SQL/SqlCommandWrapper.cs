using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FilmServiceSystem.DAL.SQL
{
    public class SqlCommandWrapper
    {
        #region Fields
        private readonly string _connectionString;
        #endregion

        #region Constructors
        public SqlCommandWrapper(string connectionString)
        {
            _connectionString = connectionString;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Execute stored procedure passing by name and than execute callback using SqlDataReader
        /// </summary>
        /// /// <param name="callback">Callback return IEntity </param>
        public object ExecuteReader<T>(CommandType commandType,string commandText, SqlParameter[] parameters=null, Func<SqlDataReader, T> callback = null)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand(commandText, connection) { CommandType = CommandType.StoredProcedure })
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    connection.Open();
                    command.CommandTimeout = 0;

                    var reader = command.ExecuteReader();
                    object result;

                    using (reader)
                    {
                        var list = new List<T>();
                        while (reader.Read())
                        {
                            if (callback != null)
                            {
                                var item = callback(reader);
                                if (!Equals(item, default(T)))
                                {
                                    list.Add(item);
                                }
                            }
                        }
                        result = list;
                    }

                    return result;
                }
            }
        }

        /// <summary>
        /// Execute stored procedure passing by name and than execute callback using SqlDataReader
        /// </summary>
        /// <param name="callback">Callback return object </param>
        public object ExecuteReader(CommandType commandType, string commandText, SqlParameter[] parameters = null, Func<SqlDataReader, object> callback = null)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand(commandText, connection) { CommandType = CommandType.StoredProcedure })
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    connection.Open();
                    command.CommandTimeout = 0;

                    var reader = command.ExecuteReader();
                    double result = 0;
                    using (reader)
                    {
                        if (reader.Read())
                        {
                            if (callback != null)
                            {
                               return Convert.ToDouble(callback(reader));

                            }
                        }
                    }
                    return result;
                }
            }
        }

        /// <summary>
        /// Execute stored procedure passing by name
        /// </summary>
        public object ExecuteReaderWithParams<T>(CommandType commandType, string commandText, SqlParameter[] parameters)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand(commandText, connection) { CommandType = CommandType.StoredProcedure })
                {
                    command.Parameters.AddRange(parameters);
                    connection.Open();
                    command.CommandTimeout = 0;

                    return command.ExecuteReader();
               
                }
            }
        }
        #endregion

    }
}
