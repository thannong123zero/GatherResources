using System.Diagnostics.CodeAnalysis;

namespace PopUpDemo.Models
{
    public class ProductionViewModel
    {
        public Guid? ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public DateTime ManufacuturingDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Weight { get; set; }
        public int Quantity { get; set; }
        [AllowNull]
        public DateTime CreateOn { get; set; }
        public string? CreateBy { get; set; }
        [AllowNull]
        public DateTime UpdateOn { get; set; }
        public string? UpdateBy { get; set; }
    }
}
