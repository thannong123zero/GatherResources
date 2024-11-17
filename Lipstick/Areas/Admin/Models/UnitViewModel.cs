namespace Lipstick.Areas.Admin.Models
{
    public class UnitViewModel : BaseViewModel
    {
        public Guid ID { get; set; }
        public string NameEN { get; set; }
        public string NameVN { get; set; }
        public string? DescriptionEN { get; set; }
        public string? DescriptionVN { get; set; }
        public UnitViewModel()
        {
            IsActive = true;
        }
    }
}
