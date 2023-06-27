using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreKampi.ViewComponents.Writer
{
    public class WriterNotification :ViewComponent
    {
        readonly NotificationManager nm = new NotificationManager(new EfNotificationRepository());
        public IViewComponentResult Invoke()
        {
            var values = nm.ListAll().OrderByDescending(x => x.NotificationId).ToList();
            return View(values);
        }
    }
}
