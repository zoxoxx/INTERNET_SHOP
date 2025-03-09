using System.ComponentModel.DataAnnotations;

namespace INTERNET_SHOP.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Заполните Имя пользователя.")]
        public string?  Login { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Заполните пароль.")]
        public string? Password { get; set; }
    }
}
