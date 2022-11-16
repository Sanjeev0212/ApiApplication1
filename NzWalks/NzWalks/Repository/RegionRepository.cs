using NzWalks.Data;
using NzWalks.Models.Domain;

namespace NzWalks.Repository
{
    public class RegionRepository : IRegionRepository
    {
        private readonly NzWalksDbContext nzWalksDbContext;

        public RegionRepository(NzWalksDbContext nzWalksDbContext)
        {
            this.nzWalksDbContext = nzWalksDbContext;
        }
        public IEnumerable<Region> GetAll()
        {
            return nzWalksDbContext.Regions.ToList();
        }
    }
}
