using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmServiceSystem.Model
{
    public class Order
    {
        public int UserID { get; set; }
        public int FilmID { get; set; }
        public string OrderDate { get; set; }
    }
}
