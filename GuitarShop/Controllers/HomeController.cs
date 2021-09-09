using Microsoft.AspNetCore.Mvc;

namespace GuitarShop.Controllers
{
    public class HomeController : Controller
    {

        // Controller for the index html content view
        public IActionResult Index()
        {
            //return View();
            return Content("Home controller, Index action");
        }

        // Controller for the About html content view
        public IActionResult About()
        {
            return View();
        }
    }
}