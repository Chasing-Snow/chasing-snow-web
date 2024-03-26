using Chasing-Snow.Data.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Chasing-Snow.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ModelBuilder builder)
        {
            builder.Entity<Item>().HasData(
            new Item("Shirt", "Ohio State Shirt", "Nike", 29.99M)
            {
                Id = 1
            },
            new Item("Shorts", "Ohio State shorts", "Nike", 44.9m)
            {
                Id = 2
            }
            );
        }
    }
}