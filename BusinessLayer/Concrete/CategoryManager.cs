using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepository ecr;
        public CategoryManager()
        {
           ecr = new EfCategoryRepository();
        }


        public void AddCategory(Category p)
        {
            ecr.Insert(p);
        }

        public void DeleteCategory(Category p)
        {
            ecr.Delete(p);
        }

        public Category GetById(int id)
        {
            return ecr.GetById(id);
        }

        public List<Category> ListAllCategory()
        {
            return ecr.ListAll();
        }

        public void UpdateCategory(Category p)
        {
            ecr.Update(p);
        }
    }
}
