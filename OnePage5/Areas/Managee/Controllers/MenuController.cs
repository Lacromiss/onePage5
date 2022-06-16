using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using OnePage5.Dal;
using OnePage5.Models;
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
        private AppDbContext _context { get;}

        private readonly IWebHostEnvironment _env;

        public MenuController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;

        }
        public IActionResult Index()
        {
          List<  ToEat> toEat = _context.toEat.ToList();
            return View(toEat);
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Createe(ToEat t1)
        {
            if (!ModelState.IsValid) return View();
            bool isExist = _context.toEat.Any(s => s.Title.ToLower().Trim() == t1.Title.ToLower().Trim());
            if (isExist) return View();
            if (t1.Photo.CheckSize(200))
            {
                ModelState.AddModelError("Photo", "sd");
                return View();
            }
            if (!t1.Photo.CheckType("image/"))
            {
                ModelState.AddModelError("Photo", "sd");
                return View();
            }
            t1.ImgUrl = await t1.Photo.SaveFileAsync(Path.Combine(_env.WebRootPath, "images"));
            await _context.toEat.AddAsync(t1);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
