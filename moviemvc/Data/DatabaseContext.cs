using Microsoft.EntityFrameworkCore;

namespace moviemvc.Data
{
    public class DatabaseContext : DbContext
    {
        protected DatabaseContext(DbContextOptions<DatabaseContext> options):base(options)
        {
        }

    }
}
