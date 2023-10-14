using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using moviemvc.Dto;

namespace moviemvc.Controllers
{
    public class LoginController : Controller
    {
        public readonly UserManager<AppUserRegisterDto> _userManager;

        public LoginController(UserManager<AppUserRegisterDto> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
