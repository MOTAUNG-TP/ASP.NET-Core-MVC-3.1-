using Microsoft.AspNetCore.Mvc;
using MOTAUNG_TP.BookStore.Models;
using MOTAUNG_TP.BookStore.Repository;
using System.Collections.Generic;
using System.Dynamic;

namespace MOTAUNG_TP.BookStore.Controllers
{
    public class BookController : Controller
    {
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

        public ViewResult GetBook(int id)
        {
            dynamic data = new ExpandoObject();
            data.book = _bookRepository.GetBookById(id);
            data.Name = "Percy";

            //var data =  ;

            return View(data);

        }

        public List<BookModel> SearchBooks(string bookName, string authorName)
        {
            return _bookRepository.SearchBooks(bookName, authorName);

        }

    }
}
