using System.ComponentModel.DataAnnotations;

namespace AuthenticationNAuthorizationDemo.Models
{
    public class ResetPasswordViewModel
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
