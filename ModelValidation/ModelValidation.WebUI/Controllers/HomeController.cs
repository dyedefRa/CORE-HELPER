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
            //DataAnnotsuz Validation için Register lı yorum satırını kaldır
            //return View("Register", new Register() { BirthDate = DateTime.Now });
            return View("Register2", new Register2() { BirthDate = DateTime.Now });

        }
        public IActionResult Register(Register model)
        {
            if (string.IsNullOrEmpty(model.UserName))
            {
                //ModelState.AddModelError("UserName", "Hata Mesajı 1");
                ModelState.AddModelError(nameof(model.UserName), "User Name zorunlu bir alan.");
            }

            if (string.IsNullOrEmpty(model.Email))
            {
                ModelState.AddModelError(nameof(model.Email), "Email boş olamaz");
            }
            else
            {
                if (!model.Email.Contains("@"))
                {
                    ModelState.AddModelError(nameof(model.Email), "Email formatı yanlış.");
                }
            }

            //Email Regular Exp

            if (string.IsNullOrEmpty(model.Password))
            {
                ModelState.AddModelError(nameof(model.Password), "Parola boş olamaz");
            }
            else
            {
                if (model.Password.Length < 6)
                {
                    ModelState.AddModelError(nameof(model.Password), "Minimum 6 karakter olmalıdır.");
                }
            }
           

            if (!model.TermsAccepted)
            {
                ModelState.AddModelError(nameof(model.TermsAccepted), "Kullanım koşullarını kabul etmelisiniz.");
            }

            if (ModelState.IsValid)
            {
                return View("Completed", model);

            }

            //Bu sınıfı merak ettiğim için debug ile kontrol ettim
            var v1 = ModelState.ErrorCount;
            var v2 = ModelState.GetValidationState(nameof(model.Password));
            var v3 = ModelState.HasReachedMaxErrors;
            var v4 = ModelState.IsValid;
            var v5 = ModelState.MaxAllowedErrors;
            var v6 = ModelState.Root; //**
            var v7 = ModelState.ValidationState; //*
            var v8 = ModelState.Values; //*



            return View(model);
        }

        public IActionResult Register2(Register model)
        {
          return View(model);
        }
    }
}