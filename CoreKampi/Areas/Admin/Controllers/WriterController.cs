using CoreKampi.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreKampi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WriterList()
        {
            var jsonWriters = JsonConvert.SerializeObject(Writers);
            return Json(jsonWriters);
        }

        public IActionResult GetWriterById(int id)
        {
            var findId = Writers.FirstOrDefault(x=>x.Id==id);
            return Json(JsonConvert.SerializeObject(findId));

        }

        [HttpPost]
        public IActionResult AddWriter(Writer p)
        {
            Writers.Add(p);
            return Json(JsonConvert.SerializeObject(p));
        }

        public IActionResult DeleteWiter(int id)
        {
            var findId = Writers.FirstOrDefault(x => x.Id == id);
            Writers.Remove(findId);
            return Json(findId);

        }

        public IActionResult UpdateWriter(Writer p)
        {
            var w = Writers.FirstOrDefault(x => x.Id == p.Id);
            w.Name = p.Name;
            return Json(JsonConvert.SerializeObject(p));
        }



        public static List<Writer> Writers = new List<Writer>
        {
            new Writer{Id=1,Name="Ali"},
            new Writer{Id=2,Name="Ayşe"},
            new Writer{Id=3,Name="Ahmet"},
            new Writer{Id=4,Name="Veli"}

        };
    }
}
