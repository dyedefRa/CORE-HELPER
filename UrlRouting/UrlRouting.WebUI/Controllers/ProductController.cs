using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UrlRouting.WebUI.Models;

namespace UrlRouting.WebUI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View("MyView", new _resultRoute()
            {
                Controller = "ProductController",
                Action = "Index"
            });
        }

        public IActionResult List()
        {
            return View("MyView", new _resultRoute()
            {
                Controller = "ProductController",
                Action = "List"
            });
        }

        public IActionResult Newest()
        {
            return View("MyView", new _resultRoute()
            {
                Controller = "ProductController",
                Action = "Newest"
            });
        }
    }
}