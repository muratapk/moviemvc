using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using moviemvc.Models.Domain;

namespace moviemvc.Controllers
{
    public class ConfirmMailController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public ConfirmMailController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var value = TempData["Mail"];
            ViewBag.mail = value;
            ViewBag.Code = ViewBag.Code;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(ConfirmMailViewModel confirmMailViewModel)
        {
              var result=await _userManager.FindByEmailAsync(confirmMailViewModel.Email);
            if (result.ConfirmCode == confirmMailViewModel.ConfirmCode)
            {
                await _userManager.UpdateAsync(result);
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
    }
}
