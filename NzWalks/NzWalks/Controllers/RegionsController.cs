using AutoMapper;
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
        private readonly IMapper mapper;

        public RegionsController(IRegionRepository regionRepository, IMapper mapper)
        {
            this.regionRepository = regionRepository;
            this.mapper = mapper;
            
        }

  

        [HttpGet]
        public async Task<IActionResult> GetAllRegions()
        {
            var regions = await regionRepository.GetAllAsync();
            /*
            //Return Region DTO 
            var regionsDTO = new List<Models.DTO.Region>();
            regions.ToList().ForEach(region =>
            {
                var regionDTO = new Models.DTO.Region()
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
            });*/

            // uper DTOs commented because I want to use automapper.

            // Map Function 
            var regionsDTO = mapper.Map<List<Models.DTO.Region>>(regions);


            return Ok(regionsDTO);
        }
    }
}
