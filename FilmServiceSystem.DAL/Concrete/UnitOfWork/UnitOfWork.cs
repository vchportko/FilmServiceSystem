using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmServiceSystem.DAL.Abstraction.Repositories;
using FilmServiceSystem.DAL.Concrete.Repositories;

namespace FilmServiceSystem.DAL.Concrete.UnitOfWork
{
    public class UnitOfWork
    {
        #region Fields
        protected readonly string _connectionString;
        private IFilmRepository _filmRepository;
        private IOrderRepository _orderRepository;
        private IUserRepository _userRepository;
        #endregion

        #region Constructors
        public UnitOfWork(string connectionString)
        {
            _connectionString = connectionString;
        }
        #endregion

        #region Properties
        public IFilmRepository FilmRepository
        {
            get
            {
                return _filmRepository ?? (_filmRepository = new FilmRepository(_connectionString));
            }
        }

        public IOrderRepository OrderRepository
        {
            get
            {
                return _orderRepository ?? (_orderRepository = new OrderRepository(_connectionString));
            }
        }

        public IUserRepository UserRepository
        {
            get
            {
                return _userRepository ?? (_userRepository = new UserRepository(_connectionString));
            }
        }
        #endregion
    }
}
