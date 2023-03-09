using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreKampi.Controllers
{
    public class CommentController : Controller
    {
         CommentManager cm = new CommentManager(new EfCommentRepository());
       
        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult PartialAddComment(Comment p)
        {
            p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.CommentStatus = true;
            p.BlogId = 1;
            cm.AddComment(p);
            return PartialView();
        }


        [HttpPost]
        public void AddComment(Comment p,  int ViewBagId)
        {
            p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.CommentStatus = true;
            p.BlogId = 1;
            cm.AddComment(p);
            Response.Redirect("/Blog/BlogDetail/" + ViewBagId);
            
        }

        public PartialViewResult PartialListCommentBlog(int id)
        {
            var values = cm.ListAllComment(id);
            return PartialView(values);
        }
    }
}
