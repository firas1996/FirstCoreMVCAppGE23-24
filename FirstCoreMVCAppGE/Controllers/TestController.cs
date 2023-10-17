using Microsoft.AspNetCore.Mvc;

namespace FirstCoreMVCAppGE.Controllers
{
    public class TestController : Controller
    {
        public string Welcome()
        {
            return "Welcome to my First ASP.NET Core MVC Application";
        }
        public IActionResult WelcomeX(string name)
        {
            ViewBag.Msg = name + ", " + Welcome();
            return View();
        }
        public IActionResult Max(int x, int y)
        {
            ViewBag.max = Math.Max(x, y);
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
