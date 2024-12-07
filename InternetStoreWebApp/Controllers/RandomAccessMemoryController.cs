using InternetStore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InternetStoreWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RandomAccessMemoryController : ControllerBase
    {
        private readonly Context _context;

        public RandomAccessMemoryController(Context context)
        {
            _context = context;
        }
        
        [HttpGet("GetAllRandomAccessMemory")]
        public IEnumerable<RandomAccessMemory> Get()
        {
            return _context.RandomAccessMemory;
        }
        
        [HttpGet("GetRandomAccessMemoryById")]
        public RandomAccessMemory Get(int id)
        {
            return _context.RandomAccessMemory.Find(id);
        }
        
        [HttpPost("CreateRandomAccessMemory")]
        public ActionResult<RandomAccessMemory> Post(string name, decimal price, string manufacturer, string memoryType, double memorySize)
        {
            try
            {
                RandomAccessMemory randomAccessMemory = new RandomAccessMemory(name, price)
                {
                    Manufacturer = manufacturer,
                    MemoryType = memoryType,
                    MemorySize = memorySize
                };
                _context.RandomAccessMemory.Add(randomAccessMemory);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                return StatusCode(500, new { Message = "An error occurred", Details = e.Message });
            }

            return Ok();
        }

        [HttpPut("UpdateRandomAccessMemory")]
        public ActionResult<RandomAccessMemory> Put(int id, string manufacturer, string memoryType, double memorySize)
        {
            try
            {
                RandomAccessMemory randomAccessMemory = _context.Find<RandomAccessMemory>(id);
                randomAccessMemory.Manufacturer = manufacturer;
                randomAccessMemory.MemoryType = memoryType;
                randomAccessMemory.MemorySize = memorySize;
                
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, new { Message = "An error occurred", Details = e.Message });
            }
        }
        
        [HttpDelete("DeleteRandomAccessMemory")]
        public ActionResult<RandomAccessMemory> Delete(int id)
        {
            try
            {
                _context.RandomAccessMemory.Remove(_context.RandomAccessMemory.Find(id));
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, new { Message = "An error occurred", Details = e.Message });
            }
        }
        
        [HttpGet("ReturnSortedByPrice")]
        public IEnumerable<RandomAccessMemory> SortByPrice()
        {
            List<RandomAccessMemory> ramList = _context.RandomAccessMemory.ToList();
            RandomAccessMemoryFilter.SortByPrice(ramList);
            return ramList;
        }
        
        [HttpGet("ReturnSortedByMemorySize")]
        public IEnumerable<RandomAccessMemory> SortByMemorySize()
        {
            List<RandomAccessMemory> ramList = _context.RandomAccessMemory.ToList();
            RandomAccessMemoryFilter.SortByMemorySize(ramList);
            return ramList;
        }
    }
}
