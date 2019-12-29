using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;

namespace MovieApp.ViewComponents
{
    public class CategoryMenuViewCompenent:ViewComponent
    {
        public IViewComponentResult Invoke(){

            return View(CategoryRepository.Categorys);
        }
    }
}