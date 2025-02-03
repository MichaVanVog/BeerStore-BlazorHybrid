using BeerStore.CoreBusiness;
using Microsoft.EntityFrameworkCore;

namespace BeerStore.Db
{
    public class DatabaseContext(DbContextOptions<DatabaseContext> options) : DbContext(options)
    {
        public DbSet<Subdivision> Subdivisions { get; set; }
    }
}
