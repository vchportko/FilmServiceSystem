using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmServiceSystem.Model;
using System.Data.SqlClient;

namespace FilmServiceSystem.Parser
{
    public static class OrderParser
    {
        #region Methods
        public static OrderInfo MakeOrderInfoModel(SqlDataReader reader)
        {
            // get model fields from reader (checking nullable of data) 
            OrderInfo model = new OrderInfo();
            model.Login = reader["Login"] is DBNull ? string.Empty : reader["Login"].ToString();
            model.FilmTitle = reader["Title"] is DBNull ? string.Empty : reader["Title"].ToString();
            model.FilmPrice = reader["Price"] is DBNull ? 0 : Convert.ToDouble(reader["Price"]);
            model.OrderDate = reader["OrderDate"] is DBNull ? string.Empty : reader["OrderDate"].ToString();

            return model;
        }
        #endregion

    }
}
