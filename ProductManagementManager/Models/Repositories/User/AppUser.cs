using Microsoft.AspNetCore.Identity;
using ProductManagementManager.Models.Repositories.Product.Entites;

namespace ProductManagementManager.Models.Repositories.User
{
    public class AppUser : IdentityUser<Guid>
    {
        public List<ProductsEntity>? Products { get; set; }
    }
}
