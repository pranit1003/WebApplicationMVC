using Microsoft.AspNetCore.Mvc;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult EmployeeList()
        {

            return View();
        }

        [HttpPost]
        public IActionResult EmployeeList(Employee Emp)
        {

            ViewBag.Id = Emp.Id;
            ViewBag.Name = Emp.Name;
            ViewBag.Salary = Emp.Salary;
            return View("EmployeeDetails");
        }
    }
}
