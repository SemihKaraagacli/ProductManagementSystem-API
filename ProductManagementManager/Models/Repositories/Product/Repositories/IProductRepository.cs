using ProductManagementManager.Models.Repositories.GenericRepositories;
using ProductManagementManager.Models.Repositories.Product.Entites;

namespace ProductManagementManager.Models.Repositories.Product.Repositories
{
    public interface IProductRepository : IGenericRepository<ProductsEntity>
    {
    }
}