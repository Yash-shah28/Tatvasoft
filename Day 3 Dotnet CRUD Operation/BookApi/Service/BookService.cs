using BookApi.Model;

namespace BookApi.Service
{
    public class BookService
    {
        private List<Book> _books;

        public BookService()
        {
            _books = new List<Book>();
        }

        // To Add Book
        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        // To Get All Books
        public List<Book> GetAll()
        {
            return _books;
        }

        public Book? GetBookById(int id)
        {
            return _books.Find(x => x.Id == id);
        }
    }
}
