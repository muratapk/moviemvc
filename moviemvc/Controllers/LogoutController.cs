using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using moviemvc.Models.Domain;

namespace moviemvc.Controllers
{
    public class LogoutController : Controller
    {
        private readonly SignInManager<ApplicationUser> _signInManager;

        public LogoutController(SignInManager<ApplicationUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public async Task<IActionResult> Index()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}
