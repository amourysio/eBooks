using AutoMapper;
using eBooks.Data;
using eBooks.Models;
using eBooks.Service;
using Microsoft.AspNetCore.Mvc;

namespace eBooks.Controllers
{
    public class PublisherController : Controller
    {
        private readonly IPublishersService publishersService;

        public PublisherController(IPublishersService publishersService)
        {
            this.publishersService = publishersService;
        }

        public IActionResult Index()
        {
            // var config = new MapperConfiguration(cfg =>
            //cfg.CreateMap<Publisher, PublisherViewModel>());

            // return View(config);
            return View(this.publishersService.GetPublisher());
        }

        public IActionResult GetPublisher(int id)
        {
            var publisher = this.publishersService.GetPublisherById(id);
            return View(publisher);
        }
        [HttpGet]
        public IActionResult AddPublisher()
        {
            return View();
        }
        public IActionResult EditPublisher(Publisher publisher)
        {
            this.publishersService.EditPublisher(publisher);
            return RedirectToAction("Index");
        }
        public IActionResult DeletePublisher(int id)
        {
            this.publishersService.DeletePublisher(id);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult SavePublisher(Publisher publisher)
        {
            this.publishersService.AddPublisher(publisher);
            return RedirectToAction("Index");
        }
    }
}
