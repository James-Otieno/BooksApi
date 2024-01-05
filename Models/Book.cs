using System.ComponentModel.DataAnnotations;

namespace BooksApi.Models
{
    public class Book
    {[Key]
        public Guid BookID { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }

        public Book(string bookName, string bookAuthor)
        {
            BookName = string.IsNullOrWhiteSpace(bookName) ? bookName : "null";
            BookAuthor = string.IsNullOrWhiteSpace(bookAuthor) ? bookAuthor:"null";
            
           

        }
    }
}
