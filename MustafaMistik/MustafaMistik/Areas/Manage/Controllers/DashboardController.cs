﻿using Microsoft.AspNetCore.Mvc;

namespace MustafaMistik.Areas.Manage.Controllers
{
    [Area ("Manage")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
