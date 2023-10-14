using Microsoft.AspNetCore.Mvc;

namespace moviemvc.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
