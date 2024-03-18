using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.UserInterfaceDTO
{
    public class MenuGroupUI : BaseUI
    {
        public Guid ID { get; set; }
        [Required(ErrorMessage ="Yeu can nhap Ten Danh Muc")]
        [MinLength(6, ErrorMessage = "minLenght")]
        public string NameEN { get; set; }
        public string NameVN { get; set; }
        public string? DiscriptionEN { get; set; }
        public string? DiscriptionVN { get; set; }
    }
}
