using Microsoft.AspNetCore.Mvc;

namespace MustafaMistik.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
