using Microsoft.AspNetCore.Mvc;
using MustafaMistik.DAL;
using MustafaMistik.Models;
using System.Collections.Generic;
using System.Linq;
using MustafaMistik.Utilites;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Threading.Tasks;

namespace MustafaMistik.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class HomeController : Controller
    {
        private AppDbContext _context { get; }
        private readonly IWebHostEnvironment _env;

        public HomeController(AppDbContext context, IWebHostEnvironment env)
        {
            _context=context;
            _env = env;

        }
        public IActionResult Index()
        {
           List<MeetMenu> meetMenu = _context.meetMenus.ToList();

            return View(meetMenu);
        }
        public IActionResult Create()
        {
            
            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(MeetMenu m1)
        {
            if (!ModelState.IsValid) return View();
            bool isExist = _context.meetMenus.Any(s => s.Title.ToLower().Trim() == m1.Title.ToLower().Trim());
            if (isExist) return View();
            if (m1.Photo.CheckSize(200))
            {
                ModelState.AddModelError("Photo", "limit kecilib");
                return View();
            }
            if (!m1.Photo.CheckType("image/"))
            {
                ModelState.AddModelError("Photo", "xeta");
                return View();
            }
            m1.ImageUrl = await m1.Photo.SaveFileAsync(Path.Combine(_env.WebRootPath,  "images"));
            await _context.meetMenus.AddAsync(m1);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(int Id)
        {
            MeetMenu meetMenu = _context.meetMenus.Find(Id);
            if (meetMenu==null)
            {
                return BadRequest();
            }
            return View(meetMenu);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task< IActionResult> Update(int Id ,MeetMenu m1)
        {

            if (m1.Id != Id)
            {
                return BadRequest();


            }
            MeetMenu meetMenu1 = _context.meetMenus.Find(Id);
            if (meetMenu1 == null)
            {
                return BadRequest();

            }
            if (m1.Photo.CheckSize(200))
            {
                ModelState.AddModelError("Photo", "limit kecilib");
                return View();
            }
            if (!m1.Photo.CheckType("image/"))
            {
                ModelState.AddModelError("Photo", "xeta");
                return View();
            }
            m1.ImageUrl = await m1.Photo.SaveFileAsync(Path.Combine(_env.WebRootPath, "images"));

            meetMenu1.Title = m1.Title;
            meetMenu1.Description = m1.Description;
            meetMenu1.ImageUrl = m1.ImageUrl;
            meetMenu1.Photo = m1.Photo;
            meetMenu1.CatagoryId = m1.CatagoryId;
           await  _context.SaveChangesAsync();






            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int Id)
        {
            MeetMenu meetMenu = _context.meetMenus.Find(Id);
            if (meetMenu==null)
            {
                return BadRequest();

            }
            _context.Remove(meetMenu);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
        
    }
}
