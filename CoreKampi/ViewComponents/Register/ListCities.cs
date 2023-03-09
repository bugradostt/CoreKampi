using CoreKampi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreKampi.ViewComponents.Register
{
    public class ListCities:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var values = Cities();
           
            return View(values);
        }


        public List<Cities> Cities()
        {
            List<Cities> cs = new List<Cities>();
            cs.Add(new Cities() { CitiesId = 1, CitiesName = "Adana", CitiesCode = 1 });
            cs.Add(new Cities() { CitiesId = 2, CitiesName = "Adıyaman", CitiesCode = 2 });
            cs.Add(new Cities() { CitiesId = 3, CitiesName = "Afyon", CitiesCode = 3 });
            cs.Add(new Cities() { CitiesId = 4, CitiesName = "Ağrı", CitiesCode = 4 });
            cs.Add(new Cities() { CitiesId = 5, CitiesName = "Amasya", CitiesCode = 5 });
            cs.Add(new Cities() { CitiesId = 6, CitiesName = "Ankara", CitiesCode = 6 });
            cs.Add(new Cities() { CitiesId = 7, CitiesName = "Antalya", CitiesCode = 7 });
            cs.Add(new Cities() { CitiesId = 8, CitiesName = "Artvin", CitiesCode = 8 });
            cs.Add(new Cities() { CitiesId = 75, CitiesName = "Ardahan", CitiesCode = 75 });
            cs.Add(new Cities() { CitiesId = 68, CitiesName = "Aksaray", CitiesCode = 68 });
            cs.Add(new Cities() { CitiesId = 9, CitiesName = "Aydın", CitiesCode = 9 });
            cs.Add(new Cities() { CitiesId = 69, CitiesName = "Bayburt", CitiesCode = 69 });
            cs.Add(new Cities() { CitiesId = 72, CitiesName = "Batman", CitiesCode = 72 });
            cs.Add(new Cities() { CitiesId = 74, CitiesName = "Bartın", CitiesCode = 74 });
            cs.Add(new Cities() { CitiesId = 81, CitiesName = "Düzce", CitiesCode = 81 });
            cs.Add(new Cities() { CitiesId = 10, CitiesName = "Balıkesir", CitiesCode = 10 });
            cs.Add(new Cities() { CitiesId = 11, CitiesName = "Bilecik", CitiesCode = 11 });
            cs.Add(new Cities() { CitiesId = 12, CitiesName = "Bingöl", CitiesCode = 12 });
            cs.Add(new Cities() { CitiesId = 13, CitiesName = "Bitlis", CitiesCode = 13 });
            cs.Add(new Cities() { CitiesId = 14, CitiesName = "Bolu", CitiesCode = 14 });
            cs.Add(new Cities() { CitiesId = 15, CitiesName = "Burdur", CitiesCode = 15 });
            cs.Add(new Cities() { CitiesId = 16, CitiesName = "Bursa", CitiesCode = 16 });
            cs.Add(new Cities() { CitiesId = 17, CitiesName = "Çanakkale", CitiesCode = 17 });
            cs.Add(new Cities() { CitiesId = 18, CitiesName = "Çankırı", CitiesCode = 18 });
            cs.Add(new Cities() { CitiesId = 19, CitiesName = "Çorum", CitiesCode = 19 });
            cs.Add(new Cities() { CitiesId = 20, CitiesName = "Denizli", CitiesCode = 20 });
            cs.Add(new Cities() { CitiesId = 21, CitiesName = "Diyarbakır", CitiesCode = 21 });
            cs.Add(new Cities() { CitiesId = 22, CitiesName = "Edirne", CitiesCode = 22 });
            cs.Add(new Cities() { CitiesId = 23, CitiesName = "Elazığ", CitiesCode = 23 });
            cs.Add(new Cities() { CitiesId = 24, CitiesName = "Erzincan", CitiesCode = 24 });
            cs.Add(new Cities() { CitiesId = 25, CitiesName = "Erzurum", CitiesCode = 25 });
            cs.Add(new Cities() { CitiesId = 26, CitiesName = "Eskişehir", CitiesCode = 26 });
            cs.Add(new Cities() { CitiesId = 27, CitiesName = "Gaziantep", CitiesCode = 27 });
            cs.Add(new Cities() { CitiesId = 28, CitiesName = "Giresun", CitiesCode = 28 });
            cs.Add(new Cities() { CitiesId = 29, CitiesName = "Gümüşhane", CitiesCode = 29 });
            cs.Add(new Cities() { CitiesId = 30, CitiesName = "Hakkari", CitiesCode = 30 });
            cs.Add(new Cities() { CitiesId = 31, CitiesName = "Hatay", CitiesCode = 31 });
            cs.Add(new Cities() { CitiesId = 32, CitiesName = "Isparta", CitiesCode = 32 });
            cs.Add(new Cities() { CitiesId = 76, CitiesName = "Iğdır", CitiesCode = 76 });
            cs.Add(new Cities() { CitiesId = 34, CitiesName = "İstanbul", CitiesCode = 34 });
            cs.Add(new Cities() { CitiesId = 35, CitiesName = "İzmir", CitiesCode = 35 });
            cs.Add(new Cities() { CitiesId = 36, CitiesName = "Kars", CitiesCode = 36 });
            cs.Add(new Cities() { CitiesId = 37, CitiesName = "Kastamonu", CitiesCode = 37 });
            cs.Add(new Cities() { CitiesId = 38, CitiesName = "Kayseri", CitiesCode = 38 });
            cs.Add(new Cities() { CitiesId = 39, CitiesName = "Kırklareli", CitiesCode = 39 });
            cs.Add(new Cities() { CitiesId = 40, CitiesName = "Kırşehir", CitiesCode = 40 });
            cs.Add(new Cities() { CitiesId = 41, CitiesName = "Kocaeli", CitiesCode = 41 });
            cs.Add(new Cities() { CitiesId = 42, CitiesName = "Konya", CitiesCode = 42 });
            cs.Add(new Cities() { CitiesId = 43, CitiesName = "Kütahya", CitiesCode = 43 });
            cs.Add(new Cities() { CitiesId = 46, CitiesName = "Kahramanmaraş", CitiesCode = 46 });
            cs.Add(new Cities() { CitiesId = 78, CitiesName = "Karabük", CitiesCode = 78 });
            cs.Add(new Cities() { CitiesId = 70, CitiesName = "Karaman", CitiesCode = 70 });
            cs.Add(new Cities() { CitiesId = 71, CitiesName = "Kırıkkale", CitiesCode = 71 });
            cs.Add(new Cities() { CitiesId = 79, CitiesName = "Kilis", CitiesCode = 79 });
            cs.Add(new Cities() { CitiesId = 44, CitiesName = "Malatya", CitiesCode = 44 });
            cs.Add(new Cities() { CitiesId = 45, CitiesName = "Manisa", CitiesCode = 45 });
            cs.Add(new Cities() { CitiesId = 47, CitiesName = "Mardin", CitiesCode = 47 });
            cs.Add(new Cities() { CitiesId = 33, CitiesName = "Mersin", CitiesCode = 33 });
            cs.Add(new Cities() { CitiesId = 48, CitiesName = "Muğla", CitiesCode = 48 });
            cs.Add(new Cities() { CitiesId = 49, CitiesName = "Muş", CitiesCode = 49 });
            cs.Add(new Cities() { CitiesId = 50, CitiesName = "Nevşehir", CitiesCode = 50 });
            cs.Add(new Cities() { CitiesId = 51, CitiesName = "Niğde", CitiesCode = 51 });
            cs.Add(new Cities() { CitiesId = 52, CitiesName = "Ordu", CitiesCode = 52 });
            cs.Add(new Cities() { CitiesId = 80, CitiesName = "Osmaniye", CitiesCode = 80 });
            cs.Add(new Cities() { CitiesId = 53, CitiesName = "Rize", CitiesCode = 53 });
            cs.Add(new Cities() { CitiesId = 54, CitiesName = "Sakarya", CitiesCode = 54 });
            cs.Add(new Cities() { CitiesId = 55, CitiesName = "Samsun", CitiesCode = 55 });
            cs.Add(new Cities() { CitiesId = 56, CitiesName = "Siirt", CitiesCode = 56 });
            cs.Add(new Cities() { CitiesId = 57, CitiesName = "Sinop", CitiesCode = 57 });
            cs.Add(new Cities() { CitiesId = 58, CitiesName = "Sivas" , CitiesCode = 58 });
            cs.Add(new Cities() { CitiesId = 73, CitiesName = "Şırnak", CitiesCode = 73 });
            cs.Add(new Cities() { CitiesId = 59, CitiesName = "Tekirdağ", CitiesCode = 59 });
            cs.Add(new Cities() { CitiesId = 60, CitiesName = "Tokat", CitiesCode = 60 });
            cs.Add(new Cities() { CitiesId = 61, CitiesName = "Trabzon", CitiesCode = 61 });
            cs.Add(new Cities() { CitiesId = 62, CitiesName = "Tunceli", CitiesCode = 62 });
            cs.Add(new Cities() { CitiesId = 63, CitiesName = "Şanlıurfa", CitiesCode = 63 });
            cs.Add(new Cities() { CitiesId = 64, CitiesName = "Uşak", CitiesCode = 64 });
            cs.Add(new Cities() { CitiesId = 65, CitiesName = "Van", CitiesCode = 65 });
            cs.Add(new Cities() { CitiesId = 77, CitiesName = "Yalova", CitiesCode = 77 });
            cs.Add(new Cities() { CitiesId = 66, CitiesName = "Yozgat", CitiesCode = 66 });
            cs.Add(new Cities() { CitiesId = 67, CitiesName = "Zonguldak", CitiesCode = 67 });

            return cs;
        }
    }
}
