using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using GuitarShop.Models;

namespace GuitarShop.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List(string id = "All", int page = 1, string sortby = "Price")
        {
            return Content("id=" + id + ", page=" + page +
               ", sortby=" + sortby);
        }

    }
}