using WebApplication2.Model.Domain;

namespace WebApplication2.Repositories
{
    public interface IRegionRepository
    {
        IEnumerable<Region> GetAll();

       
    }
}
