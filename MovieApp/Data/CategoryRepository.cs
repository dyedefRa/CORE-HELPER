using System.Collections.Generic;
using System.Linq;
using MovieApp.Models;

namespace MovieApp.Data
{
    public static class CategoryRepository
    {
        private static List<Category> _categorys = null;
        static CategoryRepository()
        {
            _categorys = new List<Category>()
            {
                new Category(){ Id=1,Name="Macera"},
                new Category(){ Id=2,Name="Aksiyon"},
                new Category(){ Id=3,Name="Bilim kurgu"},
                new Category(){ Id=4,Name="xxx"},
                   new Category(){ Id=5,Name="yyy"}
                };

        }
        public static List<Category> Categorys
        {
            get
            {
                return _categorys;
            }
        }

        public static void AddCategory(Category entity)
        {
            _categorys.Add(entity);
        }
        public static Category GetById(int id)
        {
            return _categorys.FirstOrDefault(x => x.Id == id);
        }
        // public static int DeleteCategory(int id)
    }
}