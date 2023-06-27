using BlogApiDemo.DataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        Context c = new Context();

        [HttpGet]
        public IActionResult ListAll()
        {
            var values = c.Employees.OrderByDescending(x => x.Id).ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee p)
        {
            c.Employees.Add(p);
            c.SaveChanges();
            return Ok(p);
        }

        [HttpGet("{id}")]
        public IActionResult EmployeeGet(int id)
        {
           
            var findId = c.Employees.Find(id);
            if (findId==null)
            {
                return NotFound();
            }
            else
            {

                return Ok(findId);
            }

        }

        [HttpDelete("{id}")]
        public IActionResult EmployeeDelete(int id)
        {

            var findId = c.Employees.Find(id);
            if (findId == null)
            {
                return NotFound();
            }
            else
            {

                c.Employees.Remove(findId);
                c.SaveChanges();
                return Ok("Silme Başarılı");
            }

        }

        [HttpPut]
        public IActionResult EmployeeUpdate(Employee p)
        {
            //var FindId = EmployeeGet(p.Id);

            var findId = c.Employees.Find(p.Id);
            if(findId==null)
            {
                return NotFound("Null");
            }
            else
            {

                findId.Name = p.Name;
                c.SaveChanges();
                return Ok(p);
            }
        }
    }
}



