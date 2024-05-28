using System.ComponentModel.DataAnnotations;

namespace CoolBlog.Models
{
    public class UserSignInModelViewModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adını girin")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi girin")]
        public string Password { get; set; }
    }
}
