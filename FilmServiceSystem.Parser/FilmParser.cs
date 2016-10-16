using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmServiceSystem.Model;
using System.Data.SqlClient;

namespace FilmServiceSystem.Parser
{
    public static class FilmParser
    {
        #region Methods
        public static FilmInfo MakeFilmInfoModel(SqlDataReader reader)
        {
            FilmInfo model = new FilmInfo();

            // get model fields from reader (checking nullable of data) 
            model.ID = reader["ID"] is DBNull ? 0 : Convert.ToInt32(reader["ID"]);
            model.Title = reader["Title"] is DBNull ? string.Empty:reader["Title"].ToString();
            model.YearRelease = reader["YearRelease"] is DBNull ? 0 : Convert.ToInt32(reader["YearRelease"]);
            model.Genre = reader["Genre"] is DBNull ? string.Empty : reader["Genre"].ToString();
            model.IMDb = reader["IMDb"] is DBNull ? 0 : Convert.ToDouble(reader["IMDb"]);
            model.Price = reader["Price"] is DBNull ? 0 : Convert.ToDouble(reader["Price"]);
            model.DirectorName = reader["Director"] is DBNull ? string.Empty : reader["Director"].ToString();

            return model;
        }
        #endregion
    }
}
