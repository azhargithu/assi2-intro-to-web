using Microsoft.AspNetCore.Mvc;

namespace intro_to_web_prj.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
         public IActionResult Login(   string uname, string email)
                {
            if(uname=="test" && email == "test" )
                {
                    ViewBag.Message = "Login Successfull";
                }
                else
                {
                    ViewBag.Message = "Login Failed";
                }
            


            return View("Index");
                }

    }
}
