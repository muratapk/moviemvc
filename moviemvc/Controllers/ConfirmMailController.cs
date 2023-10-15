using Microsoft.AspNetCore.Mvc;

namespace moviemvc.Controllers
{
    public class ConfirmMailController : Controller
    {
        public IActionResult Index()
        {
            var value = TempData["Mail"];
            ViewBag.mail = value;
            ViewBag.Code = ViewBag.Code;
            return View();
        }
    }
}
