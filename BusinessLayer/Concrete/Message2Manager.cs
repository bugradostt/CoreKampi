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
    public class Message2Manager : IMessage2Service
    {

        IMessage2Dal _message2Dal;

        public Message2Manager(IMessage2Dal message2Dal)
        {
            _message2Dal = message2Dal;
        }

        public void Add(Message2 p)
        {
            _message2Dal.Insert(p);
        }

        public void Delete(Message2 p)
        {
            _message2Dal.Delete(p);
        }

        public Message2 GetById(int id)
        {
            return _message2Dal.GetById(id);
        }

        public List<Message2> GetInboxListByWriter(int id)
        {
            return _message2Dal.GetListWithMessageByWriter(id);
        }

        public List<Message2> ListAll()
        {
            return _message2Dal.ListAll();
        }

        public void Update(Message2 p)
        {
            throw new NotImplementedException();
        }
    }
}
