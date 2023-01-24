using Microsoft.AspNetCore.Mvc;

namespace AnyarTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
