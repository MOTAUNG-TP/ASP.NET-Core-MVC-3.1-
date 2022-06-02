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
                    Author = "Percy",
                    Description = "Detailed MVC Course for Beginners",
                    Category = "Software Design",
                    Language = "English",
                    TotalPages = 134
                },
                new BookModel()
                {
                    Id = 2,
                    Title = ".NET WITH C# Book",
                    Author = "Thato",
                    Description = "Advanced C-Sharp Postgraduate Edition",
                    Category = "Frameworks",
                    Language = "English",
                    TotalPages = 4013
                },
                new BookModel()
                {
                    Id = 3,
                    Title = "Java Book",
                    Author = "Percy",
                    Description = "Introduction to mobile development with Java",
                    Category = "Programming",
                    Language = "Afrikaans",
                    TotalPages = 607
                },
                new BookModel()
                {
                    Id = 4,
                    Title = "PHP Book",
                    Author = "Motaung TP",
                    Description = "Object Oriented Programming with Laravel",
                    Category = "Design",
                    Language = "Swahili",
                    TotalPages =1005
                },
                new BookModel()
                {
                    Id = 5,
                    Title = "C# Book",
                    Author = "Percy",
                    Description = "C-Sharp Fundamentals for Intermediate Level Learning",
                    Category = "Enginnering",
                    Language = "Swahilli",
                    TotalPages =906
                },
                new BookModel()
                {
                    Id = 5,
                    Title = "Azure DevOps",
                    Author = "PecDe Vulture",
                    Description = "DevOps Fundamentals in digital spaces",
                    Category = "DevOps",
                    Language = "English",
                    TotalPages =1114
                },
            };
         }

    }
}
