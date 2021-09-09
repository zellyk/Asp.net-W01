using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using GuitarShop.Models;

namespace GuitarShop.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List(string id = "All")
        {
            return Content("Product controller, List action, id: " + id);
        }
        public IActionResult Detail(int id)
        {
        }
    }
}