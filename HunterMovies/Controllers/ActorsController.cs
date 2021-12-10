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
    public class ActorsController : ControllerBase
    {
        private IActor actor;

        public ActorsController(IActor _actor)
        {
            actor = _actor;
        }
        // GET: api/<ActorController>
        [HttpGet]
        public IActionResult GetActors()
        {
            var response = actor.getActors();
            return Ok(response);
        }

        [HttpPost("{id}")]
        public IActionResult GetActorsById([FromBody] Guid id)
        {
            var response = actor.getsActorsbyId(id);

            if (response == null)
                return NotFound(new { message = "Actor not found" });
            return Ok(response);
        }

        [HttpPost]
        public IActionResult SaveActors([FromBody] Actor actors)
        {
            var response = actor.saveActor(actors);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteActor([FromBody] Guid id)
        {
            var response = actor.deleteActor(id);
            return Ok(response);
        }

    }
}
