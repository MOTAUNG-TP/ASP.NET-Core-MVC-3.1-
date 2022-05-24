using Microsoft.AspNetCore.Mvc;
using MOTAUNG_TP.BookStore.Models;
using MOTAUNG_TP.BookStore.Repository;
using System.Collections.Generic;

namespace MOTAUNG_TP.BookStore.Controllers
{
    public class BookController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        //Define the type of the Repositoty
        private readonly BookRepository _bookRepository= null;

        //This is the Constructor
        public BookController()
        {
            //Instanciate the repository Class
            _bookRepository= new BookRepository();
        }


        public ViewResult GetAllBooks()
        {
            var data =  _bookRepository.GetAllBooks();

            return View(data);

        }

        public BookModel GetBook(int id)
        {
            return _bookRepository.GetBookById(id);

        }

        public List<BookModel> SearchBooks(string bookName, string authorName)
        {
            return _bookRepository.SearchBooks(bookName, authorName);

        }

    }
}
