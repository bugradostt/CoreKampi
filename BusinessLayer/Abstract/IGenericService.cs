using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService <T>
    {
        List<T> ListAll();

        void Add(T p);

        void Delete(T p);

        void Update(T p);

        T GetById(int id);
    }
}
