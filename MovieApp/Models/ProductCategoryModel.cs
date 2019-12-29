using System.Collections.Generic;

namespace MovieApp.Models
{
    public class ProductCategoryModel
    {
        public IEnumerable<Category> Categories { get; set; }
         public IEnumerable<Movie> Movies { get; set; }

    }
}