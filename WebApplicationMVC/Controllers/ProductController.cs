using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ProductList()
        {
            List<Product> products = new List<Product>()
            {
                new Product{Id =101 , Name="Mouse", price=250},
                new Product{Id =102 , Name="Key-Board", price=350},
                new Product{Id =103 , Name="CPU", price=450},
                new Product{Id =104 , Name="Laptop", price=650},

            };
            ViewData["Prodlist"] = products;
            ViewBag.ProdList = products;
            return View();
        }
    }
}

