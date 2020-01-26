using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagHelpers.Models
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> _product = new List<Product>()
        {
            new Product(){  Id=1, Name="Name 1", Price=66},
            new Product(){  Id=2, Name="Name 2", Price=55},
            new Product(){  Id=3, Name="Name 3", Price=77},

        };
        public IEnumerable<Product> Products => _product;

        public void AddProduct(Product product)
        {
            _product.Add(product);
        }
    }
}
