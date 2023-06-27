using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreKampi.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreKampi.Controllers
{
    public class WriterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        Context c = new Context();

        public IActionResult Index()
        {
            var userMail = User.Identity.Name;
            ViewBag.userMail = userMail;
            var userName = c.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterName).FirstOrDefault();
            ViewBag.userName = userName;
            return View();
        }

        public IActionResult GetWriterProfile()
        {
            var values = wm.GetById(1);
            return View(values);
        }

        [HttpGet]
        public IActionResult WriterEditProfile()
        {

            var userMail = User.Identity.Name;
            var writerId = c.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterId).FirstOrDefault();
            var values = wm.GetById(writerId);
            return View(values);
        }

        [HttpPost]
        public IActionResult WriterEditProfile(Writer p)
        {
            WriterValidator wv = new WriterValidator();
            ValidationResult result = wv.Validate(p);
            if(result.IsValid)
            {
                wm.Update(p);
                return RedirectToAction("GetWriterProfile", "Writer");

            }
            else
            {
                foreach (var i in result.Errors)
                {
                    ModelState.AddModelError(i.PropertyName, i.ErrorMessage);
                }
            }
            return View();
        }


        [HttpGet]
        public IActionResult AddWriter()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddWriter(AddProfileImage p)
        {
            Writer w = new Writer();
            if (p.WriterImage!=null)
            {
                var extension = Path.GetExtension(p.WriterImage.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/WriterImageFiles", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                p.WriterImage.CopyTo(stream);
                w.WriterImage = newimagename;
            }

            w.WriterName = p.WriterName;
            w.WriterMail = p.WriterMail;
            w.WriterPassword = p.WriterPassword;
            w.WriterStatus = true;
            w.WriterAbout = p.WriterAbout;
            wm.Add(w);
            return RedirectToAction("GetWriterProfile", "Writer");



        }
    }
}
