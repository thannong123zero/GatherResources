namespace Lipstick._Convergence.DataAccess.DTOs
{
    public class ProductDTO : BaseDTO
    {
        public int Id { get; set; }
        public int MenuItemId { get; set; }
        public int UnitId { get; set; }
        public int BrandId { get; set; }
        public string NameEN { get; set; }
        public string NameVN { get; set; }
        public string DescriptionEN { get; set; }
        public string DescriptionVN { get; set; }
        public string ContentEN { get; set; }
        public string ContentVN { get; set; }
        public string Images { get; set; }
        public double Price { get; set; }
        public int Discount { get; set; }
        public bool InHomePage { get; set; }
        public double Quantity { get; set; }
        //public Unit Unit { get; set; }
        //public MenuItem MenuItem { get; set; }
        //public BrandDTO Brand { get; set; }
    }
}
