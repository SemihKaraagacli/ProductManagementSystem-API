using AutoMapper;
using ProductManagementManager.Models.Repositories.Product.Entites;
using ProductManagementManager.Models.Repositories.User;
using ProductManagementManager.Models.Services.Product.Dtos;
using ProductManagementManager.Models.Services.User.Dtos;

namespace ProductManagementManager.Models.Services.Mapper
{
    public class BaseMapping : Profile
    {
        public BaseMapping()
        {
            CreateMap<ProductsDto, ProductsEntity>().ReverseMap();
            CreateMap<AddRequest, ProductsEntity>();
            CreateMap<UpdateRequest, ProductsEntity>();

            CreateMap<UserDto, AppUser>().ReverseMap();
        }
    }
}
