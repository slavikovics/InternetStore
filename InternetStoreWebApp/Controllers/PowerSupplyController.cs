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
        [HttpGet]
        public IEnumerable<PowerSupply> Get()
        {
            return TestLists.powerSupplies;
        }

        // GET api/<PowerSupplyController>/5
        [HttpGet("{id}")]
        public PowerSupply Get(string id)
        {
            return PowerSuppliesFilter.FindPowerSupplyById(TestLists.powerSupplies, id);
        }

        // POST api/<PowerSupplyController>
        [HttpPost]
        public void Post([FromBody] PowerSupply value)
        {
            TestLists.powerSupplies.Add(value);
        }

        // DELETE api/<PowerSupplyController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
           TestLists.powerSupplies.Remove(PowerSuppliesFilter.FindPowerSupplyById(TestLists.powerSupplies, id));
        }
    }
}
