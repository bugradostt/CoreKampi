using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NotificationManager : INotificationService
    {
        INotificationDal _notificationDal;
        public NotificationManager(INotificationDal notificationDal)
        {
            _notificationDal = notificationDal;
        }
        public void Add(Notification p)
        {
            _notificationDal.Insert(p);
        }

        public void Delete(Notification p)
        {
            _notificationDal.Delete(p);
        }

        public Notification GetById(int id)
        {
            return _notificationDal.GetById(id);
        }

        public List<Notification> ListAll()
        {
            return _notificationDal.ListAll();
        }

        public void Update(Notification p)
        {
            _notificationDal.Update(p);
        }
    }
}
