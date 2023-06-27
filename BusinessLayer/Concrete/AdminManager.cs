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
    public class AdminManager : IAdminService
    {

        IAdminDal _adminDal;
        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public void Add(Admin p)
        {
            _adminDal.Insert(p);
        }

        public void Delete(Admin p)
        {
            _adminDal.Delete(p);
        }

        public Admin GetById(int id)
        {
            return _adminDal.GetById(id);
        }

        public List<Admin> ListAll()
        {
            return _adminDal.ListAll();
        }

        public void Update(Admin p)
        {
            _adminDal.Update(p);
        }
    }
}
