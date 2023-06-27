using CoreKampi.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreKampi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryChart()
        {
            List<Category> list = new List<Category>();

            list.Add(new Category { CategoryCount = 19, CategoryName = "Spor" });
            list.Add(new Category { CategoryCount = 12, CategoryName = "Araba" });
            list.Add(new Category { CategoryCount = 18, CategoryName = "Yazılım" });

            return Json(new { Json = list });
        }
    }
}
