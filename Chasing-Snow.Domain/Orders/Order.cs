using System.Collections.Generic;
using System.Linq;

namespace Jet.Piranha.Domain.Orders
{
    public class Orders{
        public int Id {get; set;}
        public List<OrderItem> Items {get; set; }
        public DateTime CreatedDate { get; set;}
        public decimal TotalPrice => Items.Sum(i => int.Price);
    }
}