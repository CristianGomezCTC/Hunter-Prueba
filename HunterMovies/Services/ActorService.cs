using HunterMovies.Interfaces;
using HunterMovies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HunterMovies.Services
{
    public class ActorService : IActor
    {
        private HunterContext context;
        public ActorService(HunterContext _context)
        {
            context = _context;
        }
        public Actor deleteActor(Guid id)
        {
            Actor actortoDelete = getsActorsbyId(id);
            if(actortoDelete != null)
            {
                context.Actors.Remove(actortoDelete);
                context.SaveChanges();
            }
            return actortoDelete;
        }

        public IEnumerable<Actor> getActors()
        {
            return context.Actors.ToList();
        }

        public Actor getsActorsbyId(Guid id)
        {
            return context.Actors.FirstOrDefault(x=> x.Id == id);
        }

        public Actor saveActor(Actor actor)
        {
            
            if(actor.Id == Guid.Empty)
            {
                actor.Id = Guid.NewGuid();
                context.Actors.Add(actor);
                context.SaveChanges();
            }
            else
            {
                Actor actortoUpdate = context.Actors.Find(actor.Id);
                actortoUpdate.Name = actor.Name;
                actortoUpdate.Age = actor.Age;
                context.Actors.Update(actortoUpdate);
                context.SaveChanges();
    
            }

            return actor;
        }
    }
}
