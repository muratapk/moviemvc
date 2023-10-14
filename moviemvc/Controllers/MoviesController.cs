using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using moviemvc.Data;

namespace moviemvc.Controllers
{
    public class MoviesController : Controller
    {
        public readonly DatabaseContext _context;

        public MoviesController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int? id)
        {
            var tekveri=_context.Movies.Find(id);
            return View(tekveri);
        }
    }
}
