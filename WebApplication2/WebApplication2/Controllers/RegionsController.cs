using Microsoft.AspNetCore.Mvc;
using WebApplication2.Model.Domain;
namespace WebApplication2.Controllers
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
                new Region()
                {
                    Id=Guid.NewGuid(),
                    Name="Wellington",
                    Code=105,
                    Area=22123,
                    Long
                }
            }; 
        }
    }
}
