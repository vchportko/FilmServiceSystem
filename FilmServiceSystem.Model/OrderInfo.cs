using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmServiceSystem.Model
{
    public class OrderInfo:Order
    {
        public string Login { get; set; }
        public string FilmTitle { get; set; }
        public double FilmPrice { get; set; }
    }
}
