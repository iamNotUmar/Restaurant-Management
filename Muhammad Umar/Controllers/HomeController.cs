using Microsoft.AspNetCore.Mvc;

namespace Final_Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
         public IActionResult form()
        {
            return View();
        }

        public IActionResult cal()
        {
            return View();
        }
    }
}
