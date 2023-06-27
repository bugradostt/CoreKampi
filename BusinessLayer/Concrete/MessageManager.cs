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
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }
        public void Add(Message p)
        {
            _messageDal.Insert(p);
        }

        public void Delete(Message p)
        {
            _messageDal.Delete(p);
        }

        public Message GetById(int id)
        {
            return _messageDal.GetById(id);
        }

        public List<Message> GetInboxListByWriter(string p)
        {
            return _messageDal.ListFilter(x => x.MessageReceiver == p);
        }

        public List<Message> ListAll()
        {
            return _messageDal.ListAll();
        }

        public void Update(Message p)
        {
            _messageDal.Update(p);
        }
    }
}
