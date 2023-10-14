using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using moviemvc.Data;

namespace moviemvc.ViewComponents
{
    public class MovieList:ViewComponent
    {
        private readonly DatabaseContext _context;
        public MovieList(DatabaseContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var liste = _context.Movies.ToList();
            return View(liste);
        }
    }
}
