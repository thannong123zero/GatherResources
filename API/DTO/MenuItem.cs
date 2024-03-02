namespace API.DTO
{
    public class MenuItem
    {
        public Guid ID { get; set; }
        public Guid MenuGroupID { get; set; }
        public string NameEN { get; set; }
        public string NameVN { get; set; }
        public string DiscriptionEN { get; set; }
        public string DiscriptionVN { get; set; }
        public MenuGroup MenuGroup { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
