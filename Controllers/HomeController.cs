using Microsoft.AspNetCore.Mvc;

namespace intro_to_web_prj.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
