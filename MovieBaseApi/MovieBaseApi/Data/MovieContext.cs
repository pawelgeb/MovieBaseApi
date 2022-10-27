using Microsoft.EntityFrameworkCore;
using MovieBaseApi.Models;

namespace MovieBaseApi.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext()
        {

        }
        public MovieContext(DbContextOptions<MovieContext> options): base (options)
        {
            
        }

        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<ActorRating> ActorRatings { get; set; }

    }
}
