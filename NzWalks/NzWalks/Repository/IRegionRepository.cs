using NzWalks.Models.Domain;

namespace NzWalks.Repository
{
    public interface IRegionRepository
    {   // Task use for asynchronous GetAll-> GetAllAsync
        Task<IEnumerable<Region>> GetAllAsync();
    }
}
