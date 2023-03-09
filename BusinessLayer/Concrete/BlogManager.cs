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
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;
        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }
        public void AddBlog(Blog p)
        {
            _blogDal.Insert(p);
        }

        public void DeleteBlog(Blog p)
        {
            _blogDal.Delete(p);
        }

        public Blog GetById(int id)
        {
            return _blogDal.GetById(id);
        }

        public List<Blog> GetListBlogWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public List<Blog> GetListBlogWithWriter(int id)
        {
            return _blogDal.ListFilter(x => x.WriterId == id);
        }

        public List<Blog> ListAllBlog()
        {
            return _blogDal.ListAll();
        }

        public void UpdateBlog(Blog p)
        {
            _blogDal.Update(p);
        }
    }
}
