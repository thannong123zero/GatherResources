using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lipstick.Areas.Admin.Models
{
    public class ArticleUI : BaseUI
    {
        public int ID { get; set; }
        public int TopicID { get; set; }
        public string SubjectEN { get; set; }
        public string SubjectVN { get; set; }
        public string DescriptionEN { get; set; }
        public string DescriptionVN { get; set; }
        public string ContentEN { get; set; }
        public string ContentVN { get; set; }
        public string Avatar { get; set; }
        public ArticleUI()
        {
            IsActive = true;
        }
    }
}
