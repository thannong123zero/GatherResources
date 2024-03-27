namespace SharedLibrary.UserInterfaceDTO
{
    public class MenuItemUI : BaseUI
    {
        public Guid ID { get; set; }
        public Guid MenuGroupID { get; set; }
        public string NameEN { get; set; }
        public string NameVN { get; set; }
        public string? DescriptionEN { get; set; }
        public string? DescriptionVN { get; set; }
    }
}
