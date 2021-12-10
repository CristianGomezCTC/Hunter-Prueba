using HunterMovies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HunterMovies.Interfaces
{
    public interface IMovie
    {
        IEnumerable<Movie> getMovies();
        Movie getsMoviesbyId(Guid id);
        Movie saveMovie(Movie movie);
        Movie deleteMovie(Guid id);
    }
}
