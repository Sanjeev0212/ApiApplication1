using WebApplication2.Data;
using WebApplication2.Model.Domain;

namespace WebApplication2.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly WalksDbContext walksDbContext;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public RegionRepository(WalksDbContext walksDbContext)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {

        }

        public WalksDbContext GetWalksDbContext()
        {
            return walksDbContext;
        }

        public IEnumerable<Region> GetAll(WalksDbContext walksDbContext) => walksDbContext.Regions.ToList();
    }
}
