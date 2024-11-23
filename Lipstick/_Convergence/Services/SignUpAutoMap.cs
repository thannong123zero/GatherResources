using AutoMapper;
using Lipstick._Convergence.DataAccess.DTOs;
using Lipstick.Areas.Admin.Models;

namespace Lipstick._Convergence.Services
{
    public class SignUpAutoMap : Profile
    {
        public SignUpAutoMap()
        {
            CreateMap<BlogDTO, ArticleViewModel>().ReverseMap();
            CreateMap<CategoryDTO, CategoryViewModel>().ReverseMap();
            CreateMap<SubCategoryDTO, SubCategoryViewModel>().ReverseMap();
            CreateMap<ProductDTO, ProductViewModel>().ReverseMap();
            CreateMap<BrandDTO, BrandViewModel>().ReverseMap();
        }
    }
}
