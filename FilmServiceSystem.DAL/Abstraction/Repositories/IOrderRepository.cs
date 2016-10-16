using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmServiceSystem.Model;
using System.Data.SqlClient;
using System.Data;

namespace FilmServiceSystem.DAL.Abstraction.Repositories
{
    public interface IOrderRepository: IGenericRepository<OrderInfo>
    {
         int MakeOrder(int userID, int FilmID, string OrderDate);
         List<OrderInfo> getOrderHistoryOfUser(int userID);
    }
}
