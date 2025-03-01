﻿using System.ComponentModel.DataAnnotations;

namespace Lipstick.Areas.Admin.Models
{
    public class CategoryViewModel : BaseViewModel
    {
        public Guid ID { get; set; }
        public string NameEN { get; set; }
        public string NameVN { get; set; }
        public string? DescriptionEN { get; set; }
        public string? DescriptionVN { get; set; }
        public bool InNavbar { get; set; }
        [Range(1, 9999)]
        public int Priority { get; set; }
        public CategoryViewModel()
        {
            ID = Guid.NewGuid();
            IsDeleted = false;
            IsActive = true;
            Priority = 99;
        }
    }
}
