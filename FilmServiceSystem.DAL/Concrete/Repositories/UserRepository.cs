using System;
using System.Collections.Generic;
using FilmServiceSystem.DAL.Abstraction.Repositories;
using FilmServiceSystem.Model;
using System.Data.SqlClient;
using System.Data;
using FilmServiceSystem.DAL.SQL;
using FilmServiceSystem.DAL.Concrete.Services;
using FilmServiceSystem.Parser;


namespace FilmServiceSystem.DAL.Concrete.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        #region Constructor
        public UserRepository(string connectionString):base(connectionString)
        {
        }
        #endregion

        #region Methods
        /// <summary>
        /// User`s authorization
        /// </summary>
        public User GetUserByLogin(string login,string password)
        {
            SqlParameter[] parametrs =
             {
                new SqlParameter("@login",login),
                new SqlParameter("@password",Service.getHashSha256(password))
             };
             List<User> users=new List<User>(ExecuteReader(StoredProcedureName.spGetUserByLogin,UserParser.MakeUserModel, parametrs));
            return users.Count>0?users[0]:null;        
        }

        /// <summary>
        /// Get user balance
        /// </summary>
        public double GetBalance(int userID)
        {
           SqlParameter[] parameters =
           {
              new SqlParameter("@UserID", userID)
           };
           return Convert.ToDouble(ExecuteReaderSingle(StoredProcedureName.spGetBalance,UserParser.GetBalance, parameters));         
        }
        /// <summary>
        /// User registration
        /// </summary>
        public void RegisterUser(string login,string pass,string name,string surname)
        {
            SqlParameter[] parameters =
               {
                    new SqlParameter("@login", login),
                    new SqlParameter("@password", Service.getHashSha256(pass)),
                    new SqlParameter("@firstName", name),
                    new SqlParameter("@lastName", surname)
                };
            ExecuteReaderWithParams(StoredProcedureName.spRegisterUser, parameters);           
        }
        /// <summary>
        /// Get all users
        /// </summary>
        public List<User> GettAll()
        {
            return new List<User>(ExecuteReader(StoredProcedureName.spGetAllUsers, UserParser.MakeUserModel, null));
        }
        #endregion
    }
}
