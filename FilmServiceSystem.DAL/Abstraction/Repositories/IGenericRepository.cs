using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FilmServiceSystem.DAL.Abstraction.Repositories
{
    public interface IGenericRepository<IEntity> where IEntity : class, new()
    {
        IEnumerable<IEntity> ExecuteReader(string spName, Func<SqlDataReader, IEntity> callback, SqlParameter[] parameters=null);
        object ExecuteReaderSingle(string spName, Func<SqlDataReader, object> callback, SqlParameter[] parameters);
        object ExecuteReaderWithParams(string spName,  SqlParameter[] parameters);
    }
}
