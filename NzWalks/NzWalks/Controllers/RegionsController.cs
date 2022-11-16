using Microsoft.AspNetCore.Mvc;
using NzWalks.Models.Domain;

namespace NzWalks.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionsController : Controller
    {
        [HttpGet]
        public IActionResult GetAllRegions()
        {
            var regions = new List<Region>()
            {
                new Region
                {
                    Id=Guid.NewGuid(),
                    Name="Wellington",
                    Code="WLG",
                    Area=221202,
                    Lat=-1.2536,
                    Long=29.34,
                    Population=15000,
                },
                
                new Region
                {
                    Id=Guid.NewGuid(),
                    Name="Auckland",
                    Code="AUCK",
                    Area=221203,
                    Lat=-1.5536,
                    Long=28.34,
                    Population=16000,
                }
            };
            return Ok(regions);
        }
    }
}
