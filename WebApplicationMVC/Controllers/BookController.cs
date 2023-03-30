using Microsoft.AspNetCore.Mvc;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Book book)
        {
            ViewBag.Name =book.Name;
            ViewBag.Price= book.Price;
            ViewBag.Author= book.Author;
            return View("Show");  
        }
    }
}
