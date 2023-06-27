using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreKampi.Controllers
{
    [AllowAnonymous]
    public class AboutController : Controller
    {

        AboutManager abm = new AboutManager(new EfAboutRepository());
        public IActionResult Index(About p)
        {
            var values = abm.ListAll();
            return View(values);
        }

        public PartialViewResult SocialMediaAbout()
        {
            return PartialView();
        }
    }
}
