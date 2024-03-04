using SharedLibrary.UserInterfaceDTO;

namespace SharedLibrary.DTO
{
    public class MenuItem : BaseDTO
    {
        public Guid ID { get; set; }
        public Guid MenuGroupID { get; set; }
        public string NameEN { get; set; }
        public string NameVN { get; set; }
        public string DiscriptionEN { get; set; }
        public string DiscriptionVN { get; set; }
        public MenuGroupUI MenuGroup { get; set; }
        public ICollection<ProductUI> Products { get; set; }
    }
}
