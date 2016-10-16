using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmServiceSystem.DAL.SQL
{
    public static class StoredProcedureName
    {
        #region Properties
        public const string spGetAllUsers = "[dbo].[spGetAllUsers]";
        public const string spGetUserByLogin = "[dbo].[spGetUserByLogin]";
        public const string spGetAvailableFilm = "[dbo].[spGetAvailableFilm]";
        public const string spGetBalance = "[dbo].[spGetBalance]";
        public const string spGetUserHistory = "[dbo].[spGetUserHistory]";
        public const string spMakeOrder = "[dbo].[spMakeOrder]";
        public const string spSortByFilmIMDb = "[dbo].[spSortByFilmIMDb]";
        public const string spSortByFilmIMDbInGenre = "[dbo].[spSortByFilmIMDbInGenre]";
        public const string spRegisterUser = "[dbo].[spRegisterUser]";
        #endregion
    }
}
