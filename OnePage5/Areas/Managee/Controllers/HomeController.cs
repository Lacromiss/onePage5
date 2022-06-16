using Microsoft.AspNetCore.Mvc;

namespace OnePage5.Areas.Managee.Controllers
{
    public class HomeController : Controller
    {
        [Area("Managee")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
