using System.ComponentModel.DataAnnotations;

namespace BooksApi.Models
{
    public class Book
    {[Key]
        public Guid BookID { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public string BookGenre { get; set; }
        public string publisher { get; set; }
        public DateTime YearOfPublication { get; set; }

        public Book(string bookName, string bookAuthor, string bookGenre, string publisher, DateTime yearOfPublication)
        {
            BookName = string.IsNullOrWhiteSpace(bookName) ? bookName : "null";
            BookAuthor = string.IsNullOrWhiteSpace(bookAuthor) ? bookAuthor:"null";
            BookGenre = string.IsNullOrWhiteSpace(bookGenre) ? bookGenre:"null";
            publisher = string.IsNullOrWhiteSpace(publisher) ? publisher:"null";
            YearOfPublication = yearOfPublication;






        }

        public static Book AddNewBook(string bookName, string bookAuthor, string bookGenre, string publisher, DateTime yearOfPublication) { 

            return new Book(bookName, bookAuthor, bookGenre, publisher, yearOfPublication);
        }
    }
}
