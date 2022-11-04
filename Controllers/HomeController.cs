using BlogIt.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BlogIt.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SQLCategoryRepository _categoryRepo;


        public HomeController(ILogger<HomeController> logger, SQLCategoryRepository categoryRepo)
        {
            _logger = logger;
            _categoryRepo = categoryRepo;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            IEnumerable<Category> categories = _categoryRepo.GetAllCategory();
            ViewBag.category = categories;
            return View();
        }

        [AllowAnonymous]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
