namespace SharedLibrary.DTO
{
    public class MenuItem
    {
        public int ID { get; set; }
        public int MenuGroupID { get; set; }
        public string NameEN { get; set; }
        public string NameVN { get; set; }
        public string DiscriptionEN { get; set; }
        public string DiscriptionVN { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public bool IsHome { get; set; }
        public bool IsDeleted { get; set; }
    }
}
