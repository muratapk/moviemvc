using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using moviemvc.Dto;
using moviemvc.Models.Domain;

namespace moviemvc.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public RegisterController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(AppUserRegisterDto appUserRegisterDto)
        {
            Random kodum = new Random();
            int code = 0;
            code = kodum.Next(100000, 1000000);

            ApplicationUser appuser = new ApplicationUser()
            {
                FirstName = appUserRegisterDto.FirstName,
                LastName=appUserRegisterDto.LastName,
                Email=appUserRegisterDto.Email,
                Birthday=appUserRegisterDto.Birthday,
                UserName=appUserRegisterDto.UserName,
                ConfirmCode=code,
            
            
            };

            //appuser.Email= appUserRegisterDto.Email;
            var result =await _userManager.CreateAsync(appuser, appUserRegisterDto.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index","ConfirmMail");
            }
            else
            {
                return View();
            }
            
        }
    }
}
