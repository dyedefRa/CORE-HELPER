using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFrameworkCore2.Models;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkCore2.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _repository;
        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List() => View(_repository.Products);

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Product product)
        {
            _repository.CreateProduct(product);
            return RedirectToAction("List");
        }

        public IActionResult Details(int Id) => View(_repository.GetById(Id));

        public IActionResult Edit(int Id)=> View(_repository.GetById(Id));

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            _repository.UpdateProduct(product);
            return RedirectToAction("Details", new { product.Id });
        }
        
        public IActionResult Delete(int Id)
        {
            _repository.DeleteProduct(Id);
            return RedirectToAction("List");
        }


    }
}