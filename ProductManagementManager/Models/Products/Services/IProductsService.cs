using ProductManagementManager.Models.Products.Dtos;

namespace ProductManagementManager.Models.Products.Services
{
    public interface IProductsService
    {
        ServiceResult<List<ProductsDto>> Get();
        ServiceResult<ProductsDto> Get(int id);
        ServiceResult<ProductsDto> Create(AddRequest request);
        ServiceResult Update(UpdateRequest request);
        ServiceResult Delete(int id);
    }
}
