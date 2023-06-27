using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreKampi.Controllers
{
    public class DashboardController : Controller
    {
        Context c = new Context();

        public IActionResult Index()
        {
            ViewBag.SumBlogCount = c.Blogs.Count();
            ViewBag.YourBlogCount = c.Blogs.Where(x=>x.WriterId==1).Count();
            ViewBag.SumCategoryCount = c.Categories.Count();
            return View();
        }
    }
}
