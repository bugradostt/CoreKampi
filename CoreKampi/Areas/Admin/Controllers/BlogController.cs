using ClosedXML.Excel;
using CoreKampi.Areas.Admin.Models;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreKampi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        public IActionResult ExportStaticExcelBlogList()
        {
            using (var workBook = new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Blog Listesi");
                workSheet.Cell(1, 1).Value = "#";
                workSheet.Cell(1, 2).Value = "Blog Adı";

                int BlogRowCount = 2;
                foreach (var i in GetBlogList())
                {
                    workSheet.Cell(BlogRowCount, 1).Value = i.Id;
                    workSheet.Cell(BlogRowCount, 2).Value = i.BlogName;
                    BlogRowCount++;
                }

                using( var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "applicatin/vnd.openxmlformats-officedocument.spreadsheetml.sheet ","Çalışma.xlsx");
                }
            }
            //return View();
        }
        public List<BlogModel> GetBlogList()
        {
            List<BlogModel> bm = new List<BlogModel>
            {
                new BlogModel {Id = 1, BlogName="C# Öğreniyorum"},
                new BlogModel {Id = 2, BlogName="Tesle  Firmasının Araçları"},
                new BlogModel {Id = 3, BlogName="İOS 17 Tanıtım"},
                new BlogModel {Id = 4, BlogName="iPhone 15 Sızıntıları"}
            };

            return bm;

        }

        public IActionResult BlogListExcel()
        {
            return View();
        }

        public IActionResult ExportDynamicExcelBlogList()
        {
            using (var workBook = new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Blog Listesi");
                workSheet.Cell(1, 1).Value = "#";
                workSheet.Cell(1, 2).Value = "Blog Adı";

                int BlogRowCount = 2;
                foreach (var i in GetTitleList())
                {
                    workSheet.Cell(BlogRowCount, 1).Value = i.Id;
                    workSheet.Cell(BlogRowCount, 2).Value = i.BlogName;
                    BlogRowCount++;
                }

                using (var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "applicatin/vnd.openxmlformats-officedocument.spreadsheetml.sheet ", "BlogListesi.xlsx");
                }
            }
            //return View();
        }

        public List<BlogModel2> GetTitleList()
        {
            List<BlogModel2> bm = new List<BlogModel2>();
            using( var c = new Context())
            {
                bm = c.Blogs.Select(x => new BlogModel2 { 
                            
                    Id = x.BlogId,
                    BlogName=x.BlogTitle
                    }).ToList();
            }
           

            return bm;

        }

        public IActionResult BlogTitleListExcel()
        {
            return View();
        }
    }

}
