using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using moviemvc.Dto;
using moviemvc.Models.Domain;

namespace moviemvc.Controllers
{
    public class LoginController : Controller
    {
        public readonly UserManager<ApplicationUser> _userManager;
        public readonly SignInManager<ApplicationUser> _signInManager;

        public LoginController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel loginViewModel)
        {
            var result =await _signInManager.PasswordSignInAsync(loginViewModel.UserName, loginViewModel.Password, true, false);
            if (result.Succeeded)
            {
                var user = await _userManager.FindByNameAsync(loginViewModel.UserName);
                if (user.EmailConfirmed == true)
                {
                    return RedirectToAction("Index", "Account");
                }

            }
            return View();
        }
        
    }
}
