using WebApplication2.Data;
using WebApplication2.Model.Domain;
namespace WebApplication2.Repositories
{
     public class RegionRepository : IRegionRepository
     {
        private readonly WalksDbContext walksDbContext;
        public RegionRepository(WalksDbContext walksDbContext)
        {
            this.walksDbContext = walksDbContext;
        }

        public WalksDbContext GetWalksDbContext()
        {
            return walksDbContext;
        }

        public IEnumerable<Region> GetAll(WalksDbContext walksDbContext) => walksDbContext.Regions.ToList();

        /// <exception cref="NotImplementedException"></exception>
        public IEnumerable<Region> GetAll()
        {
            throw new NotImplementedException();
        }

        /// <exception cref="NotImplementedException"></exception>
        public IEnumerable<Region> GetAll(object v)
        {
            throw new NotImplementedException();
        }

        /// <exception cref="NotImplementedException"></exception>
        object IRegionRepository.GetWalksDbContext()
        {
            throw new NotImplementedException();
        }
    }
}