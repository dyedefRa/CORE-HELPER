using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int id)
        {
            ProductCategoryModel productCategories = new ProductCategoryModel();
            productCategories.Movies = MovieRepository.Movies;
            productCategories.Categories = CategoryRepository.Categorys;
            ViewBag.SelectedCategory= id;
            if (id != 0)
            {
                productCategories.Movies = MovieRepository.Movies.Where(x => x.Id == id);
            }
            return View(productCategories);
        }

        public IActionResult Details(int id)
        {

            return View(MovieRepository.GetById(id));
        }
        public IActionResult Contact()
        {

            return View();
        }

    }
}