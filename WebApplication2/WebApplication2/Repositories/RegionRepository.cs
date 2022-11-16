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
            this.walksDbContext = walksDbContext;
        }

        public WalksDbContext GetWalksDbContext()
<<<<<<< HEAD
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
=======
        {
            return walksDbContext;
>>>>>>> 8b088edeca7bce3b1ff598ff0894a48641d70be5
        }

        public IEnumerable<Region> GetAll(WalksDbContext walksDbContext) => walksDbContext.Regions.ToList();
    }
}