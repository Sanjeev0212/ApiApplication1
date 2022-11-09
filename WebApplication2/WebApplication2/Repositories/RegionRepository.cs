using WebApplication2.Data;
using WebApplication2.Model.Domain;

namespace WebApplication2.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly WalksDbContext walksDbContext;
        public RegionRepository(WalksDbContext walksDbContext)
        {

        }

        public IEnumerable<Region> GetAll()
        {
            return walksDbContext.Regions.ToList();
        }
    }
}
