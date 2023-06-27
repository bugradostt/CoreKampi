using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreKampi.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        BlogManager bm = new BlogManager(new EfBlogRepository());
        Context c = new Context();
        public IActionResult Index()
        {
            var values = bm.GetListBlogWithCategory().OrderByDescending(x=>x.BlogId).ToList();
            return View(values);
        }

       // public int id;

        public IActionResult BlogDetail(int id)
        {
            ViewBag.id = id;
         //   this.id = id;
            var value = bm.GetById(id);
            return View(value);
        }

        public IActionResult BlogListByWriter()
        {

            var userMail = User.Identity.Name;
            var writerId = c.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterId).FirstOrDefault();
            var values = bm.GetListWithCategoryByWriter(writerId).OrderByDescending(x=>x.BlogId).ToList();
            return View(values);

        }

        [HttpGet]
        public IActionResult AddBlog()
        {
            List<SelectListItem> valuesCategory = (from x in cm.ListAll()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryId.ToString()
                                                       
                                                   }).ToList();
            ViewBag.valuesCategory = valuesCategory;
            return View();
        }

        [HttpPost]
        public IActionResult AddBlog(Blog p)
        {
            List<SelectListItem> valuesCategory = (from x in cm.ListAll()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryId.ToString()

                                                   }).ToList();
            ViewBag.valuesCategory = valuesCategory;


            BlogValidator bv = new BlogValidator();
            ValidationResult results = bv.Validate(p);
            if (results.IsValid)
            {


                var userMail = User.Identity.Name;
                var writerId = c.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterId).FirstOrDefault();
                p.BlogStatus = true;
                p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToLongDateString());
                p.WriterId = writerId;
                bm.Add(p);
                return RedirectToAction("BlogListByWriter", "Blog");
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

        public IActionResult DeleteBlog(int id)
        {
            var foundId = bm.GetById(id);
            bm.Delete(foundId);
            return RedirectToAction("BlogListByWriter");

        }

        [HttpGet]
        public IActionResult UpdateBlog(int id)
        {
            List<SelectListItem> valuesCategory = (from x in cm.ListAll()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryId.ToString()

                                                   }).ToList();
            ViewBag.valuesCategory = valuesCategory;
            var fountValue = bm.GetById(id);
            return View(fountValue);
        }

        [HttpPost]
        public IActionResult UpdateBlog(Blog p)
        {
            //var id = p.BlogId;
            //var fountValue = bm.GetById(id);
            //p.WriterId = fountValue.WriterId;
            //p.BlogStatus = fountValue.BlogStatus;
            //p.BlogCreateDate = fountValue.BlogCreateDate;

            //var userMail = User.Identity.Name;
            //var writerId = c.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterId).FirstOrDefault();
            //p.WriterId = writerId;
            //p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToString());
            //p.BlogStatus = true;
            bm.Update(p);
            return RedirectToAction("BlogListByWriter");
        }
    }
}
