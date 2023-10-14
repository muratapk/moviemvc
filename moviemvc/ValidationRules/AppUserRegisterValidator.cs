using FluentValidation;
using moviemvc.Dto;

namespace moviemvc.ValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
           RuleFor(x=>x.FirstName).NotEmpty().WithMessage("Buraya Boş Bırakmazsınız");
           RuleFor(x => x.LastName).NotEmpty().WithMessage("Buraya Boş Bırakmazsınız");
           RuleFor(x => x.Birthday).NotEmpty().WithMessage("Buraya Boş Bırakmazsınız");
           RuleFor(x => x.UserName).NotEmpty().WithMessage("Buraya Boş Bırakmazsınız");
           RuleFor(x => x.Email).NotEmpty().WithMessage("Buraya Boş Bırakmazsınız");
           RuleFor(x => x.Email).EmailAddress().WithMessage("Geçerli Bir Email Adresi Giriniz");
           RuleFor(x => x.ConfirmCode).NotEmpty().WithMessage("Buraya Boş Bırakmazsınız");
           RuleFor(x => x.Password).NotEmpty().WithMessage("Buraya Boş Bırakmazsınız");
           RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Buraya Boş Bırakmazsınız");
           RuleFor(x => x.FirstName).MaximumLength(30).WithMessage("En fazla 30 Karakter Girebiliriniz");
           RuleFor(x => x.FirstName).MinimumLength(2).WithMessage("En az 2 karakter vergi  yapılabilir");
           RuleFor(x => x.Password).MinimumLength(8).WithMessage("En az 8 Karaker veri girebilirsiniz");
           RuleFor(x => x.Password).MaximumLength(16).WithMessage("En fazla 16 Karakter Girebiliriniz");
           RuleFor(x => x.ConfirmPassword).Equal(y => y.Password).WithMessage("Parolalarınız eşleşmiyor");

        }
    }
}
