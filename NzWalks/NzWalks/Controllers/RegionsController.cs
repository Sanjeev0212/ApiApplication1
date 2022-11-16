using Microsoft.AspNetCore.Mvc;
using NzWalks.Models.Domain;
using NzWalks.Repository;

namespace NzWalks.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionsController : Controller
    {
        private readonly IRegionRepository regionRepository;

        public RegionsController(IRegionRepository regionRepository)
        {
            this.regionRepository = regionRepository;
        }
        [HttpGet]
        public IActionResult GetAllRegions()
        {
            var regions = regionRepository.GetAll();
            return Ok(regions);
        }
    }
}
