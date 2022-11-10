using Microsoft.AspNetCore.Mvc;
using WebApplication2.Model.Domain;
using WebApplication2.Repositories;
using WebApplication2.Model.DTO;
using System.Net.WebSockets;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionsController : Controller
    {
        private IRegionRepository regionRepository;

        public RegionsController(IRegionRepository regionRepository)
        {
            this.regionRepository = regionRepository;
        }

        [HttpGet]
        public IActionResult GetAllRegion()
        {
            var regions= regionRepository.GetAll();
            return Ok(regions);
        }
    }
}
