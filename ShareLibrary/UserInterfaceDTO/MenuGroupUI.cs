using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.UserInterfaceDTO
{
    public class MenuGroupUI : BaseUI
    {
        public Guid ID { get; set; }
        public string NameEN { get; set; }
        public string NameVN { get; set; }
        public string? DescriptionEN { get; set; }
        public string? DescriptionVN { get; set; }
        public bool InHomePage { get; set; }
        [Range(0,9999)]
        public int Priority { get; set; }
        public MenuGroupUI()
        {
            ID = Guid.NewGuid();
            IsDeleted = false;
            Priority = 0;
        }
    }
}
