using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.UserInterfaceDTO
{
    public class MenuGroupUI : BaseUI
    {
        public Guid ID { get; set; }
        public string NameEN { get; set; }
        public string NameVN { get; set; }
        public string? DiscriptionEN { get; set; }
        public string? DiscriptionVN { get; set; }
        public MenuGroupUI()
        {
            ID = Guid.NewGuid();
            IsDeleted = false;
        }
    }
}
