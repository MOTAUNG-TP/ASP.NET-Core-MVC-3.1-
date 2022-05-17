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


        /* OLD METHOD */
        //public string GetAllBooks()
        //{
        //    return "All Books";

        //    /* Action Method Call: http://localhost:52075/book/getallbooks */
        //}

        /* New METHOD */
        public List<BookModel> GetAllBooks()
        {
            return _bookRepository.GetAllBooks();

            /* Action Method Call: http://localhost:52075/book/getallbooks */
        }


        /* OLD METHOD */
        //public string GetBook(int id)
        //{
        //    return $"Book with ID = {id}";

        //    /* Action Method Call: /* Action Method Call: http://localhost:52075/book/getbook/17 */

        //}

        /* New METHOD */
        public BookModel GetBook(int id)
        {
            return _bookRepository.GetBookById(id);

            /* Action Method Call: /* Action Method Call: http://localhost:52075/book/getbook/17 */

        }


        /* OLD METHOD */
        //public string SearchBooks(string bookName, string authorName)
        //{
        //    return $"Book with name = {bookName} & Author = {authorName}";

        //    /* Action Method Call: /* Action Method Call: http://localhost:52075/book/searchbooks?bookName=MVCBook&authorName=Percy */
        //}


        /* New METHOD */
        public List<BookModel> SearchBooks(string bookName, string authorName)
        {
            return _bookRepository.SearchBooks(bookName, authorName);

            /* Action Method Call: /* Action Method Call: http://localhost:52075/book/searchbooks?bookName=MVCBook&authorName=Percy */
        }

    }
}
