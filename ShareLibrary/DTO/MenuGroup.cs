
namespace SharedLibrary.DTO
{
    public class MenuGroup : BaseDTO
    {
        public Guid ID { get; set; }
        public string NameEN { get; set; }
        public string NameVN { get; set; }
        public string DiscriptionEN { get; set; }
        public string DiscriptionVN { get; set; }
        public ICollection<MenuItem> MenuItems { get; set; }
    }
}
