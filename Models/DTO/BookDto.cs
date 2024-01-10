namespace BooksApi.Models.DTO
{
    public record BookDto
    {
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public string BookGenre { get; set; }
        public string Publisher { get; set; }
        public DateTime YearOfPublication { get; set; }

    }
}
