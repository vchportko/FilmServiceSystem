using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmServiceSystem.Model;
using System.Data.SqlClient;

namespace FilmServiceSystem.Parser
{
    public static class UserParser
    {
        #region Methods
        public static User MakeUserModel(SqlDataReader reader)
        {
            // get model fields from reader (checking nullable of data) 
            var model = new User();
            model.ID = reader["ID"] is DBNull ? 0 : Convert.ToInt32(reader["ID"]);
            model.Balance = reader["Balance"] is DBNull ? 0 : Convert.ToDouble(reader["Balance"]);
            model.Login = reader["Login"] is DBNull ? string.Empty : reader["Login"].ToString();
            model.FirstName = reader["FirstName"] is DBNull ? string.Empty : reader["FirstName"].ToString();
            model.LastName = reader["LastName"] is DBNull ? string.Empty : reader["LastName"].ToString();
            return model;
        }

        public static object GetBalance(SqlDataReader reader)
        {
            return reader["Balance"] is DBNull ? 0 : Convert.ToDouble(reader["Balance"]);
        }
        #endregion

    }
}
