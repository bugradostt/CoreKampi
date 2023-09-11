using CoreKampi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
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

        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(Class1 p)
        {
            var httpClient = new HttpClient();
            var jsonEmployee = JsonConvert.SerializeObject(p);
            StringContent content = new StringContent(jsonEmployee,Encoding.UTF8,"application/json");
            var responeMessage = await httpClient.PostAsync("https://localhost:44309/api/Employee",content);
            if(responeMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(p);
        }

        [HttpGet]
        public async Task<IActionResult> EditEmployee(int id)
        {
            var httpClient = new HttpClient();
            var responeMessage = await httpClient.GetAsync("https://localhost:44309/api/Employee/"+id);
            if(responeMessage.IsSuccessStatusCode)
            {
                var jsonString = await responeMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<Class1>(jsonString);
                return View(values);

            }
            return RedirectToAction("Index");

        }

        [HttpPost]
        public async Task<IActionResult> EditEmployee(Class1 p)
        {
            var httpClient = new HttpClient();
            var jsonEmployee = JsonConvert.SerializeObject(p);
            var content = new StringContent(jsonEmployee, Encoding.UTF8,"application/json");
            var responseMessage = await httpClient.PutAsync("https://localhost:44309/api/Employee/",content);
            if(responseMessage.IsSuccessStatusCode) 
            {
                return RedirectToAction("Index");
            }
            return View(p);
        }


        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var http = new HttpClient();
            var responseMessage = await http.DeleteAsync("https://localhost:44309/api/Employee/" + id);
            if(responseMessage.IsSuccessStatusCode) 
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public class Class11
        {
            public int Id  { get; set; }
            public string Name  { get; set; }

        }
    }
}
