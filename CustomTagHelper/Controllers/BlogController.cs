using CustomTagHelper.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustomTagHelper.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            List<carousel> carousels = new List<carousel>() {
            new carousel{Id=1,Title="title 1",Description="Description 1 ...",Url="../img/slider/s1.jpg"},
            new carousel{Id=1,Title="title 2",Description="Description 2 ...",Url="../img/slider/s2.jpg"},
            new carousel{Id=1,Title="title 3",Description="Description 3 ...",Url="../img/slider/s3.jpg"},
            new carousel{Id=1,Title="title 4",Description="Description 4 ...",Url="../img/slider/s4.jpg"},
            new carousel{Id=1,Title="title 5",Description="Description 5 ...",Url="../img/slider/s5.jpg"},
            new carousel{Id=1,Title="title 6",Description="Description 6 ...",Url="../img/slider/s6.jpg"},
            new carousel{Id=1,Title="title 7",Description="Description 7 ...",Url="../img/slider/s7.jpg"},
            new carousel{Id=1,Title="title 8",Description="Description 8 ...",Url="../img/slider/s8.jpg"}
            };
            return View(carousels);
        }
    }
}
