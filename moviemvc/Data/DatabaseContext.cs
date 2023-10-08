using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using moviemvc.Models.Domain;

namespace moviemvc.Data
{
    public class DatabaseContext : IdentityDbContext<ApplicationUser>
    {
        public DatabaseContext (DbContextOptions<DatabaseContext> options):base(options)
        {
        }
        public DbSet<Genre> Genres {get; set; }
        public DbSet<Movie> Movies {get; set; } 
        public DbSet<MovieGenre> MovieGenres { get; set; }
        public DbSet<Slider> Sliders { get; set; }
    }
}
