using DesignPatternASP.Models;
using Microsoft.EntityFrameworkCore;

namespace DesignPatternASP.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Beer> Beers { get; set; }
    }

    
}
