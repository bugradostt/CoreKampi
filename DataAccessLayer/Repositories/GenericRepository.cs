using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        Context c = new Context();

        public void Delete(T p)
        {
            c.Remove(p);
            c.SaveChanges();
        }

        public T GetById(int id)
        {
            var foundId = c.Set<T>().Find(id);
            return foundId;
        }

        public void Insert(T p)
        {
            c.Add(p);
            c.SaveChanges();
        }

        public List<T> ListAll()
        {
            var values = c.Set<T>().ToList();
            return values;
        }

        public List<T> ListFilter(Expression<Func<T, bool>> filter)
        {
            return c.Set<T>().Where(filter).ToList();
        }

        public void Update(T p)
        {
            c.Update(p);
            c.SaveChanges();
        }
    }
}
