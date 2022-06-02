using Microsoft.AspNetCore.Mvc;
using MOTAUNG_TP.BookStore.Models;
using System.Dynamic;

namespace MOTAUNG_TP.BookStore.Controllers
{
    public class HomeController : Controller
    {

        //Using ViewData Attribute
        [ViewData]
        public string CustomProperty { get; set; }

        [ViewData]
        public string Title { get; set; }

        [ViewData]
        public BookModel Book { get; set; }
        public ViewResult Index()
        {
            //Using ViewData
            ViewData["property1"] = "Percy Motaung";

            ViewData["book"] = new BookModel() { Author = "Percy", Id = 1 };
            return View();
        }

        public ViewResult AboutUs()
        {
            //Using ViewData Attribute
            CustomProperty = "Custom Property";
            Title = "About Us - Controller";

            Book = new BookModel() { Id = 2, Title = "IONIC Tutorial" };

            return View();
        }

        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
