using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreKampi.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic4:ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.name = c.Admins.Where(x=>x.AdminId ==1).Select(x=>x.Name).FirstOrDefault();
            ViewBag.imageUrl = c.Admins.Where(x=>x.AdminId ==1).Select(x=>x.ImageUrl).FirstOrDefault();
            ViewBag.shortDescription = c.Admins.Where(x=>x.AdminId ==1).Select(x=>x.ShortDescription).FirstOrDefault();
            return View();
        }
    }
}
