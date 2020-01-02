using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCore2.Models
{
    public class EfProductRepository : IProductRepository
    {
        private ApplicationDbContext _context;
        public EfProductRepository(ApplicationDbContext context)
        { 
            _context = context;
        }
        public IQueryable<Product> Products => _context.Products;

        public void CreateProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(int Id)
        {
            _context.Remove(GetById(Id));
            _context.SaveChanges();
        }

        public Product GetById(int Id)
        {
         return   _context.Products.FirstOrDefault(x => x.Id == Id);
        }

        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges(); 
        }
    }
}
