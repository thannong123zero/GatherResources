namespace Lipstick._Convergence.DataAccess.DTOs
{
    public class UnitDTO : BaseDTO
    {
        public int Id { get; set; }
        public string NameEN { get; set; }
        public string NameVN { get; set; }
        public string DescriptionEN { get; set; }
        public string DescriptionVN { get; set; }
        //public ICollection<ProductDTO> Products { get; set; }
        //public UnitDTO()
        //{
        //    Products = new List<ProductDTO>();
        //}
    }
}
