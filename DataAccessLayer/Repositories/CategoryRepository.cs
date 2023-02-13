using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : ICateroryDal
    {
        Context c = new Context();

        public void AddCategory(Category p)
        {
            c.Add(p);
            c.SaveChanges();
        }

        public void DeleteCategory(Category p)
        {
            c.Remove(p);
            c.SaveChanges();
        }

        public Category GetById(int id)
        {
            var foundId = c.Categories.Find(id);
            return foundId;
        }

        public List<Category> ListAllCategory()
        {
            var values = c.Categories.ToList();
            return values;
        }

        public void UpdateCategory(Category p)
        {
            c.Update(p);
            c.SaveChanges();
        }
    }
}
