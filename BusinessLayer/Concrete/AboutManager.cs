using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {

        IAboutDal _aboutDal;
        public AboutManager(IAboutDal aboutDal )
        {
            _aboutDal=aboutDal;

        }

        public void Add(About p)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(About p)
        {
            throw new System.NotImplementedException();
        }

        public About GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<About> ListAll()
        {
           return _aboutDal.ListAll();
        }

        public void Update(About p)
        {
            throw new System.NotImplementedException();
        }
    }
}