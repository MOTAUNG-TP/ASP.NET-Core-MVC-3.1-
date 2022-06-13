using Microsoft.AspNetCore.Mvc;
using MOTAUNG_TP.BookStore.Models;
using System.Dynamic;

namespace MOTAUNG_TP.BookStore.Controllers
{
    public class HomeController : Controller
    {

        public ViewResult Index()
        {
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
