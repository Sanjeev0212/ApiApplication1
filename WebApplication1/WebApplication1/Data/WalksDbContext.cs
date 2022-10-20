using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Security.Cryptography.X509Certificates;
using WebApplication1.Models.Domain;

namespace WebApplication1.Data
{
    public class WalksDbContext : DbContext
    {
        public WalksDbContext(DbContextOptions<WalksDbContext> options): base(options)
        {
            
        }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> walks { get; set; }
        public DbSet<WalkDifficulty> walkDifficulties { get; set; }



    }
}
