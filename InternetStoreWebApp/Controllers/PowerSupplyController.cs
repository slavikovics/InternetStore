using InternetStore;
using InternetStore.StoreFilters;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InternetStoreWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PowerSupplyController : ControllerBase
    {
        public TestLists TestLists = new TestLists();

        // GET: api/<GetAllPowerSupplies>
        [HttpGet("GetAllPowerSupplies")]
        public IEnumerable<PowerSupply> Get()
        {
            return TestLists.powerSupplies;
        }

        // GET api/<PowerSupplyController>/5
        [HttpGet("GetPowerSupplyByID")]
        public PowerSupply Get(int id)
        {
            return PowerSuppliesFilter.FindPowerSupplyById(TestLists.powerSupplies, id);
        }

        // POST api/<PowerSupplyController>
        [HttpPost("PostPowerSupply")]
        public void Post(string name, int id, decimal price)
        {
            PowerSupply powerSupply = new PowerSupply(name, id, price);
            TestLists.powerSupplies.Add(powerSupply);
        }

        // DELETE api/<PowerSupplyController>/5
        [HttpDelete("DeletePowerSupply")]
        public void Delete(int id)
        {
           TestLists.powerSupplies.Remove(PowerSuppliesFilter.FindPowerSupplyById(TestLists.powerSupplies, id));
        }
    }
}
