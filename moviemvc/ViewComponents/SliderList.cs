using Microsoft.AspNetCore.Mvc;
using moviemvc.Data;

namespace moviemvc.ViewComponents
{
    public class SliderList :ViewComponent
    {
        private readonly DatabaseContext _context;
        public SliderList(DatabaseContext context)
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
