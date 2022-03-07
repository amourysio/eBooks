using AutoMapper;
using eBooks.Data;
using eBooks.Models;
using eBooks.Service;
using Microsoft.AspNetCore.Mvc;


namespace eBooks.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IAuthorsService authorService;

        public AuthorController(IAuthorsService authorService)
        {
            this.authorService = authorService;
        }

        public IActionResult Index()
        {
            // var config = new MapperConfiguration(cfg =>
            //cfg.CreateMap<Author, AuthorViewModel>());

            // return View(config);
            return View(this.authorService.GetAuthor());
        }

        public IActionResult GetAuthor(int id)
        {
            var auth = this.authorService.GetAuthorById(id);
            return View(auth);
        }
        [HttpGet]
        public IActionResult AddAuthor()
        {
            return View();
        }
        public IActionResult EditAuthor(Author author)
        {
            this.authorService.EditAuthor(author);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteAuthor(int id)
        {
            this.authorService.DeleteAuthor(id);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult SaveAuthor(Author author)
        {
            this.authorService.AddAuthor(author);
            return RedirectToAction("Index");
        }
    }

}
