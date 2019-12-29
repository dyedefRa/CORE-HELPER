using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCore2.Models
{
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();//Bu aşamada database oluşacak ama Startupta bunu tanıtmamız gerekiyor.

            //Burada test verileri kontrolu yapıp yoksa ekleyelim
            if (!context.Products.Any())
            {
                context.Products.AddRange(

                    new Product() { Name = "P 1", Description = "P D 1", Price = 100, Category = "1" },
                    new Product() { Name = "P 2", Description = "P D 2", Price = 200, Category = "2" },
                    new Product() { Name = "P 3", Description = "P D 3", Price = 300, Category = "3" },
                    new Product() { Name = "P 4", Description = "P D 4", Price = 400, Category = "4" },
                    new Product() { Name = "P 5", Description = "P D 5", Price = 500, Category = "5" }
                   );

                context.SaveChanges();
            }

        }
    }
}
