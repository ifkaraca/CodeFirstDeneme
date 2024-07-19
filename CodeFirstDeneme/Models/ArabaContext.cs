using Microsoft.EntityFrameworkCore;

namespace CodeFirstDeneme.Models
{
    public class ArabaContext:DbContext
    {
        public ArabaContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Araba> Araba { get; set; }
    }
}
