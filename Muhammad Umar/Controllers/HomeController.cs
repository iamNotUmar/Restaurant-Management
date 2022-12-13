using Microsoft.AspNetCore.Mvc;
using Muhammad_Umar.DBContext;
using Muhammad_Umar.Models;

namespace Final_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly StdDBContext _Db;
        public HomeController(StdDBContext Db)
        {
            _Db = Db;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
         public IActionResult form()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult form(formData data)
        {
            var email = _Db.formData.Where(x => x.email == data.email).FirstOrDefault();
            if (email != null)
            {
                @ViewData["messege"] = "The email is allready taken choose an other one!";
               
            }
            else
            {
                _Db.formData.Add(data);
                _Db.SaveChanges();

            }
            return View();
        }
    }
}
