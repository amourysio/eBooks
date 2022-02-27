using AutoMapper;
using eBooks.Data;
using eBooks.Models;
using eBooks.Service;
using Microsoft.AspNetCore.Mvc;

namespace eBooks.Controllers
{
    public class BookController : Controller
    {
        private readonly IBooksService bookService;

        public BookController(IBooksService bookService)
        {
            this.bookService = bookService;
        }

        public IActionResult Index()
        {
            var config = new MapperConfiguration(cfg =>
           cfg.CreateMap<Book, BookViewModel>());

            return View(config);
        }

        public IActionResult GetBook(int id)
        {
            var book = this.bookService.GetBookById(id);
            return View(book);
        }
        [HttpGet]
        public IActionResult AddBook()
        {
            return View();
        }
        public IActionResult EditBook(Book book)
        {
            this.bookService.EditBook(book);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteBook(int id)
        {
            this.bookService.DeleteBook(id);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult SaveBook(Book book)
        {
            this.bookService.AddBook(book);
            return RedirectToAction("Index");
        }
    }
}
