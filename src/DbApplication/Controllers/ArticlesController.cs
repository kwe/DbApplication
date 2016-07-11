using DbApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DbApplication.Controllers
{
    public class ArticlesController : Controller
    {
      private ArticleDbContext _context;
      public ArticlesController(ArticleDbContext context)
      {
        _context = context;
      }
      public IActionResult Index()
      {
        return View(_context.Articles.ToList());
      }

      public IActionResult Create()
      {
        return View();
      }

      [HttpPost]
      [ValidateAntiForgeryToken]
      public IActionResult Create(Article article)
      {
        if(ModelState.IsValid)
        {
          _context.Articles.Add(article);
          _context.SaveChanges();
          return RedirectToAction("Index");
        }
        return View(article);
      }
    }
}