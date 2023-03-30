using Microsoft.AspNetCore.Mvc;
using WebApplicationMVC.Models;
using System.Diagnostics;

namespace WebApplicationMVC.Controllers
{
    public class EmployeController : Controller
    {
        public IActionResult EmpList()
        {
            List<Employe> employes = new List<Employe>()
            {
                new Employe{EmpId =101 , EmpName="Pranit", EmpSalary=2500},
                new Employe{EmpId =102 , EmpName="Arun",   EmpSalary=3500},
                new Employe{EmpId =103 , EmpName="Ajay",   EmpSalary=4500},
                new Employe{EmpId =104 , EmpName="Mahesh", EmpSalary=6500},

            };

            ViewData["EmpList"]= employes;
            ViewBag.EmpList = employes;
            return View();
        }
    }
}

