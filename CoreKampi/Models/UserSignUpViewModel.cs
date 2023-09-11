using System.ComponentModel.DataAnnotations;

namespace CoreKampi.Models
{
    public class UserSignUpViewModel
    {
        [Display(Name ="Ad Soyad")]
        [Required(ErrorMessage ="Lüften adınızı soyadınızı giriniz")]
        public string userSurname { get; set; }
    }
}
