using InternetStore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InternetStoreWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotherboardController : ControllerBase
    {
        private readonly Context _context;

        public MotherboardController(Context context)
        {
            _context = context;
        }
        
        [HttpGet("GetMotherboards")]
        public IEnumerable<Motherboard> Get()
        {
            return _context.Motherboards;
        }
        
        [HttpGet("GetMotherboardById")]
        public Motherboard Get(int id)
        {
            return _context.Motherboards.Find(id);
        }
        
        [HttpPost("CreateMotherboard")]
        public ActionResult<Motherboard> Post(string name, decimal price, string manufacturer, string supportedRandomAccessMemoryType, string socket, string chipset)
        {
            try
            {
                Motherboard motherboard = new Motherboard(name, price)
                {
                    Manufacturer = manufacturer,
                    SupportedRandomAccessMemoryType = supportedRandomAccessMemoryType,
                    Socket = socket,
                    Chipset = chipset
                };
                _context.Motherboards.Add(motherboard);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                return StatusCode(500, new { Message = "An error occurred", Details = e.Message });
            }

            return Ok();
        }

        [HttpPut("UpdateMotherboard")]
        public ActionResult<Motherboard> Put(int id, string manufacturer, string supportedRandomAccessMemoryType, string socket, string chipset)
        {
            try
            {
                Motherboard motherboard = _context.Find<Motherboard>(id);
                motherboard.Manufacturer = manufacturer;
                motherboard.SupportedRandomAccessMemoryType = supportedRandomAccessMemoryType;
                motherboard.Socket = socket;
                motherboard.Chipset = chipset;
                
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, new { Message = "An error occurred", Details = e.Message });
            }
        }
        
        [HttpDelete("DeleteMotherboard")]
        public ActionResult<Motherboard> Delete(int id)
        {
            try
            {
                _context.Motherboards.Remove(_context.Motherboards.Find(id));
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
