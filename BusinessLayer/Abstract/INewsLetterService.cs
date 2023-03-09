using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface INewsLetterService
    {
        List<NewsLetter> ListAllNewsLetter(int id);

        void AddNewsLetter(NewsLetter p);

        void DeleteNewsLetter(NewsLetter p);

        void UpdateNewsLetter(NewsLetter p);

        NewsLetter GetById(int id);
    }
}
