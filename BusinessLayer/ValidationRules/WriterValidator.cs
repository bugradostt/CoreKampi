using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı soyadı boş geçilemez !");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Yazar maili boş geçilemez !");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş geçilemez !");
            object p = RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az iki karakter girişi yapınız!");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Girmiş olduğunuz ad soyad çok fazla daha kısa giriş yapınız. ");
            RuleFor(x => x.WriterPassword).MinimumLength(8).WithMessage("Şifre 8 karakterden küçük olamaz.");
            RuleFor(x => x.WriterPassword).MaximumLength(16).WithMessage("Şifre 16 karakterden büyük olamaz.");
            RuleFor(x => x.WriterPassword).Matches(@"[A-Z]+").WithMessage("Şifrede en az bir büyük harf olmalıdır.");
            RuleFor(x => x.WriterPassword).Matches(@"[a-z]+").WithMessage("Şifrede en az bir küçük harf olmalıdır.");
            RuleFor(x => x.WriterPassword).Matches(@"[0-9]+").WithMessage("Şifrede en az bir rakam olmalıdır"); ;
        }

    }
}
