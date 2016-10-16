using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmServiceSystem.DAL.Concrete.Repositories;
using System.Configuration;

namespace FilmServiceSystem
{
    public static class CurrentUser
    {
        private static double balance;
        public static int ID { get; set; }
        public static string Login { get; set; }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static double Balance { get; set; }
    
    }
}
