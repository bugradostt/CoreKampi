using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreKampi.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Writer p)
        {
            WriterValidator wv = new WriterValidator();
            ValidationResult results = wv.Validate(p);
            if (results.IsValid)
            {
                p.WriterStatus = true;
                p.WriterAbout = p.WriterName + " hakkımızda...";
                wm.Add(p);
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                foreach (var i in results.Errors)
                {
                    ModelState.AddModelError(i.PropertyName, i.ErrorMessage);
                }

                return View();
            }



        }


    }
}
