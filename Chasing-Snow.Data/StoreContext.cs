using Chasing_Snow.Domain.Catalog
using Microsoft.EntittyFrameworkCore;


namespace Chasing_Snow.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreConext> options)
            : base(options)
        { }
        public DbSet<Item> Items { get; set; }
    }
    
}


