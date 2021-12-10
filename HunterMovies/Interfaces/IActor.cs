using HunterMovies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HunterMovies.Interfaces
{
    public interface IActor
    {
        IEnumerable<Actor> getActors();
        Actor getsActorsbyId(Guid id);
        Actor saveActor(Actor actor);
        Actor deleteActor(Guid id);
    }
}
