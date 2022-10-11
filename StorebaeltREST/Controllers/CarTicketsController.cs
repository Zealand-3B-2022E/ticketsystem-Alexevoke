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
        public List<StorebaeltCar> Get(string licenseplate)
        {
            return mgr.GetByLicenseplate(licenseplate);
        }

        // POST api/<CarTicketsController>
        [HttpPost]
        public StorebaeltCar Post([FromBody] StorebaeltCar car)
        {
            return mgr.Create(car);
        }

        
    }
}
