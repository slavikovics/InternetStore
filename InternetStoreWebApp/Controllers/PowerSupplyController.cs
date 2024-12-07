using InternetStore;
using InternetStore.StoreFilters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InternetStoreWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PowerSupplyController : ControllerBase
    {
        private readonly Context _context;

        public PowerSupplyController(Context context)
        {
            _context = context;
        }
        
        [HttpGet("GetAllPowerSupplies")]
        public IEnumerable<PowerSupply> Get()
        {
            return _context.PowerSupplies;
        }
        
        [HttpGet("GetPowerSupplyById")]
        public PowerSupply Get(int id)
        {
            return _context.PowerSupplies.Find(id);
        }
        
        [HttpPost("CreatePowerSupply")]
        public ActionResult<PowerSupply> Post(string name, decimal price, string manufacturer, double wattage, PowerSupplyCertificate certificate)
        {
            try
            {
                PowerSupply powerSupply = new PowerSupply(name, price);
                powerSupply.Manufacturer = manufacturer;
                powerSupply.Wattage = wattage;
                powerSupply.Certificate = certificate;
                _context.PowerSupplies.Add(powerSupply);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                return StatusCode(500, new { Message = "An error occurred", Details = e.Message });
            }

            return Ok();
        }

        [HttpPut("UpdatePowerSupply")]
        public ActionResult<PowerSupply> Put(int id, string manufacturer, double wattage, PowerSupplyCertificate certificate)
        {
            try
            {
                PowerSupply foundPowerSupply = _context.Find<PowerSupply>(id);
                foundPowerSupply.Manufacturer = manufacturer;
                foundPowerSupply.Wattage = wattage;
                foundPowerSupply.Certificate = certificate;
                
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, new { Message = "An error occurred", Details = e.Message });
            }
        }
        
        [HttpDelete("DeletePowerSupply")]
        public ActionResult<PowerSupply> Delete(int id)
        {
            try
            {
                _context.PowerSupplies.Remove(_context.PowerSupplies.Find(id));
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, new { Message = "An error occurred", Details = e.Message });
            }
        }
    }
}
