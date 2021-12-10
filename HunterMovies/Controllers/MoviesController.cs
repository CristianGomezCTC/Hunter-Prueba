using HunterMovies.Interfaces;
using HunterMovies.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HunterMovies.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private IMovie movie;

        public MoviesController(IMovie _movie)
        {
            movie = _movie;
        }
        // GET: api/<ActorController>
        [HttpGet]
        public IActionResult GetMovies()
        {
            var response = movie.getMovies();
            return Ok(response);
        }

        [HttpPost("{id}")]
        public IActionResult GetMoviesById([FromBody] Guid id)
        {
            var response = movie.getsMoviesbyId(id);

            if (response == null)
                return NotFound(new { message = "Movie not found" });
            return Ok(response);
        }

        [HttpPost]
        public IActionResult SaveMovies([FromBody] Movie movies)
        {
            var response = movie.saveMovie(movies);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMovie([FromBody] Guid id)
        {
            var response = movie.deleteMovie(id);
            return Ok(response);
        }

    }
}
