using Microsoft.AspNetCore.Mvc;

namespace TestWeb.Controllers
{
    public class LoginPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
