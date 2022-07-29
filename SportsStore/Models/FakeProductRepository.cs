using System.Linq;
using System.Collections.Generic;

namespace SportsStore.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product { Name = "Football", Price = 25 },
            new Product { Name = "Football", Price = 25 },
            new Product { Name = "Football", Price = 25 }
        }.AsQueryable<Product>();
    }
}
