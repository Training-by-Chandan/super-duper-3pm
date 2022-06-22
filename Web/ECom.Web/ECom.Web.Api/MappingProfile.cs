using AutoMapper;
using ECom.Models.Models;
using ECom.Models.ViewModel;

namespace ECom.Web.Api
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryCreateViewModel>().ReverseMap();
            CreateMap<Product, ProductViewModel>().AfterMap((src, dest) =>
            {
                dest.CategoryName = src.Category == null ? "" : src.Category.Name;
            }).ReverseMap();
        }
    }
}