using AutoMapper;
using ProductManagementManager.Models.Products.Dtos;
using ProductManagementManager.Models.Products.Entites;

namespace ProductManagementManager.Models.Products.Mapper
{
    public class BaseMapping : Profile
    {
        public BaseMapping()
        {
            CreateMap<ProductsDto, ProductsEntity>().ReverseMap();
            CreateMap<AddRequest, ProductsEntity>();
            CreateMap<UpdateRequest, ProductsEntity>();

        }
    }
}
