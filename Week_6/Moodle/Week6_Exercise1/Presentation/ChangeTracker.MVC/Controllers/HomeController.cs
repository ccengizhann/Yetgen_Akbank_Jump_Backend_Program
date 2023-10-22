using ChangeTracker.Persistance;
using Microsoft.AspNetCore.Mvc;

namespace ChangeTracker.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            Configurations.GetString("ConnectionStrings:PostgreSQL");
            return View();
        }
    }
}
