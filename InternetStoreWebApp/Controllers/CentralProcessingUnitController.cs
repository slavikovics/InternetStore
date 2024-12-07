using InternetStore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InternetStoreWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CentralProcessingUnitController : ControllerBase
    {
        private readonly Context _context;

        public CentralProcessingUnitController(Context context)
        {
            _context = context;
        }
        
        [HttpGet("GetAllCentralProcessingUnits")]
        public IEnumerable<CentralProcessingUnit> Get()
        {
            return _context.CentralProcessingUnits;
        }
        
        [HttpGet("GetCentralProcessingUnitById")]
        public CentralProcessingUnit Get(int id)
        {
            return _context.CentralProcessingUnits.Find(id);
        }
        
        [HttpPost("CreateCentralProcessingUnit")]
        public ActionResult<CentralProcessingUnit> Post(string name, decimal price, string manufacturer, string socket, string modelRow, int coreCount, 
            DeliveryType deliveryType, string crystalCodeName, double baseFrequency, double maxFrequency, bool supportsMultithreading, double thermalDesignPower,
            string supportedRandomAccessMemoryType)
        {
            try
            {
                CentralProcessingUnit cpu = new CentralProcessingUnit(name, price)
                {
                    Manufacturer = manufacturer,
                    Socket = socket,
                    ModelRow = modelRow,
                    CoreCount = coreCount,
                    DeliveryType = deliveryType,
                    CrystalCodeName = crystalCodeName,
                    BaseFrequency = baseFrequency,
                    MaxFrequency = maxFrequency,
                    SupportsMultithreading = supportsMultithreading,
                    ThermalDesignPower = thermalDesignPower,
                    SupportedRandomAccessMemoryType = supportedRandomAccessMemoryType
                };

                _context.CentralProcessingUnits.Add(cpu);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                return StatusCode(500, new { Message = "An error occurred", Details = e.Message });
            }

            return Ok();
        }
        
        [HttpPut("UpdateCentralProcessingUnit")]
        public ActionResult<CentralProcessingUnit> Put(int id, string manufacturer, string socket)
        {
            try
            {
                CentralProcessingUnit cpu = _context.Find<CentralProcessingUnit>(id);
                cpu.Manufacturer = manufacturer;
                cpu.Socket = socket;
                
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, new { Message = "An error occurred", Details = e.Message });
            }
        }
        
        [HttpDelete("DeleteCentralProcessingUnit")]
        public ActionResult<CentralProcessingUnit> Delete(int id)
        {
            try
            {
                _context.CentralProcessingUnits.Remove(_context.CentralProcessingUnits.Find(id));
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, new { Message = "An error occurred", Details = e.Message });
            }
        }

        [HttpGet("ReturnSortedByPrice")]
        public IEnumerable<CentralProcessingUnit> SortByPrice()
        {
            List<CentralProcessingUnit> cpuList = _context.CentralProcessingUnits.ToList();
            CentralProcessingUnitsFilter.SortByPrice(cpuList);
            return cpuList;
        }
        
        [HttpGet("ReturnSortedByCoreCount")]
        public IEnumerable<CentralProcessingUnit> SortByCoreCount()
        {
            List<CentralProcessingUnit> cpuList = _context.CentralProcessingUnits.ToList();
            CentralProcessingUnitsFilter.SortByCoreCount(cpuList);
            return cpuList;
        }
        
        [HttpGet("ReturnSortedByBaseFrequency")]
        public IEnumerable<CentralProcessingUnit> SortByBaseFrequency()
        {
            List<CentralProcessingUnit> cpuList = _context.CentralProcessingUnits.ToList();
            CentralProcessingUnitsFilter.SortByBaseFrequency(cpuList);
            return cpuList;
        }
        
        [HttpGet("ReturnSortedByThermalDesignPower")]
        public IEnumerable<CentralProcessingUnit> SortByThermalDesignPower()
        {
            List<CentralProcessingUnit> cpuList = _context.CentralProcessingUnits.ToList();
            CentralProcessingUnitsFilter.SortByThermalDesignPower(cpuList);
            return cpuList;
        }
        
        [HttpGet("FindBySocket")]
        public IEnumerable<CentralProcessingUnit> FindBySocket(string socket)
        {
            List<CentralProcessingUnit> cpuList = _context.CentralProcessingUnits.ToList();
            return CentralProcessingUnitsFilter.FindCentralProcessingUnitsBySocket(cpuList, socket);
        }
    }
}
