using ProductManagementManager.Models.Repositories.User;

namespace ProductManagementManager.Models.Repositories.Product.Entites
{
    public class ProductsEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Explain { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public Guid UserId { get; set; }
        public AppUser User { get; set; } = default!;
    }
}
