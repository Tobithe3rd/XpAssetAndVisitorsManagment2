using System.ComponentModel.DataAnnotations;

namespace XpAssetAndVisitorsManagement.Models.Authentication.SignUp
{
    public class RegisterUser
    {
        [Required(ErrorMessage = "User Name is Required")]
        public string? UserName { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email Name is Required")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password Name is Required")]
        public string? Password { get; set; }
    }
}
