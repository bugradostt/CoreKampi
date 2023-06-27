using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IWriterService : IGenericService<Writer>
    {
        //List<Writer> ListAllWriter();

        //void AddWriter(Writer p);

        //void DeleteWriter(Writer p);

        //void UpdateWriter(Writer p);

        //Writer GetById(int id);

        List<Writer> GetWriterById(int id);
    }
}
