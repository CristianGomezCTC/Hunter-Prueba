using HunterMovies.Interfaces;
using HunterMovies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HunterMovies.Services
{
    public class MovieService : IMovie
    {
        private HunterContext context;
        public MovieService(HunterContext _context)
        {
            context = _context;
        }

        public Movie deleteMovie(Guid id)
        {
            Movie movietoDelete = getsMoviesbyId(id);
            if(movietoDelete != null)
            {
                context.Movies.Remove(movietoDelete);
                context.SaveChanges();
            }
            return movietoDelete;
        }

        public IEnumerable<Movie> getMovies()
        {
            return context.Movies.ToList();
        }

        public Movie getsMoviesbyId(Guid id)
        {
            return context.Movies.FirstOrDefault(x => x.Id == id);
        }

        public Movie saveMovie(Movie movie)
        {
           
            if (movie.Id == Guid.Empty)
            {
                movie.Id = Guid.NewGuid();
                context.Movies.Add(movie);
                context.SaveChanges();
            }
            else
            {
                Movie movietoUpdate = context.Movies.Find(movie.Id);
                movietoUpdate.Name = movie.Name;
                movietoUpdate.Category = movie.Category;
                movietoUpdate.Category = movie.Category;
                context.Movies.Update(movietoUpdate);
                context.SaveChanges();
     
            }

            return movie;
        }
    }
}

