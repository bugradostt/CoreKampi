using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreKampi.Controllers
{
    public class NotificationController : Controller
    {
        NotificationManager nm = new NotificationManager(new EfNotificationRepository());

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllNotification()
        {
            var values = nm.ListAll().OrderByDescending(x=>x.NotificationId).ToList();
            return View(values);
        }
    }
}
