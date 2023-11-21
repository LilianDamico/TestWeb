using Microsoft.AspNetCore.Mvc;

namespace TestWeb.Controllers
{
    public class MovimentationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
