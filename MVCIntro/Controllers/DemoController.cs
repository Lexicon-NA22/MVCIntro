using Microsoft.AspNetCore.Mvc;

namespace MVCIntro.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
