using Microsoft.AspNetCore.Mvc;

namespace TestWeb.Controllers
{
    public class ContainerController : Controller
    {
        public IActionResult Container()
        {
            return View();
        }
    }
}
