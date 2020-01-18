using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewComponents.Models
{
    public interface IProductRepository
    {
         IEnumerable<Product> Products { get; }
        void AddProduct(Product product);
    }
}
