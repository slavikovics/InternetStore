using InternetStore;
using Microsoft.EntityFrameworkCore;

namespace InternetStoreWebApp
{
    public class Context : DbContext
    {
        public DbSet<CentralProcessingUnit> CentralProcessingUnits { get; set; } = null!;
        
        public DbSet<PowerSupply> PowerSupplies { get; set; } = null!;

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
    }
}