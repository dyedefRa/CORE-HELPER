using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCore2.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product(){ Id=1, Name="S 1", Price=2000, Category="Telefon", Description="Açıklama 1"},
            new Product(){ Id=1, Name="S 2", Price=3000, Category="Telefon", Description="Açıklama 2"},
            new Product(){ Id=1, Name="S 3", Price=4000, Category="Telefon", Description="Açıklama 3"},
            new Product(){ Id=1, Name="S 4", Price=5000, Category="Telefon", Description="Açıklama 4"},
            new Product(){ Id=1, Name="S 5", Price=6000, Category="Telefon", Description="Açıklama 5"},
        }.AsQueryable();
    }
}
