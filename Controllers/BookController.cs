using BooksApi.Data;
using BooksApi.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BooksApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase

    {
        private readonly BookDbContext _bookDbContext;
     
        public BookController(BookDbContext bookDbContext){
            _bookDbContext = bookDbContext;
           

        }

        [HttpGet]
        public IActionResult Get(){

            //  string [] books = { "java", "C#" ,"Json"};
            //Covert data from database to domain models
            var booksDomain =_bookDbContext.books.ToList();
            //Map domain models to DTOs
            var booksDto = new List<BookDto>();
            foreach (var bookDomain in booksDomain) {
                booksDto.Add(

                    new BookDto { 
                        BookName=bookDomain.BookName,
                        BookAuthor=bookDomain.BookAuthor,
                        BookGenre=bookDomain.BookGenre,
                        Publisher=bookDomain.Publisher,
                        YearOfPublication=bookDomain.YearOfPublication 
                    }
   
        
                );
            
            }

            //return DTOs to client/


            return Ok(booksDto);
}
    }
}
