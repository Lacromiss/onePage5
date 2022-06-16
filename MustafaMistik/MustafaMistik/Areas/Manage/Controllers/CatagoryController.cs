using Microsoft.AspNetCore.Mvc;

namespace MustafaMistik.Areas.Manage.Controllers
{
    public class CatagoryController : Controller
    {
        [Area("Manage")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
