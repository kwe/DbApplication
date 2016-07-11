using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace DbApplication.Controllers
{
    public class HomeController : Controller
    {
        private IConfiguration _config;
        private ArticleDbContext _context;
        public HomeController(IConfiguration config, ArticleDbContext context)
        {
            _config = config;
            _context = context;
        }
        public IActionResult Index()
        {
            var Articles = _context.Articles.ToList();
            return View(Articles);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application  page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
