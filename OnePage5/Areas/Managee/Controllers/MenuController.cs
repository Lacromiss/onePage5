using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using OnePage5.Dal;
using OnePage5.Utilites;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OnePage5.Areas.Managee.Controllers
{
    [Area("Managee")]
    public class MenuController : Controller
    {
        private AppDbContext _context { get; }

        private readonly IWebHostEnvironment _env;

        public MenuController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;

        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {

            return View();
        }
    }


}
