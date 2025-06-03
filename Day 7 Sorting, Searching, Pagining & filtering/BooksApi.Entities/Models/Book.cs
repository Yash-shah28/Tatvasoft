using BooksApi.Entities.Entities;

namespace BooksApi.Entities.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public List<BookDetails> BookDetails { get; set; }

    }
}
