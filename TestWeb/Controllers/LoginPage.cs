using Microsoft.AspNetCore.Mvc;

namespace TestWeb.Controllers
{
    public class LoginPage : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
