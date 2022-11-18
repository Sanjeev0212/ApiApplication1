using Microsoft.EntityFrameworkCore;
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
        public async Task<IEnumerable<Region>> GetAllAsync()
        {
            // ToListAsync is use for Asynchronous, await and async is also use in asynchronous 
            return await nzWalksDbContext.Regions.ToListAsync();
        }
    }
}
