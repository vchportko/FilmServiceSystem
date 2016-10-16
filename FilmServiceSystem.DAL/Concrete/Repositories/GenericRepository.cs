using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmServiceSystem.DAL.Abstraction.Repositories;
using FilmServiceSystem.Model;
using System.Data.SqlClient;
using System.Data;
using FilmServiceSystem.DAL.SQL;

namespace FilmServiceSystem.DAL.Concrete.Repositories
{
    public class GenericRepository<IEntity> : IGenericRepository<IEntity> where IEntity : class, new()
    {
        #region Fields
        private SqlCommandWrapper _sqlWrapper;
        #endregion

        #region Constructors
        public GenericRepository(string connectionString)
        {
            _sqlWrapper = new SqlCommandWrapper(connectionString);
        }
        #endregion

        #region Methods
        /// <summary>
        /// Execute stored procedure passing by name and than execute callback using SqlDataReader
        /// </summary>
        /// /// <param name="callback">Callback return IEntity </param>
        public IEnumerable<IEntity> ExecuteReader(string spName, Func<SqlDataReader, IEntity> callback, SqlParameter[] parameters)
        {
            var result = _sqlWrapper.ExecuteReader(CommandType.StoredProcedure, spName, parameters, callback);
            return (IEnumerable<IEntity>)result;
        }

        /// <summary>
        /// Execute stored procedure passing by name and than execute callback using SqlDataReader
        /// </summary>
        /// <param name="callback">Callback return object </param>
        public object ExecuteReaderSingle(string spName, Func<SqlDataReader, object> callback, SqlParameter[] parameters)
        {
            var result = _sqlWrapper.ExecuteReader(CommandType.StoredProcedure, spName, parameters, callback);
            return result;
        }

        /// <summary>
        /// Execute stored procedure passing by name
        /// </summary>
        public object ExecuteReaderWithParams(string spName, SqlParameter[] parameters)
        {
            object result = _sqlWrapper.ExecuteReaderWithParams<IEntity>(CommandType.StoredProcedure, spName, parameters);
            return result;
        }
        #endregion
    }
}
