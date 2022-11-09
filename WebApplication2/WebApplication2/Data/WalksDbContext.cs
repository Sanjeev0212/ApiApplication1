using Microsoft.EntityFrameworkCore;
using WebApplication2.Model.Domain;

namespace WebApplication2.Data
{
    public class WalksDbContext:DbContext
    {
        public WalksDbContext(DbContextOptions<WalksDbContext> options) : base(options)
        {

        }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walks> Walks { get; set; }
        public DbSet<WalkDifficulty> Walkdifficulty { get; set; }

    }
}
