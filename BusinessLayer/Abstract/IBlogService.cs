using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService:IGenericService<Blog>
    {
        //List<Blog> ListAllBlog();


        //void AddBlog(Blog p);

        //void DeleteBlog(Blog p);

        //void UpdateBlog(Blog p);

        //Blog GetById(int id);

        List<Blog> GetListBlogWithCategory();
        List<Blog> GetListBlogWithWriter(int id);
    }
}
