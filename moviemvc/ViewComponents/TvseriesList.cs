using Microsoft.AspNetCore.Mvc;
using moviemvc.Data;

namespace moviemvc.ViewComponents
{
    public class TvseriesList:ViewComponent
    {
        private readonly DatabaseContext _context;

        public TvseriesList(DatabaseContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var liste = _context.Sliders.ToList();
            return View(liste);
        }
    }
}
