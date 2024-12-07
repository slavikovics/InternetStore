using InternetStore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InternetStoreWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StorageController : ControllerBase
    {
        private readonly Context _context;

        public StorageController(Context context)
        {
            _context = context;
        }
        
        [HttpGet("GetAllStorage")]
        public IEnumerable<Storage> Get()
        {
            return _context.Storages;
        }
        
        [HttpGet("GetStorageById")]
        public Storage Get(int id)
        {
            return _context.Storages.Find(id);
        }
        
        [HttpPost("CreateStorage")]
        public ActionResult<Storage> Post(string name, decimal price, string manufacturer, string memoryType, double memorySize)
        {
            try
            {
                Storage storage = new Storage(name, price)
                {
                    Manufacturer = manufacturer,
                    MemoryType = memoryType,
                    MemorySize = memorySize
                };
                _context.Storages.Add(storage);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                return StatusCode(500, new { Message = "An error occurred", Details = e.Message });
            }

            return Ok();
        }

        [HttpPut("UpdateStorage")]
        public ActionResult<Storage> Put(int id, string manufacturer, string memoryType, double memorySize)
        {
            try
            {
                Storage storage = _context.Find<Storage>(id);
                storage.Manufacturer = manufacturer;
                storage.MemoryType = memoryType;
                storage.MemorySize = memorySize;
                
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, new { Message = "An error occurred", Details = e.Message });
            }
        }
        
        [HttpDelete("DeleteStorage")]
        public ActionResult<Storage> Delete(int id)
        {
            try
            {
                _context.Storages.Remove(_context.Storages.Find(id));
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, new { Message = "An error occurred", Details = e.Message });
            }
        }
        
        [HttpGet("ReturnSortedByPrice")]
        public IEnumerable<Storage> SortByPrice()
        {
            List<Storage> ramList = _context.Storages.ToList();
            StoragesFilter.SortByPrice(ramList);
            return ramList;
        }
        
        [HttpGet("ReturnSortedByMemorySize")]
        public IEnumerable<Storage> SortByMemorySize()
        {
            List<Storage> ramList = _context.Storages.ToList();
            StoragesFilter.SortByMemorySize(ramList);
            return ramList;
        }
    }
}
