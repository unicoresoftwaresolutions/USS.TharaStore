
using Microsoft.EntityFrameworkCore;
using USS.TharaStore.Model;

namespace USS.TharaStore.Data
{
    public partial class MainDBContext : DbContext
    {
        public MainDBContext(DbContextOptions<MainDBContext> options)
            : base(options)
        {

        }

        public DbSet<Product> Product { get; set; }
        public DbSet<StockGroup> StockGroup { get; set; }
        public DbSet<UOM> UOM { get; set; }
    
    }
}
