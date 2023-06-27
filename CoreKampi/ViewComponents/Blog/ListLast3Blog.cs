using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreKampi.ViewComponents.Blog
{
    public class ListLast3Blog : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            BlogManager bm = new BlogManager(new EfBlogRepository());
            var values = bm.ListLast3Blog();
            return View(values);
        }
    }
}
