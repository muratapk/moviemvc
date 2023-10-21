
using Microsoft.EntityFrameworkCore;
using moviemvc.Models.Domain;

namespace moviemvc.Data
{
    public class DatabaseContext :DbContext
    {
        public DatabaseContext (DbContextOptions<DatabaseContext> options):base(options)
        {
        }
        public DbSet<Genre> Genres {get; set; }
        public DbSet<Movie> Movies {get; set; } 
        
    }
}
