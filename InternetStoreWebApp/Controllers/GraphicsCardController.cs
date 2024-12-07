using InternetStore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InternetStoreWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GraphicsCardController : ControllerBase
    {
        private readonly Context _context;

        public GraphicsCardController(Context context)
        {
            _context = context;
        }
        
        [HttpGet("GetAllGraphicsCards")]
        public IEnumerable<GraphicsCard> Get()
        {
            return _context.GraphicsCards;
        }
        
        [HttpGet("GetGraphicsCard")]
        public GraphicsCard Get(int id)
        {
            return _context.GraphicsCards.Find(id);
        }
        
        [HttpPost("CreateGraphicsCard")]
        public ActionResult<GraphicsCard> Post(string name, decimal price, string manufacturer, string videoMemoryType, string GraphicsProcessorName, 
            double videoMemorySize, double thermalDesignPower)
        {
            try
            {
                GraphicsCard graphicsCard = new GraphicsCard(name, price)
                {
                    Manufacturer = manufacturer,
                    VideoMemoryType = videoMemoryType,
                    GraphicsProcessorName = GraphicsProcessorName,
                    VideoMemorySize = videoMemorySize,
                    ThermalDesignPower = thermalDesignPower
                };
                _context.GraphicsCards.Add(graphicsCard);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                return StatusCode(500, new { Message = "An error occurred", Details = e.Message });
            }

            return Ok();
        }

        [HttpPut("UpdateGraphicsCard")]
        public ActionResult<GraphicsCard> Put(int id, string manufacturer, string videoMemoryType, string graphicsProcessorName)
        {
            try
            {
                GraphicsCard graphicsCard = _context.Find<GraphicsCard>(id);
                graphicsCard.Manufacturer = manufacturer;
                graphicsCard.VideoMemoryType = videoMemoryType;
                graphicsCard.GraphicsProcessorName = graphicsProcessorName;
                
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, new { Message = "An error occurred", Details = e.Message });
            }
        }
        
        [HttpDelete("DeleteGraphicsCard")]
        public ActionResult<GraphicsCard> Delete(int id)
        {
            try
            {
                _context.GraphicsCards.Remove(_context.GraphicsCards.Find(id));
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, new { Message = "An error occurred", Details = e.Message });
            }
        }
        
        [HttpGet("ReturnSortedByPrice")]
        public IEnumerable<GraphicsCard> SortByPrice()
        {
            List<GraphicsCard> graphicsCards = _context.GraphicsCards.ToList();
            GraphicsCardsFilter.SortByPrice(graphicsCards);
            return graphicsCards;
        }
        
        [HttpGet("ReturnSortedByVideoMemorySize")]
        public IEnumerable<GraphicsCard> SortByVideoMemorySize()
        {
            List<GraphicsCard> graphicsCards = _context.GraphicsCards.ToList();
            GraphicsCardsFilter.SortByVideoMemorySize(graphicsCards);
            return graphicsCards;
        }
    }
}
