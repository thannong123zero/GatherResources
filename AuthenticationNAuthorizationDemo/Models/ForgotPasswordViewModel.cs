using System.ComponentModel.DataAnnotations;

namespace AuthenticationNAuthorizationDemo.Models
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
