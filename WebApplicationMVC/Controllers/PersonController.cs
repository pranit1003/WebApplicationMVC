using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplicationMVC.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet]
        public IActionResult PersonalDetails()
        {
            List<string> cities = new List<string>() { "select city ","Pune","Kolhapur","Nashik","Mumbai"};
            ViewData["cities"]=new SelectList(cities);  
            return View();
        }
        [HttpPost]
        public IActionResult PersonalDetails(IFormCollection form, ICollection<string> hobbies)
        {
            ViewBag.Name = form["pname"];
            ViewBag.Mobile = form["mobile"];
            ViewBag.Gender = form["Gender"];
            ViewBag.Hobbies = hobbies;
            ViewBag.City = form["cities"];
            return View("Details");
        }

    }

}
