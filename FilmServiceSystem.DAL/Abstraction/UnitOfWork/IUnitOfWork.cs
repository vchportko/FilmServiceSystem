using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmServiceSystem.DAL.Abstraction.Repositories;

namespace FilmServiceSystem.DAL.Abstraction.UnitOfWork
{
    interface IUnitOfWork
    {
        IFilmRepository FilmRepository { get; }

        IOrderRepository OrderRepository { get; }

        IUserRepository UserRepository { get; }

    }
}
