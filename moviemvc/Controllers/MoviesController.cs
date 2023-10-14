using Microsoft.AspNetCore.Mvc;

namespace moviemvc.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
