using Microsoft.AspNetCore.Mvc;
using MOTAUNG_TP.BookStore.Models;
using System.Dynamic;

namespace MOTAUNG_TP.BookStore.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            //Passing data and annonimus types to the view using ViewBags.
            ViewBag.Title = "MOTAUNG_TP";

            dynamic data = new ExpandoObject();
            data.Id = 1;
            data.Name = "Percy";

            ViewBag.Data = data;

            //Passing Objects as models to the views using ViewBags
            ViewBag.Type = new BookModel() {Id = 5, Author = "This is the author" };
                
            return View();
        }

        public ViewResult AboutUs()
        {
            return View();
        }

        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
