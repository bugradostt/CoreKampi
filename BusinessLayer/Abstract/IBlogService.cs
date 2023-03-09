using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService
    {
        List<Blog> ListAllBlog();

        List<Blog> GetListBlogWithCategory();

        void AddBlog(Blog p);

        void DeleteBlog(Blog p);

        void UpdateBlog(Blog p);

        Blog GetById(int id);

        List<Blog> GetListBlogWithWriter(int id);
    }
}
