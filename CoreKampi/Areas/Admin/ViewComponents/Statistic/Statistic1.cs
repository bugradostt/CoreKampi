using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreKampi.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic1:ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            //ViewBag.SumBlogCount = bm.ListAll().Count();
            ViewBag.SumBlogCount = c.Blogs.Count();
            ViewBag.SumMessageCount = c.Message2s.Count();
            ViewBag.SumCommentCount = c.Comments.Count();

            return View();
        }
    }
}
