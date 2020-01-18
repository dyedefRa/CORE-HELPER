using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewComponents.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private List<Category> _categories = new List<Category>()
        {
            new Category(){ Id=1, Name="Cat 1"},
            new Category(){ Id=2, Name="Cat 2"},
            new Category(){ Id=3, Name="Cat 3"},
            new Category(){ Id=4, Name="Cat 4"},
        };
        public IEnumerable<Category> Categories => _categories;

        public void AddCategory(Category category)
        {
            _categories.Add(category);
        }
    }
}
