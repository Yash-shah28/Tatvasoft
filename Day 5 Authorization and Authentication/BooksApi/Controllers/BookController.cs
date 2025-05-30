using BooksApi.Entities.Entities;
using BooksApi.Models;
using BooksApi.Services;
using BooksApi.Services.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace BooksApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : Controller
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService) 
        {
            _bookService = bookService;
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult> AddBook(BookDetails bookDetails)
        {
            await _bookService.InsertBook(bookDetails);
            return Ok("Book created !");
        }

        [HttpGet]
        [Route("GetAll")]
        public async  Task<ActionResult> GetAllFromDb()
        {
            var books = await _bookService.GetAllFromDbAsync();
            return Ok(books);
        }

        [HttpGet]
        [Route("GetById")]
        public ActionResult GetById(int id)
        {
            var res = _bookService.GetBookDetailsById(id);

            if (res != null) { return Ok(res); }

            return NotFound("Book not found!");
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult> UpdateBook(BookDetails bookDetails)
        {
            await _bookService.updateBook(bookDetails);
            return Ok("Book updated successfully.");
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public async Task<ActionResult> DeleteBook(int id)
        {
            await _bookService.DeleteBook(id);
            return Ok("Book deleted successfully.");
        }

    }
}
