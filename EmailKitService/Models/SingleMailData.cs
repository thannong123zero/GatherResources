using System.ComponentModel.DataAnnotations;

namespace EmailKitService.Models
{
    public class SingleMailData
    {
        [Required]
        public string To { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Body { get; set; }
    }
}
