using Microsoft.AspNetCore.Mvc;
using WebApplication2.Model.Domain;
using WebApplication2.Repositories;
using WebApplication2.Model.DTO;

namespace WebApplication2.Controllers
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
            var regions=regionRepository.GetAll(regionRepository.GetWalksDbContext());


            // return DTO region
            var regionsDTO = new List<Model.DTO.Region>();
            regions.ToList().ForEach(region =>
            {
                var regionDTO =new Model.DTO.Region()
                {
                    Id = region.Id,
                    Code = region.Code,
                    Name = region.Name,
                    Area = region.Area,
                    Lat = region.Lat,
                    Long = region.Long,
                    Population = region.Population,
                };
                regionsDTO.Add(regionDTO);
            });
            return Ok(regionsDTO);
        }

       
       
    }
}
