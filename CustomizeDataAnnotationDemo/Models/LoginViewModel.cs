using CustomizeDataAnnotationDemo.CustomizeDataAnnotation;
using System.ComponentModel.DataAnnotations;

namespace CustomizeDataAnnotationDemo.Models
{
    public class LoginViewModel
    {
        [CustomizeEmailValidation]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
