using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmServiceSystem.Model
{
    public class Film
    {
        //the same in other models 
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int YearRelease { get; set; }
        public double Price { get; set; }
        public double IMDb { get; set; }
    }
}
