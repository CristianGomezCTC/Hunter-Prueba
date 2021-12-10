using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HunterMovies.Models
{
    public class HunterContext : DbContext
    {
        public HunterContext(DbContextOptions<HunterContext> options): base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Actor> Actors { get; set; }

    }
}
