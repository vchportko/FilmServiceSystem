using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmServiceSystem.Model;
using System.Data.SqlClient;

namespace FilmServiceSystem.DAL.Abstraction.Repositories
{
    public interface IUserRepository: IGenericRepository<User>
    {
        User GetUserByLogin(string login, string password);
        double GetBalance(int userID);
        void RegisterUser(string login, string pass, string name, string surname);
    }
}
