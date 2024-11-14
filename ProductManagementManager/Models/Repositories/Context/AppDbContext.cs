using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProductManagementManager.Models.Repositories.Product.Entites;
using ProductManagementManager.Models.Repositories.User;

namespace ProductManagementManager.Models.Repositories.Context
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : IdentityDbContext<AppUser, AppRole, Guid>(options)
    {
        public DbSet<ProductsEntity> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductsEntity>().Property(x => x.Price).HasPrecision(18, 2);
            base.OnModelCreating(modelBuilder);
        }
    }
}
