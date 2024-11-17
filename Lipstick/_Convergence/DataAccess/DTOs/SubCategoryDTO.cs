namespace Lipstick._Convergence.DataAccess.DTOs
{
    public class SubCategoryDTO : BaseDTO
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string NameEN { get; set; }
        public string NameVN { get; set; }
        public string DescriptionEN { get; set; }
        public string DescriptionVN { get; set; }
        public int Priority { get; set; }
        //public MenuGroupDTO MenuGroup { get; set; }
        //public ICollection<ProductDTO> Products { get; set; }
        //public MenuItemDTO()
        //{
        //    Products = new List<ProductDTO>();
        //}
    }
}
