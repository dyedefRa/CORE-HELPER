using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCore2.Models
{
    public interface IProductRepository
    {
        Product GetById(int Id);
        IQueryable<Product> Products { get; }
        void CreateProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int Id);
    }
}
