using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreKampi.ViewComponents.Blog
{
    public class SubscribeMail:ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            ViewBag.id = id;
            return View();
        }
    }
}
