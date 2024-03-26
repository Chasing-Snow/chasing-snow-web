using Chasing_Snow.Domain.Catalog
using Microsoft.EntityFrameworkCore;


namespace Chasing_Snow.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreConext> options)
            : base(options)
        { }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set;}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            DbInitializer.Initialize(builder);
        }
    }
    
}


