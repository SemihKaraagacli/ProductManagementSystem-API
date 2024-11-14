
using ProductManagementManager.Models.Repositories.Context;

namespace ProductManagementManager.Models.Repositories.UnitOfWork
{
    public class UnitOfWork(AppDbContext appDbContext) : IUnitOfWork
    {
        public Task<int> CommitAsync()
        {
            return appDbContext.SaveChangesAsync();
        }
    }
}
