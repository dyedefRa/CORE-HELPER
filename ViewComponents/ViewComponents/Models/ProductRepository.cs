using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewComponents.Models
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> _products = new List<Product>()
        {
            new Product(){ Id=1, Name="Product 1", CategoryId=1, Price=1.1, IsApproved=true},
            new Product(){ Id=2, Name="Product 2", CategoryId=2, Price=1.2, IsApproved=true},
            new Product(){ Id=3, Name="Product 3", CategoryId=3, Price=1.3, IsApproved=true},
            new Product(){ Id=4, Name="Product 4", CategoryId=4, Price=1.4, IsApproved=false}
        };
        public IEnumerable<Product> Products => _products;

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }
    }
}
