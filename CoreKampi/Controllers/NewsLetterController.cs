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
    public class NewsLetterController : Controller
    {
        NewsLetterManager nlm = new NewsLetterManager(new EfNewsLetterRepository()); 

        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult SubscribeMail(NewsLetter p)
        {
           // BlogController bc = new BlogController();
            
            p.NewsLetterStatus = true;
            nlm.AddNewsLetter(p);
            //Response.Redirect("/Blog/BlogDetail/" + bc.id);
            return PartialView();
        }

        [HttpPost]
        public void SubscribeMail1(NewsLetter p, int ViewBagId)
        {
           // var getId = HttpContext.Request.Form["ViewBagId"];

            p.NewsLetterStatus = true;
            nlm.AddNewsLetter(p);
            //return RedirectToAction("BlogDetail""Blog",ViewBagId);
            Response.Redirect("/Blog/BlogDetail/"+ViewBagId);
           
        }
    }
}
