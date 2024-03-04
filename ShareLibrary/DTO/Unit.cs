﻿using SharedLibrary.UserInterfaceDTO;

namespace SharedLibrary.DTO
{
    public class Unit : BaseDTO
    {
        public Guid ID { get; set; }
        public string NameEN { get; set; }
        public string NameVN { get; set; }
        public string DiscriptionEN { get; set; }
        public string DiscriptionVN { get; set; }
        public ICollection<ProductUI> Products { get; set; }
    }
}
