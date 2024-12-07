using InternetStore;
using Microsoft.EntityFrameworkCore;

namespace InternetStoreWebApp
{
    public class Context : DbContext
    {
        public DbSet<CentralProcessingUnit> CentralProcessingUnits { get; set; } = null!;
        
        public DbSet<GraphicsCard> GraphicsCards { get; set; } = null!;
        
        public DbSet<Motherboard> Motherboards { get; set; } = null!;
        
        public DbSet<RandomAccessMemory> RandomAccessMemory { get; set; } = null!;
        
        public DbSet<Storage> Storages { get; set; } = null!;
        
        public DbSet<PowerSupply> PowerSupplies { get; set; } = null!;

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
    }
}