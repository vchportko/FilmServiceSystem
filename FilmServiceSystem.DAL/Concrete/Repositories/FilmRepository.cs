using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmServiceSystem.DAL.Abstraction.Repositories;
using FilmServiceSystem.Model;
using FilmServiceSystem.DAL.SQL;
using System.Data.SqlClient;
using System.Data;
using FilmServiceSystem.Parser;

namespace FilmServiceSystem.DAL.Concrete.Repositories
{
    public class FilmRepository: GenericRepository<FilmInfo>, IFilmRepository
    {
        #region Constructor
        public FilmRepository(string connectionString):base(connectionString)
        {          
        }
        #endregion

        #region Methods
        /// <summary>
        /// Get list of sorted films by IMDb rating
        /// </summary>
        public List<FilmInfo> getSortedFilmByIMDb()
        {
            return new List<FilmInfo>(ExecuteReader(StoredProcedureName.spSortByFilmIMDb,FilmParser.MakeFilmInfoModel,null));
        }

        /// <summary>
        /// Get list of sorted films by IMDb rating and genre.
        /// </summary>
        public List<FilmInfo> getSortedFilmByGenre(string genre)
        {
            SqlParameter[] parametr = {new SqlParameter("@Genre", genre) };
            return new List<FilmInfo>(ExecuteReader(StoredProcedureName.spSortByFilmIMDbInGenre, FilmParser.MakeFilmInfoModel, parametr));           
        }

        /// <summary>
        /// Get list of available films.
        /// </summary>
        public List<FilmInfo> getAvailableFilm()
        {
            return new List<FilmInfo>(ExecuteReader(StoredProcedureName.spGetAvailableFilm, FilmParser.MakeFilmInfoModel, null));           
        }
        #endregion
    }
}
