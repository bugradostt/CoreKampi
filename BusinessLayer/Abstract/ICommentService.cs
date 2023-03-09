using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        List<Comment> ListAllComment(int id);

        void AddComment(Comment p);

        void DeleteComment(Comment p);

        void UpdateComment(Comment p);

        Comment GetById(int id);
    }
}
