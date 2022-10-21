using Microsoft.AspNetCore.Mvc;
using System.Runtime;
using WebApplication1.Models.Domain;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class RegionsController : Controller
    {
        [HttpGet]
        public IActionResult GetAllRegion()
        {
            var region = new List<Region>()
            {
                new Region
                {
                    Id=Guid.NewGuid(),
                    Name="Wellington",
                    Code=321,
                    Area=221202,
                    Lat=-1.8822,
                    Long=299.88,
                    Population=50000
                },
                new Region
                {
                    Id=Guid.NewGuid(),
                    Name="Auckl",
                    Code=212,
                    Area=221201,
                    Lat=-1.8822,
                    Long=299.88,
                    Population=50000
                }
            };
            return Ok(region);
        }
        
    }
}
