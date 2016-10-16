using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmServiceSystem.DAL.Abstraction.Repositories;
using FilmServiceSystem.Model;
using System.Data.SqlClient;
using System.Data;
using FilmServiceSystem.DAL.SQL;
using FilmServiceSystem.Parser;

namespace FilmServiceSystem.DAL.Concrete.Repositories
{
    public class OrderRepository: GenericRepository<OrderInfo>, IOrderRepository
    {
        #region Constructors
        public OrderRepository(string connectionString):base(connectionString)
        {
        }
        #endregion

        #region Methods
        /// <summary>
        /// Create order.
        /// </summary>
        public int MakeOrder(int userID, int FilmID, string OrderDate)
        {
            var result = new SqlParameter("@result", -1)
            {
                Direction = ParameterDirection.Output
            };
            SqlParameter dateParameter = new SqlParameter("@OrderDate", SqlDbType.DateTime);
            dateParameter.Value = OrderDate;
            var parametrs = new[]
                {
                    new SqlParameter("@UserID",userID),
                    new SqlParameter("@FilmID",FilmID),
                    dateParameter,
                    result
                };

            ExecuteReaderWithParams(StoredProcedureName.spMakeOrder, parametrs);
            return result.Value != null ? Convert.ToInt32(result.Value) : -1;
         }

        /// <summary>
        /// Give information how many films some user bought
        /// </summary>
        public List<OrderInfo> getOrderHistoryOfUser(int userID)
        {
            SqlParameter[] parametr =
            {
                new SqlParameter("@UserID", userID)
            };
            return new List<OrderInfo>(ExecuteReader(StoredProcedureName.spGetUserHistory, OrderParser.MakeOrderInfoModel, parametr));

        }
        #endregion

    }
}
