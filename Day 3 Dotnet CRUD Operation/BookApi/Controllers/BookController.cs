using BookApi.Model;
using BookApi.Service;
using Microsoft.AspNetCore.Mvc;

namespace BookApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController: Controller
    {
        private readonly BookService _bookService;

        public BookController(BookService book)
        {
            _bookService = book;
        }

        [HttpPost]
        [Route("Add")]

        public ActionResult AddBook(Book book)
        {
            _bookService.AddBook(book);
            return Ok("Book created !");
        }


        [HttpGet]
        [Route("GetAll")]
        public ActionResult GetAll()
        {
            return Ok(_bookService.GetAll());
        }

        [HttpGet]
        [Route("GetById")]

        public ActionResult GetById(int id)
        {
            var res = this._bookService.GetBookById(id);

            if (res != null) { return Ok(res); }

            return NotFound("Book not found!");
        }


    }
}
