using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreKampi.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bg = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = bg.GetListBlogWithCategory().OrderByDescending(x=>x.BlogId).ToList();
            return View(values);
        }

       // public int id;

        public IActionResult BlogDetail(int id)
        {
            ViewBag.id = id;
         //   this.id = id;
            var value = bg.GetById(id);
            return View(value);
        }
    }
}
