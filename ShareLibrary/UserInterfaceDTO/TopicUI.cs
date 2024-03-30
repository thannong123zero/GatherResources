﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.UserInterfaceDTO
{
    public class TopicUI
    {
        public Guid ID { get; set; }
        public string NameEN { get; set; }
        public string NameVN { get; set; }
        public string DescriptionEN { get; set; }
        public string DescriptionVN { get; set; }
        public int Priority { get; set; }
    }
}
