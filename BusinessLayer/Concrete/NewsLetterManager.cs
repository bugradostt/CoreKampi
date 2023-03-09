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
    public class NewsLetterManager : INewsLetterService
    {
        INewsLetterDal _newsLetterDal;

        public NewsLetterManager(INewsLetterDal newsLetterDal)
        {
            _newsLetterDal = newsLetterDal;
        }

        public void AddNewsLetter(NewsLetter p)
        {
            _newsLetterDal.Insert(p);
        }

        public void DeleteNewsLetter(NewsLetter p)
        {
            throw new NotImplementedException();
        }

        public NewsLetter GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<NewsLetter> ListAllNewsLetter(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateNewsLetter(NewsLetter p)
        {
            throw new NotImplementedException();
        }
    }
}
