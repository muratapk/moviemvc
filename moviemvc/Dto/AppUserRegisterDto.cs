using System.ComponentModel.DataAnnotations;

namespace moviemvc.Dto
{
    public class AppUserRegisterDto
    {
      //[Required]
      public string UserName { get; set; }
      public string FirstName { get; set; }
      public string LastName { get; set; }
      public string Email { get; set; }
      public string Birthday { get; set; }
      public int ConfirmCode { get; set; }
      public string Password { get; set; }
      public string ConfirmPassword { get; set; }
    }
}
