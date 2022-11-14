using Microsoft.AspNetCore.Mvc;
using WebApplication2.Repositories;

namespace WebApplication2.Controllers
{
    [Microsoft.AspNetCore.Mvc.ApiController]
    [Route("[controller]")]
    public class RegionsController : Controller
    {
        private readonly IRegionRepository regionRepository;

        public RegionsController(IRegionRepository regionRepository)
        {
            this.regionRepository = regionRepository;
        }

        [HttpGet]
        public IActionResult GetAllRegion()
        {
            var regions= regionRepository.GetAll(regionRepository.GetWalksDbContext());
            return Ok(regions);
        }
    }
}
