using ProductManagementManager.Models.Services.Product.Dtos;

namespace ProductManagementManager.Models.Services.Product.Services
{
    public interface IProductsService
    {
        Task<ServiceResult<List<ProductsDto>>> Get();
        Task<ServiceResult<ProductsDto>> Get(int id);
        Task<ServiceResult<ProductsDto>> Create(AddRequest request);
        Task<ServiceResult> Update(UpdateRequest request);
        Task<ServiceResult> Delete(int id);
    }
}
