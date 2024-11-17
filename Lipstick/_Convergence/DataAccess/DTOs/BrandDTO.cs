using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lipstick._Convergence.DataAccess.DTOs
{
    public class BrandDTO : BaseDTO
    {
        public int Id { get; set; }
        public string NameEN { get; set; }
        public string NameVN { get; set; }
        public string DescriptionEN { get; set; }
        public string DescriptionVN { get; set; }
        public string Avatar { get; set; }
        //public ICollection<ProductDTO> Products { get; set; }
        //public BrandDTO()
        //{
        //    Products = new List<ProductDTO>();
        //}
    }
}
