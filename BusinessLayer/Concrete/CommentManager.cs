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
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;
        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }
        public void AddComment(Comment p)
        {
            _commentDal.Insert(p);
        }

        public void DeleteComment(Comment p)
        {
            throw new NotImplementedException();
        }

        public Comment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> ListAllComment(int id)
        {
           return _commentDal.ListFilter(x=>x.BlogId==id);
        }

        public void UpdateComment(Comment p)
        {
            throw new NotImplementedException();
        }
    }
}
