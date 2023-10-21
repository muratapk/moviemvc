using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using moviemvc.Dto;
using moviemvc.Models.Domain;
using System.Net.Mail;
using MailKit.Net.Smtp;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;

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
            ViewBag.Code = code;
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
                MimeMessage mimeMessage = new MimeMessage();
                MailboxAddress mailboxAddressFrom = new MailboxAddress("MovieDb Filmden Mesaj", "muratciplak917@gmail.com");
                MailboxAddress mailboxAddressTo = new MailboxAddress("User", appUserRegisterDto.Email);
                mimeMessage.From.Add(mailboxAddressFrom);
                mimeMessage.To.Add(mailboxAddressTo);
                var bodybuilder = new BodyBuilder();
                bodybuilder.HtmlBody = "<h1>Kayıt Olmak için Gönderilen Kodunuz</h1> <p style='color:red'; text-decoration:'underline'>" + code+"</p>";
                mimeMessage.Body = bodybuilder.ToMessageBody();
                mimeMessage.Subject = "MoviDb Üyelik Başvurusu";
                SmtpClient client = new SmtpClient();
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("muratciplak917@gmail.com", "ayvs pnsr jumg cdqa");
                client.Send(mimeMessage);
                client.Disconnect(true);

                TempData["Mail"] = appUserRegisterDto.Email;
               
                return RedirectToAction("Index","ConfirmMail");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View();
            }
            
        }
    }
}
