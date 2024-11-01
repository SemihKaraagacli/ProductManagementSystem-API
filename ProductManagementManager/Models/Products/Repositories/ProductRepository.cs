using ProductManagementManager.Models.Products.Entites;
using ProductManagementManager.Models.Products.Repositories;

namespace ProductManagementManager.Models.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public List<ProductsEntity> productsList = new();
        public ProductRepository()
        {
            productsList.Add(new ProductsEntity { Id = 1, Name = "İsim", Explain = "açıklama", Price = 5.2m, Stock = 4 });
            productsList.Add(new ProductsEntity { Id = 2, Name = "İsim 1", Explain = "açıklama 1", Price = 6.2m, Stock = 5 });
            productsList.Add(new ProductsEntity { Id = 3, Name = "İsim 2", Explain = "açıklama 2", Price = 7.2m, Stock = 6 });
            productsList.Add(new ProductsEntity { Id = 4, Name = "İsim 3", Explain = "açıklama 3", Price = 8.2m, Stock = 7 });
            productsList.Add(new ProductsEntity { Id = 5, Name = "İsim 4", Explain = "açıklama 4", Price = 9.2m, Stock = 8 });
            productsList.Add(new ProductsEntity { Id = 6, Name = "İsim 5", Explain = "açıklama 5", Price = 10.2m, Stock = 9 });
            productsList.Add(new ProductsEntity { Id = 7, Name = "İsim 6", Explain = "açıklama 6", Price = 11.2m, Stock = 10 });
            productsList.Add(new ProductsEntity { Id = 8, Name = "İsim 7", Explain = "açıklama 7", Price = 12.2m, Stock = 11 });
            productsList.Add(new ProductsEntity { Id = 9, Name = "İsim 8", Explain = "açıklama 8", Price = 13.2m, Stock = 12 });

        }


        public List<ProductsEntity> Get()
        {
            return productsList;
        }

        public ProductsEntity GetByID(int id)
        {
            return productsList.FirstOrDefault(x => x.Id == id);

        }

        public ProductsEntity Create(ProductsEntity entity)
        {
            productsList.Add(entity);
            return entity;
        }

        public void Update(ProductsEntity entity)
        {
            var updateProduct = productsList.FirstOrDefault(x => x.Id == entity.Id);
            if (updateProduct != null)
            {
                updateProduct.Name = entity.Name;
                updateProduct.Price = entity.Price;
                updateProduct.Stock = entity.Stock;
                updateProduct.Explain = entity.Explain;
            }
        }

        public void Delete(int id)
        {
            var deleteProduct = productsList.FirstOrDefault(x => x.Id == id);
            if (deleteProduct != null)
            {
                productsList.Remove(deleteProduct);
            }
        }
    }
}
