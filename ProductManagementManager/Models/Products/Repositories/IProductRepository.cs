using ProductManagementManager.Models.Products.Entites;

namespace ProductManagementManager.Models.Products.Repositories
{
    public interface IProductRepository
    {
        List<ProductsEntity> Get();
        ProductsEntity GetByID(int id);
        ProductsEntity Create(ProductsEntity entity);
        void Update(ProductsEntity entity);
        void Delete(int id);
    }
}