using Microsoft.AspNetCore.Mvc;
using StorebaeltREST.Managers;
using StoreBaeltTicketLibrary;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StorebaeltREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarTicketsController : ControllerBase
    {
        private CarTicketManager mgr = new CarTicketManager();
        
        
        // GET: api/<CarTicketsController>
        [HttpGet]
        public IEnumerable<StorebaeltCar> Get()
        {
            return mgr.GetAll();
        }

        // GET api/<CarTicketsController>/5
        [HttpGet("{licenseplate}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Get(string licenseplate)
        {
            try
            {
                return Ok(mgr.GetByLicenseplate(licenseplate));
            }
            catch (KeyNotFoundException knfe)
            {
                NotFound(knfe.Message);
            }
            return BadRequest();
        }

        // POST api/<CarTicketsController>
        [HttpPost]
        public StorebaeltCar Post([FromBody] StorebaeltCar car)
        {
            return mgr.Create(car);
        }

        
    }
}
