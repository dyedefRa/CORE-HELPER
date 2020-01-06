using BlogApp.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Data.Concrete.EFCore
{
    public class BlogContext : DbContext
    {
        //Burası önemli , dışardan con str vermemiz gerekiyor
        public BlogContext(DbContextOptions<BlogContext> options):base(options)
        {

        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
