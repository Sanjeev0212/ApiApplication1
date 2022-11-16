using NzWalks.Models.Domain;

namespace NzWalks.Repository
{
    public interface IRegionRepository
    {
        IEnumerable<Region> GetAll();
    }
}
