using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment2.Controllers
{
    public class InfoController : Controller
    {
        // GET "Info/Index"
        public IActionResult Index()
        {
            return View();
        }

        // GET "Info/About"
        public IActionResult About()
        {
            return View();
        }
    }
}
