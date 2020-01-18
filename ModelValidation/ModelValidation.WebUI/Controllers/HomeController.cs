using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelValidation.WebUI.Models;

namespace ModelValidation.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Register",new Register() {BirthDate=DateTime.Now });
        }
        public IActionResult Register(Register model)
        {
            if (string.IsNullOrEmpty(model.UserName))
            {
                ModelState.AddModelError(nameof(model.UserName), "Hata Mesajı 1");
            }
            return View("Completed", model);
        }
    }
}