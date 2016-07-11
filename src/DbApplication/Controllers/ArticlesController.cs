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
        return View();
      }
    }
}