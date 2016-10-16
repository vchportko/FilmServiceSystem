using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmServiceSystem.Model;

namespace FilmServiceSystem.DAL.Abstraction.Repositories
{
    public interface IFilmRepository: IGenericRepository<FilmInfo>
    {
        List<FilmInfo> getSortedFilmByIMDb();
        List<FilmInfo> getSortedFilmByGenre(string genre);
        List<FilmInfo> getAvailableFilm();
    }
}
