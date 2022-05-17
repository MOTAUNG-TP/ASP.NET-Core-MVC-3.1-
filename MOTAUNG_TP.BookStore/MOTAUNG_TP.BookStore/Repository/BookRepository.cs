using MOTAUNG_TP.BookStore.Models;
using System.Collections.Generic;
using System.Linq;

namespace MOTAUNG_TP.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBooks(string title, string authorName)
        {
            return DataSource().Where(x=> x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }

        /* Dummy Data as the data source is not available (And it is not the focus of the project as yet) in the programm */
         private List<BookModel> DataSource()
         {
            return new List<BookModel>()
            {
                new BookModel()
                {
                    Id = 1,
                    Title = "MVC Book",
                    Author = "Percy"
                },
                new BookModel()
                {
                    Id = 2,
                    Title = "C# Book",
                    Author = "Thato"
                },
                new BookModel()
                {
                    Id = 3,
                    Title = "Java Book",
                    Author = "Percy"
                },
                new BookModel()
                {
                    Id = 4,
                    Title = "PHP Book",
                    Author = "Motaung TP"
                },
                new BookModel()
                {
                    Id = 5,
                    Title = "C# Book",
                    Author = "Percy"
                },
            };
         }

    }
}
