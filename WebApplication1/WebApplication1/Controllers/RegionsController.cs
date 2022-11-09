using Microsoft.AspNetCore.Mvc;
using System.Net.WebSockets;
using System.Runtime;
using WebApplication1.Models.Domain;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionsController : Controller
    {
        [HttpGet]
       public IActionResult GetAllRegions() {
            var regions = new List<Region>()
            {
                new Region
                {
                    Id=Guid.NewGuid(),
                    Name="Wellington",
                    Code=101,
                    Area=221202,
                    Lat=-1.2554,
                    Long=299.88,
                    Population=50000

                },
                new Region
                {
                    Id=Guid.NewGuid(),
                    Name="Auckland",
                    Code=102,
                    Area=221203,
                    Lat=-1.433,
                    Long=399.88,
                    Population=30000

                }
            };
            return Ok(regions);
       }
    }
}
