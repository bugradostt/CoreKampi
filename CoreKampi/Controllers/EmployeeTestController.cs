using CoreKampi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CoreKampi.Controllers
{
    public class EmployeeTestController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var httpClient = new HttpClient();
            var responeMessage = await httpClient.GetAsync("https://localhost:44309/api/Employee");
            var jsonString = await responeMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<Class1>>(jsonString);
            return View(values);
        }

        public class Class11
        {
            public int Id  { get; set; }
            public string Name  { get; set; }

        }
    }
}
