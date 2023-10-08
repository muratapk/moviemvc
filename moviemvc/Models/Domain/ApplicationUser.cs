using Microsoft.AspNetCore.Identity;

namespace moviemvc.Models.Domain
{
    public class ApplicationUser:IdentityUser
    {
     public string? FirstName{get;set;}

     public  string? LastName { get; set; }

     public string? Birthday { get; set; }

     public int? ConfirmCode { get; set; }

    }
}
