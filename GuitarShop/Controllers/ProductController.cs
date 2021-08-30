using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using GuitarShop.Models;

namespace GuitarShop.Controllers
{
    public class ProductController : Controller
    {
        // Controller for when view a product by id
        public IActionResult Detail(string id)
        {
            Product product = DB.GetProduct(id);
            return View(product);
        }

        // Controller to view a list of products
        public IActionResult List()
        {
            List<Product> products = DB.GetProducts();
            return View(products);
        }
    }
}