namespace SharedLibrary.DTO
{
    public class Product
    {
        public int ID { get; set; }
        public int MenuItemID { get; set; }
        public string NameEN { get; set; }
        public string NameVN { get; set; }
        public string DiscriptionEN { get; set; }
        public string DiscriptionVN { get; set; }
        public string ContentEN { get; set; }
        public string ContentVN { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string Images { get; set; }
        public double Price { get; set; }
        public int SellOff { get; set; }
        public bool IsHome { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public int Quantity { get; set; }
    }
}
