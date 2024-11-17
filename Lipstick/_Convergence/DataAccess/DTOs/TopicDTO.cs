using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lipstick._Convergence.DataAccess.DTOs
{
    public class TopicDTO : BaseDTO
    {
        public int Id { get; set; }
        public string NameEN { get; set; }
        public string NameVN { get; set; }
        public string DescriptionEN { get; set; }
        public string DescriptionVN { get; set; }
        public int Priority { get; set; }
        //public ICollection<ArticleDTO> Articles { get; set; }
        //public TopicDTO()
        //{
        //    Articles = new List<ArticleDTO>();
        //}
    }
}
