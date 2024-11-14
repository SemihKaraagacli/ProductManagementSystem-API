using ProductManagementManager.Models.Repositories.Context;
using ProductManagementManager.Models.Repositories.GenericRepositories;
using ProductManagementManager.Models.Repositories.Product.Entites;
using ProductManagementManager.Models.Repositories.Product.Repositories;

namespace ProductManagementManager.Models.Repositories
{
    public class ProductRepository(AppDbContext context) : GenericRepository<ProductsEntity>(context), IProductRepository
    {
    }
}
